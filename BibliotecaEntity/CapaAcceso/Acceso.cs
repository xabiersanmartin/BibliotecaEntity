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

        public List<Categoria> DevolverCategorias(out string msg)
        {
            return nuevoAcceso.DevolverCategorias(out msg);
        }

        public List<Autor> DevolverAutores(out string msg)
        {
            return nuevoAcceso.DevolverAutores(out msg);
        }

        public List<Libro> DevolverLibros(out string msg)
        {
            return nuevoAcceso.DevolverLibros(out msg);
        }

        public List<Prestamo> DevolverPrestamos(out string msg)
        {
            return nuevoAcceso.DevolverPrestamos(out msg);
        }

        public List<Libro> DevolverLibrosAutor(int idAutor, out string msg)
        {
            return nuevoAcceso.DevolverLibrosAutor(idAutor, out msg);
        }

        public string AnadirLibro(string isbn, string titulo, string editorial, string sipnosis, string unidades, string caratula, bool disponibilidad, List<Categoria> categorias, List<Autor> autores)
        {
            return nuevoAcceso.AnadirLibro(isbn, titulo, editorial, sipnosis, unidades, caratula, disponibilidad, categorias, autores);
        }

        public string AnadirCategoria(string nombreCategoria)
        {
            return nuevoAcceso.AnadirCategoria(nombreCategoria);
        }

        public string AnadirAutor(string nombreAutor)
        {
            return nuevoAcceso.AnadirAutor(nombreAutor);
        }

        public string EliminarLibro(string idLibro)
        {
            return nuevoAcceso.EliminarLibro(idLibro);
        }

        public List<Libro> BuscarLibros(string busqueda)
        {
            return nuevoAcceso.BuscarLibro(busqueda);
        }

        public Libro LibroIsbn (int isbn, out string msg)
        {
            return nuevoAcceso.LibroIsbn(isbn, out msg);
        }

        public List<Autor> BuscarAutor(string nombreAutor)
        {
            return nuevoAcceso.BuscarAutor(nombreAutor);
        }

        public bool ComprobarNumeroCarnet(int numeroCarnet)
        {
            return nuevoAcceso.ComprobarNumeroCarnet(numeroCarnet);
        }

        public string AnadirLector(string numeroCarnet, string nombre, string contrasena, string telefono, string mail)
        {
            return nuevoAcceso.AnadirLector(numeroCarnet, nombre, contrasena, telefono, mail);
        }

        public string AnadirPrestamo(int idLibro, int numeroCarnet)
        {
            return nuevoAcceso.AnadirPrestamo(idLibro, numeroCarnet);
        }

        public string EliminarPrestamo(int isbn, int numeroCarnet)
        {
            return nuevoAcceso.EliminarPrestamo(isbn, numeroCarnet);
        }

        public List<Prestamo> PrestamosLector(string numeroCarnet, out string msg)
        {
            return nuevoAcceso.PrestamosLector(numeroCarnet, out msg);
        }
    }
}
