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

        public Gestor(out string msg) // TODO 
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

        public List<Categoria> DevolverCategorias(out string msg) // TODO ¿Por qué devolver null si no hay ninguna?
        {
            if (proyectoBiblioteca.Categorias.ToList().Count != 0)
            {
                msg = "";
                return proyectoBiblioteca.Categorias.ToList();
            }
            else
            {
                msg = "No hay categorías";
                return null;
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
            // TODO ¿¿Buscar entre TODOS los préstamos??? --> NOOOOOOOO Solo debe buscar en los del libro
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
        // TODO ¿No sería más lógico que busque por campo clave? Puede haber 2 títulos con el mismo título?. Para el resto de búsquedas igual
        public List<Libro> BuscarLibro(string nombreLibro)
        {
            List<Libro> libroFiltrado = new List<Libro>();
            libroFiltrado = proyectoBiblioteca.Libros.Where(lib => lib.Titulo.Contains(nombreLibro)).ToList();

            return libroFiltrado;
        }

        public List<Autor> BuscarAutor(string nombreAutor)
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
            // TODO De nuevo busca entre todos los préstamos, y solo debe ser lo es lector
            List<Prestamo> prestamosLector = proyectoBiblioteca.Prestamos.Where(prest => prest.IdLector == numeroCarnet).ToList();

            if (prestamosLector.Count == 0)
            {
                msg = "Este socio no tiene ningún préstamo";
                return null;
            }

            msg = "";
            return prestamosLector;
        }

        public bool ComprobarNumeroCarnet(int numeroCarnet)
        {
            // TODO Mira el códiog siguiente
            //Lector comprobarLector = proyectoBiblioteca.Lectors.Find(numeroCarnet);

            //if (comprobarLector != null)
            //{
            //    return true;
            //}
            //return false;


            return proyectoBiblioteca.Lectors.Find(numeroCarnet)!=null;
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
                // TODO Ver como queda ahora sin usar NumPrestado
                if ((comprobarLibro.Unidades - comprobarLibro.NumPrestado) == 1)
                {
                    modificarLibro = new Libro(comprobarLibro.Isbn, comprobarLibro.Titulo, comprobarLibro.Editorial, comprobarLibro.Sipnosis, comprobarLibro.Caratula, comprobarLibro.Unidades, comprobarLibro.NumPrestado + 1, false);
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
                    // TODO Sobraría ¿verdad?
                    Libro libroUpdate = proyectoBiblioteca.Libros.SingleOrDefault(lib => lib.Isbn == idLibro);
                    libroUpdate.NumPrestado = modificarLibro.NumPrestado;
                    libroUpdate.Disponibilidad = modificarLibro.Disponibilidad; // TODO Esto lo quitamos
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

        public String EliminarPrestamo(int isbn, int numeroCarnet)
        {
            if (proyectoBiblioteca.Lectors.Find(numeroCarnet) == null) return "Este socio no existe";

            if (proyectoBiblioteca.Libros.Find(isbn) == null) return "No existe el libro";
            // TODO Lo de siempre..... No debe recorrer TODOS los préstamos, y no debe realizar la instrucción de búsqueda 2 veces (432,436)
            if (proyectoBiblioteca.Prestamos.Find(isbn, numeroCarnet) == null) return "Este préstamo no existe";

            try
            {
                Prestamo prestamoEliminar = proyectoBiblioteca.Prestamos.Find(isbn, numeroCarnet);
                proyectoBiblioteca.Prestamos.Remove(prestamoEliminar);
                int exito = proyectoBiblioteca.SaveChanges();

                if (exito != 0) // todo sobraría casi todo
                {
                    Libro libroUpdate = proyectoBiblioteca.Libros.SingleOrDefault(lib => lib.Isbn == isbn);
                    libroUpdate.NumPrestado = libroUpdate.NumPrestado - 1;
                    if (libroUpdate.Disponibilidad == false)
                    {
                        libroUpdate.Disponibilidad = true;
                    }
                    exito = proyectoBiblioteca.SaveChanges();
                    if (exito != 0)
                    {
                        return "Libro devuelto correctamente";
                    }
                    else
                    {
                        proyectoBiblioteca.Prestamos.Add(prestamoEliminar);
                        return "El libro no se ha podido devolver";
                    }
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
