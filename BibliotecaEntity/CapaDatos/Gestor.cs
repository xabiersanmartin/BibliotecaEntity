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
                msg  = "No se a podido conectar con la base de datos, contacte con el administrador, código de error: " + ex.Message;
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
            if(!int.TryParse(isbnS, out isbn)) formato = true;
            if (formato == true) return "Formato de isbn incorrecto, debe ser númerico";

            int unidades;
            if (! int.TryParse(unidadesS, out unidades)) formato = true;
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

        public string AnadirCategoria (string nombreCategoria)
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
                return "Error, mensaje del error: "+ex.Message;
            }
        }

        public string AnadirAutor (string nombreAutor)
        {
            if (String.IsNullOrWhiteSpace(nombreAutor)) return "El nombre del autor no puede quedarse vacío";

            List<Autor> comprobarAutor = proyectoBiblioteca.Autors.Where(autor => autor.Descripcion == nombreAutor).ToList();

            if (comprobarAutor.Count != 0) return "Este autor ya existe";

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

        public string EliminarLibro (string idLibroS)
        {
            if (String.IsNullOrWhiteSpace(idLibroS)) return "El isbn no puede estar vacio";

            int idLibro;
            if (!int.TryParse(idLibroS, out idLibro)) return "Formato incorrecto";


            Libro eliminarLibro = proyectoBiblioteca.Libros.Find(idLibro);
            if (eliminarLibro == null)
            {
                return "No existe el libro";
            }

            List<Prestamo> comprobarPrestamo = proyectoBiblioteca.Prestamos.Where(prest=> prest.IdLibro == idLibro).ToList();
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
                        if (i+1 == comprobarPrestamo.Count)
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
    }
}
