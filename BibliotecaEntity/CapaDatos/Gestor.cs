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
                msg = "No se a podido conectar con la base de datos, contacte con el administrador, código de error: " + ex.Message;
            }
        }

        public List<Categoria> DevolverCategorias()
        {
            if (proyectoBiblioteca.Categorias.ToList().Count != 0)
            {
                return proyectoBiblioteca.Categorias.ToList();
            }
            else
            {
                return null;
            }

        }

        public List<Autor> DevolverAutores()
        {
            if (proyectoBiblioteca.Autors.ToList().Count != 0)
            {
                return proyectoBiblioteca.Autors.ToList();
            }
            else
            {
                return null;
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
                return null;
            }
        }

        public string AnadirLibro(string isbnS, string titulo, string editorial, string sipnosis, string unidadesS, string caratula, List<Categoria> categorias, List<Autor> autores)
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
                    return "No existe esta categoria";
                }
            }

            foreach (var autor in autores)
            {
                if (proyectoBiblioteca.Autors.Find(autor.IdAutor) == null)
                {
                    return "Este autor no existe";
                }
            }

            Libro newLibro = new Libro(isbn, titulo, editorial, sipnosis, caratula, unidades, 0, true, autores, categorias);

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

            List<Categoria> comprobarCategoria = proyectoBiblioteca.Categorias.Where(cat => cat.Descripcion == nombreCategoria).ToList();

            if (comprobarCategoria.Count != 0) return "esta categoria ya existe";

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

            Autor comprobarAutor = proyectoBiblioteca.Autors.Where(autor => autor.Descripcion == nombreAutor).SingleOrDefault();

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

            List<Prestamo> comprobarPrestamo = proyectoBiblioteca.Prestamos.Where(prest => prest.IdLibro == idLibro).ToList();
            if (comprobarPrestamo.Count != 0)
            {
                string lectores = "";
                int comprobacionMensaje = 0;
                for (int i = 0; i < comprobarPrestamo.Count; i++)
                {
                    Lector lector = proyectoBiblioteca.Lectors.Find(comprobarPrestamo[i].IdLector);
                    int result = DateTime.Compare(comprobarPrestamo[i].FechaDevolucion, DateTime.Today);
                    if (result > 0)
                    {
                        comprobacionMensaje += 1;
                        if (i + 1 == comprobarPrestamo.Count)
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

        public List<Libro> BuscarLibro(string nombreLibro)
        {
            List<Libro> libroFiltrado = new List<Libro>();
            libroFiltrado = proyectoBiblioteca.Libros.Where(lib => lib.Titulo.Contains(nombreLibro)).ToList();

            return libroFiltrado;
        }

        public bool ComprobarNumeroCarnet(int numeroCarnet)
        {
            Lector comprobarLector = proyectoBiblioteca.Lectors.Find(numeroCarnet);

            if (comprobarLector != null)
            {
                return true;
            }
            return false;
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
            Libro comprobarLibro = proyectoBiblioteca.Libros.Find(idLibro);
            Prestamo comprobarPrestamo = proyectoBiblioteca.Prestamos.Find(idLibro, numeroCarnet);
            Lector comprobarLector = proyectoBiblioteca.Lectors.Find(numeroCarnet);

            //Comprobaciones: los datos introducidos son válidos
            if (comprobarLector == null) return "No existe el socio";
            if (comprobarLibro == null) return "No existe el libro";
            if (comprobarPrestamo != null) return "Este socio ya tiene prestado este libro";

            //Comprobaciones: disponibilidad del libro
            Libro modificarLibro = new Libro();
            if (comprobarLibro.Disponibilidad == true)
            {
                if ((comprobarLibro.Unidades - comprobarLibro.NumPrestado) == 0)
                {
                    modificarLibro = new Libro(comprobarLibro.Isbn, comprobarLibro.Titulo, comprobarLibro.Editorial, comprobarLibro.Sipnosis, comprobarLibro.Caratula, comprobarLibro.Unidades, comprobarLibro.NumPrestado, false);
                }
                else
                {
                    modificarLibro = new Libro(comprobarLibro.Isbn, comprobarLibro.Titulo, comprobarLibro.Editorial, comprobarLibro.Sipnosis, comprobarLibro.Caratula, comprobarLibro.Unidades, comprobarLibro.NumPrestado + 1, true);
                }
            }
            else
            {
                return "El libro no se puede prestar porque no esta disponible";
            }

            //Hacemos el préstamo
            try
            {
                int exito;
                Prestamo nuevoPrestamo = new Prestamo(idLibro, numeroCarnet, DateTime.Today, DateTime.Today.AddDays(14));
                proyectoBiblioteca.Prestamos.Add(nuevoPrestamo);
                exito = proyectoBiblioteca.SaveChanges();
                if (exito != 0)
                {
                    Libro libroUpdate = proyectoBiblioteca.Libros.SingleOrDefault(lib => lib.Isbn == idLibro);
                    libroUpdate.NumPrestado = modificarLibro.NumPrestado;
                    libroUpdate.Disponibilidad = modificarLibro.Disponibilidad;
                    exito = proyectoBiblioteca.SaveChanges();
                    if (exito != 0)
                    {
                        return "Préstamo añadido correctamente";
                    }
                    else
                    {
                        proyectoBiblioteca.Prestamos.Remove(nuevoPrestamo);
                        return "El préstamo no pudo realizarse";
                    }
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
    }
}
