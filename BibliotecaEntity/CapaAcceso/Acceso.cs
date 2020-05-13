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

        public string AnadirLibro(string isbn, string titulo, string editorial, string sipnosis, string unidades, string caratula, List<Categoria> categorias, List<Autor> autores)
        {
            return nuevoAcceso.AnadirLibro(isbn, titulo, editorial, sipnosis, unidades, caratula, categorias, autores);
        }

    }
}
