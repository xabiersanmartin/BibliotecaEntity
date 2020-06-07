using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmBorrarLibro : Form
    {
        string rutaCaratulas = Path.GetDirectoryName(Application.ExecutablePath) + @"\Caratulas\";
        public FrmBorrarLibro()
        {
            InitializeComponent();
        }

        private void FrmBorrarLibro_Load(object sender, EventArgs e)
        {
            string msg = "";
            List<Libro> libros = Program.acceso.DevolverLibros(out msg);

            if (msg != "")
            {
                MessageBox.Show(msg,"ATENCION");
                cboLibros.Enabled = false;
                return;
            }

            cboLibros.Items.Clear();
            cboLibros.Items.AddRange(libros.ToArray());
            cboLibros.DisplayMember = "Titulo";
        }

        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibros.SelectedIndex == -1)
            {
                lblIsbn.Text = "";
                lblEditorial.Text = "";
                lblTitulo.Text = "";
                lblUnidades.Text = "";
                lblAutores.Text = "";
                lblCategorias.Text = "";
                pctCaratula.Image.Dispose();
                pctCaratula.Image = null;
                return;
            }

            Libro libroSeleccionado = cboLibros.SelectedItem as Libro;
            lblTitulo.Text = libroSeleccionado.Titulo;
            lblEditorial.Text = libroSeleccionado.Editorial;
            lblIsbn.Text = libroSeleccionado.Isbn.ToString();
            lblUnidades.Text = libroSeleccionado.Unidades.ToString();
            lblAutores.Text = string.Concat(libroSeleccionado.Autores.Select(aut => aut.Descripcion + ", ")).Substring(0, string.Concat(libroSeleccionado.Autores.Select(aut => aut.Descripcion + ", ")).Length - 2); // TODO Se rompe aquí si es un libro que acabo de crear --> Consecuencia de haber planteado mal los contructores
            lblCategorias.Text = string.Concat(libroSeleccionado.Categorias.Select(cat => cat.Descripcion + ", ")).Substring(0, string.Concat(libroSeleccionado.Categorias.Select(cat => cat.Descripcion + ", ")).Length - 2);
            pctCaratula.ImageLocation = rutaCaratulas + libroSeleccionado.Caratula;
            pctCaratula.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnBorrarLibro_Click(object sender, EventArgs e)
        {
            if (cboLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Antes de eliminar debes escoger que libro quieres eliminar.", "ATENCIÓN");
                return;
            }

            Libro libroEliminar = cboLibros.SelectedItem as Libro;
            string nombreCaratula = libroEliminar.Caratula;
            string mensaje = Program.acceso.EliminarLibro(libroEliminar.Isbn.ToString());
            if (mensaje != "Libro eliminado correctamente")
            {
                MessageBox.Show(mensaje, "ATENCION");
                pctCaratula.Image.Dispose();
                pctCaratula.Image = null;
            }
            else
            {
                if (File.Exists(rutaCaratulas + nombreCaratula))
                {
                    pctCaratula.Image.Dispose();
                    pctCaratula.Image = null;
                    File.Delete(rutaCaratulas + nombreCaratula);
                }
                MessageBox.Show(mensaje);
            }
            

            string msg = "";
            List<Libro> librosActualizados = Program.gestor.DevolverLibros(out msg);
            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                cboLibros.SelectedIndex = -1;
                cboLibros.Text = "";

                lblIsbn.Text = "";
                lblEditorial.Text = "";
                lblTitulo.Text = "";
                lblUnidades.Text = "";
                lblAutores.Text = "";
                lblCategorias.Text = "";
                pctCaratula.Image.Dispose();
                pctCaratula.Image = null;
                return;
            }

            cboLibros.Items.Clear();
            cboLibros.Items.AddRange(librosActualizados.ToArray());
            cboLibros.DisplayMember = "Titulo";
            cboLibros.Text = "";
            cboLibros.SelectedIndex = -1;

            lblIsbn.Text = "";
            lblEditorial.Text = "";
            lblTitulo.Text = "";
            lblUnidades.Text = "";
            lblAutores.Text = "";
            lblCategorias.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
