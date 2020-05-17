using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAcceso
{
    public class Acceso
    {
        Gestor nuevoAcceso = new Gestor(out string msg);

        public List<Categoria> DevolverCategorias()
        {
            return nuevoAcceso.DevolverCategorias();
        }

        public List<Autor> DevolverAutores()
        {
            return nuevoAcceso.DevolverAutores();
        }

        public List<Libro> DevolverLibros(out string msg)
        {
            return nuevoAcceso.DevolverLibros(out msg);
        }

        public string AnadirLibro(string isbn, string titulo, string editorial, string sipnosis, string unidades, string caratula, List<Categoria> categorias, List<Autor> autores)
        {
            return nuevoAcceso.AnadirLibro(isbn, titulo, editorial, sipnosis, unidades, caratula, categorias, autores);
        }

        public string AnadirCategoria (string nombreCategoria)
        {
            return nuevoAcceso.AnadirCategoria(nombreCategoria);
        }

        public string AnadirAutor (string nombreAutor)
        {
            return nuevoAcceso.AnadirAutor(nombreAutor);
        }

        public string EliminarLibro (string idLibro)
        {
            return nuevoAcceso.EliminarLibro(idLibro);
        }

        public List<Libro> BuscarLibros(string nombreLibro)
        {
            return nuevoAcceso.BuscarLibro(nombreLibro);
        }

        public bool ComprobarNumeroCarnet (int numeroCarnet)
        {
            return nuevoAcceso.ComprobarNumeroCarnet(numeroCarnet);
        }

        public string AnadirLector (string numeroCarnet, string nombre, string contrasena, string telefono, string mail)
        {
            return nuevoAcceso.AnadirLector(numeroCarnet, nombre, contrasena, telefono, mail);
        }

        public string AnadirPrestamo (int idLibro, int numeroCarnet)
        {
            return nuevoAcceso.AnadirPrestamo(idLibro, numeroCarnet);
        }
    }
}
