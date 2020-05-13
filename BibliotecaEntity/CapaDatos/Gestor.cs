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

        public string AnadirLibro(string isbnS, string titulo, string editorial, string sipnosis, string unidadesS, string caratula, List<Categoria> categorias, List<Autor> autores)
        {
            int isbn;
            bool formato = false;
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

            Libro newLibro = new Libro(isbn, titulo, editorial, sipnosis, caratula, unidades, 0, true,autores,categorias);

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
    }
}
