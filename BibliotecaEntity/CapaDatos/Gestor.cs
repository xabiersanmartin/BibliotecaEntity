using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {
        ProyectoBibliotecaXabierEntities proyectoBiblioteca;

        public Gestor(out string msg)
        {
            msg = "";
            try
            {
                proyectoBiblioteca = new ProyectoBibliotecaXabierEntities();
            }
            catch (Exception ex)
            {
                msg = "No se ha podido conectar con la base de datos, contacte con el administrador, código de error: " + ex.Message;
            }
        }

        public List<Categoria> DevolverCategorias(out string msg)
        {
            if (proyectoBiblioteca.Categorias.ToList().Count != 0) // TODO Te quería decir, que en realidad vale con devolver proyectoBiblioteca.Categorias.ToList(), pues es lo que hará aunque no tenga ninguna (sin necesidad del if) 
            {
                msg = "";
                return proyectoBiblioteca.Categorias.ToList();
            }
            else
            {
                msg = "No hay categorías";
                List<Categoria> categoriasVacias = new List<Categoria>();
                return categoriasVacias;
            }

        }

        public List<Autor> DevolverAutores(out string msg)
        {
            if (proyectoBiblioteca.Autors.ToList().Count != 0)
            {
                msg = "";
                return proyectoBiblioteca.Autors.ToList();
            }
            else
            {
                msg = "No hay autores";
                List<Autor> autoresVacios = new List<Autor>();
                return autoresVacios;
            }

        }

        public List<Libro> DevolverLibros(out string msg)
        {
            if (proyectoBiblioteca.Libros.ToList().Count != 0)
            {
                msg = "";
                return proyectoBiblioteca.Libros.ToList();
            }
            else
            {
                msg = "No hay libros";
                List<Libro> librosVacios = new List<Libro>();
                return librosVacios;
            }
        }

        public List<Prestamo> DevolverPrestamos(out string msg)
        {
            if (proyectoBiblioteca.Prestamos.ToList().Count != 0)
            {
                msg = "";
                return proyectoBiblioteca.Prestamos.ToList();
            }
            else
            {
                msg = "No hay préstamos";
                List<Prestamo> prestamoVacios = new List<Prestamo>();
                return prestamoVacios;
            }
        }

        public string AnadirLibro(string isbnS, string titulo, string editorial, string sipnosis, string unidadesS, string caratula, bool disponibilidad, List<Categoria> categorias, List<Autor> autores)
        {
            int isbn;
            bool formato = false; //Esta variable la pondremos en true en caso de que no pueda transformarse de string a int ya que sera "un formato invalido"
            if (!int.TryParse(isbnS, out isbn)) formato = true;
            if (formato == true) return "Formato de isbn incorrecto, debe ser númerico";

            int unidades;
            if (!int.TryParse(unidadesS, out unidades)) formato = true;
            if (formato == true) return "Formato de unidades incorrecto, debe ser númerico";

            if (String.IsNullOrWhiteSpace(titulo)) return "No puedes dejar el titulo vacio";

            if (String.IsNullOrWhiteSpace(editorial)) return "No puedes dejar la editorial vacia";

            if (String.IsNullOrWhiteSpace(sipnosis)) return "Debes escribir una sipnosis no puedes dejarlo vacio";

            if (String.IsNullOrWhiteSpace(caratula)) return "Debes seleccionar una caratula";

            if (isbn <= 0) return "El isbn no puede ser 0, ni tampoco un número negativo";

            if (unidades <= 0) return "Las unidades del libro no pueden ser 0 ni menores de 0";

            if (proyectoBiblioteca.Libros.Find(isbn) != null)
            {
                return "Este isbn ya pertenece a un libro";
            }

            if (categorias.Count == 0) return "No hay ninguna categoría";

            if (autores.Count == 0) return "No hay ningun autor";

            foreach (var cat in categorias)
            {
                if (proyectoBiblioteca.Categorias.Find(cat.IdCategoria) == null)
                {
                    return "No existe esta categoria"; // TODO Debería devolver el id para saber a cual se refiere
                }
            }

            foreach (var autor in autores)
            {
                if (proyectoBiblioteca.Autors.Find(autor.IdAutor) == null)
                {
                    return "Este autor no existe";
                }
            }

            Libro newLibro = new Libro(isbn, titulo, editorial, sipnosis, caratula, unidades, 0, disponibilidad, autores, categorias);

            try
            {
                proyectoBiblioteca.Libros.Add(newLibro);

                int cambios = proyectoBiblioteca.SaveChanges();
                if (cambios == 0) return "Error al añadir el libro";
                return "Libro añadido correctamente";
            }
            catch (Exception ex)
            {
                return "Mensaje de error: " + ex.Message;
            }
        }

        public string AnadirCategoria(string nombreCategoria)
        {
            if (String.IsNullOrWhiteSpace(nombreCategoria))
            {
                return "No puede estar el nombre de la categoría vacio";
            }

            Categoria comprobarCategoria = proyectoBiblioteca.Categorias.Where(cat => cat.Descripcion == nombreCategoria).SingleOrDefault();

            if (comprobarCategoria != null) return "esta categoria ya existe";

            Categoria nuevaCategoria = new Categoria(nombreCategoria);
            try
            {
                proyectoBiblioteca.Categorias.Add(nuevaCategoria);
                int cambios = proyectoBiblioteca.SaveChanges();
                if (cambios == 0) return "Error al añadir la categoría";
                return "Categoría añadida correctamente";
            }
            catch (Exception ex)
            {
                return "Error, mensaje del error: " + ex.Message;
            }
        }

        public string AnadirAutor(string nombreAutor)
        {
            if (String.IsNullOrWhiteSpace(nombreAutor)) return "El nombre del autor no puede quedarse vacío";

            Autor comprobarAutor = proyectoBiblioteca.Autors.Where(autor => autor.Descripcion == nombreAutor).SingleOrDefault(); // TODO Control de mayúsculas y minúsculas

            if (comprobarAutor != null) return "Este autor ya existe";

            Autor nuevoAutor = new Autor(nombreAutor);

            try
            {
                proyectoBiblioteca.Autors.Add(nuevoAutor);

                int cambios = proyectoBiblioteca.SaveChanges();
                if (cambios == 0) return "Fallo al añadir el autor";
                return "Autor añadido correctamente";
            }
            catch (Exception ex)
            {
                return "Error, mensaje del error: " + ex.Message;
            }
        }

        public string EliminarLibro(string idLibroS)
        {
            if (String.IsNullOrWhiteSpace(idLibroS)) return "El isbn no puede estar vacio";

            int idLibro;
            if (!int.TryParse(idLibroS, out idLibro)) return "Formato incorrecto";


            Libro eliminarLibro = proyectoBiblioteca.Libros.Find(idLibro);
            if (eliminarLibro == null)
            {
                return "No existe el libro";
            }

            if (eliminarLibro.Prestamos.Count != 0)
            {
                string lectores = "";
                int comprobacionMensaje = 0;

                foreach (var prest in eliminarLibro.Prestamos)
                {

                    Lector lector = proyectoBiblioteca.Lectors.Find(prest.IdLector);
                    int result = DateTime.Compare(prest.FechaDevolucion, DateTime.Today);
                    if (result > 0)
                    {
                        comprobacionMensaje += 1;
                        if (eliminarLibro.Prestamos.Last() == prest)
                        {
                            lectores += String.Concat(lector.Nombre + " ");
                        }
                        else
                        {
                            lectores += String.Concat(lector.Nombre + ", ");
                        }
                    }
                }

                //Dependiendo de si esta prestado a 1 lector o a varios lectores sacamos un mensaje distinto.
                if (lectores != "" && comprobacionMensaje > 1)
                {
                    return "No se puede eliminar porque el libro " + eliminarLibro.Titulo + " esta prestado a los lectores \n \n " + lectores;
                }

                if (lectores != "" && comprobacionMensaje == 1)
                {
                    return "No se puede eliminar porque el libro " + eliminarLibro.Titulo + " esta prestado al lector \n \n " + lectores;
                }
            }

            try
            {
                proyectoBiblioteca.Libros.Remove(eliminarLibro);

                int cambios = proyectoBiblioteca.SaveChanges();
                if (cambios == 0) return "No se ha podido eliminar el libro";
                return "Libro eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error, mensaje del error: " + ex.Message;
            }
        }

        public List<Libro> BuscarLibro(string busqueda)
        {
            List<Libro> libroFiltrado = new List<Libro>(); // TODO Por mucho que le llames en singular, es una lista

            libroFiltrado = proyectoBiblioteca.Libros.Where(lib => lib.Titulo.Contains(busqueda)).ToList();


            return libroFiltrado;
        }

        public Libro LibroIsbn(int isbn, out string msg)
        {
            Libro buscarLibro = new Libro(isbn);
            if (proyectoBiblioteca.Libros.Find(isbn) == null) // TODO Nunca hay que repetir una búsqueda 2 veces. Debías guardar el dato en una libro y trabajar con él 
            {
                msg = "Este libro no existe";
                return null;
            }
            else
            {
                msg = "";
                return proyectoBiblioteca.Libros.Find(isbn);
            }
        }

        public List<Autor> BuscarAutor(string nombreAutor) // TODO De nuevo parece que es uno pero puede devolver varios
        {
            List<Autor> autorFiltrado = new List<Autor>();
            autorFiltrado = proyectoBiblioteca.Autors.Where(aut => aut.Descripcion.Contains(nombreAutor)).ToList();

            return autorFiltrado;
        }

        public List<Libro> DevolverLibrosAutor(int idAutor, out string msg)
        {
            Autor comprobarAutor = proyectoBiblioteca.Autors.Find(idAutor);

            if (comprobarAutor == null)
            {
                msg = "Este autor no existe";
                return null;
            }

            if (comprobarAutor.Libros.Count == 0)
            {
                msg = "Este autor no tiene libros";
                return null;
            }
            msg = "";
            return comprobarAutor.Libros.ToList();
        }

        public List<Prestamo> PrestamosLector(string numeroCarnetS, out string msg)
        {
            if (String.IsNullOrWhiteSpace(numeroCarnetS))
            {
                msg = "El número de carnet no puede estar vacío";
                return null;
            }

            int numeroCarnet;
            if (!int.TryParse(numeroCarnetS, out numeroCarnet))
            {
                msg = "El número de carnet debe ser numérico";
                return null;
            }

            Lector lector = proyectoBiblioteca.Lectors.Find(numeroCarnet);
            if (lector == null)
            {
                msg = "Este socio no existe";
                return null;
            }

            if (lector.Prestamos.Count == 0)
            {
                msg = "Este socio no tiene ningún préstamo";
                return null;
            }

            msg = "";
            return lector.Prestamos.ToList();
        }

        public bool ComprobarNumeroCarnet(int numeroCarnet)
        {
            return proyectoBiblioteca.Lectors.Find(numeroCarnet) != null;
        }

        public string AnadirLector(string numeroCarnetS, string nombre, string contrasena, string telefonoS, string mail)
        {
            if (String.IsNullOrWhiteSpace(numeroCarnetS)) return "El número de carnet no puede estar vacio";

            if (String.IsNullOrWhiteSpace(nombre)) return "El nombre no puede estar vacio";

            if (String.IsNullOrWhiteSpace(contrasena)) return "La contrseña no puede estar vacio";

            if (String.IsNullOrWhiteSpace(telefonoS)) return "El télefono no puede estar vacio";

            if (String.IsNullOrWhiteSpace(mail)) return "El mail no puede estar vacio";

            int numeroCarnet;
            if (!int.TryParse(numeroCarnetS, out numeroCarnet)) return "Formato incorrecto, recuerda que el número de carnet debe ser numerico";

            if (numeroCarnet <= 0) return "El número de carnet debe ser un número positivo y mayor a 0";

            if (telefonoS.Length > 9) return "El teléfono debe tener 9 números";

            int telefono;
            if (!int.TryParse(telefonoS, out telefono)) return "El número de télefono debe ser númerico";

            if (proyectoBiblioteca.Lectors.Find(numeroCarnet) != null) return "Este socio ya existe";

            Lector nuevoLector = new Lector(numeroCarnet, nombre, contrasena, telefonoS, mail);
            try
            {
                proyectoBiblioteca.Lectors.Add(nuevoLector);

                int cambios = proyectoBiblioteca.SaveChanges();
                if (cambios == 0) return "Fallo al añadir un nuevo socio";
                return "Socio añadido correctamente";
            }
            catch (Exception ex)
            {
                return "Error, el mensaje de error es: " + ex.Message;
            }
        }
        public string AnadirPrestamo(int idLibro, int numeroCarnet)
        {
            Libro comprobarLibro = proyectoBiblioteca.Libros.Find(idLibro); // TODO Si no existe el libro, para que quieres que siga mirando 
            Prestamo comprobarPrestamo = proyectoBiblioteca.Prestamos.Find(idLibro, numeroCarnet); // TODO ¿Entre todos los préstamos? --> Debía ser solo los del libro o lector
            Lector comprobarLector = proyectoBiblioteca.Lectors.Find(numeroCarnet);

            //Comprobaciones: los datos introducidos son válidos
            if (comprobarLector == null) return "No existe el socio"; // TODO Estos if debían ir antes
            if (comprobarLibro == null) return "No existe el libro";
            if (comprobarPrestamo != null) return "Este socio ya tiene prestado este libro";

            if (comprobarLibro.Prestamos.Count == comprobarLibro.Unidades) return "No quedan unidades de este libro";

            //Libro modificarLibro = new Libro();
            if (comprobarLibro.Disponibilidad != true)
            {
                return "El libro no se puede prestar porque no esta disponible";
            }

            //Hacemos el préstamo
            try
            {
                Prestamo nuevoPrestamo = new Prestamo(idLibro, numeroCarnet, DateTime.Today, DateTime.Today.AddDays(14));
                proyectoBiblioteca.Prestamos.Add(nuevoPrestamo);
                int exito = proyectoBiblioteca.SaveChanges();
                if (exito != 0)
                {
                    return "Préstamo realizado correctamente";
                }
                else
                {
                    return "El préstamo no pudo realizarse";
                }
            }
            catch (Exception ex)
            {
                return "Error, el mensaje de error es: " + ex.Message;
            }
        }

        public String EliminarPrestamo(int isbn, int numeroCarnet)
        {
            Lector lector = proyectoBiblioteca.Lectors.Find(numeroCarnet);

            if (lector == null)
            {
                return "Este socio no existe";
            }
            
            // TODO Otra vez, búsqueda entre TODOS los libros, en lugar de buscar solo entre los que tiene el lector
            if (proyectoBiblioteca.Libros.Find(isbn) == null) return "No existe el libro";
            // TODO Mas de lo mismo...
            Prestamo prestamoComprobar = lector.Prestamos.Where(p => p.IdLector == numeroCarnet && p.IdLibro == isbn).SingleOrDefault();
           
            if (prestamoComprobar == null) return "Este préstamo no existe";  

            try
            {
                proyectoBiblioteca.Prestamos.Remove(prestamoComprobar);
                int exito = proyectoBiblioteca.SaveChanges();

                if (exito != 0)
                {
                    return "Libro devuelto correctamente";
                }
                else
                {
                    return "El libro no se ha podido devolver";
                }
            }
            catch (Exception ex)
            {
                return "Error, el mensaje de error es: " + ex.Message;
            }
        }
    }
}
