using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmBorrarLibro : Form
    {
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
                pctCaratula.Image.Dispose();
                pctCaratula.Image = null;
                return;
            }

            Libro libroSeleccionado = cboLibros.SelectedItem as Libro;
            lblTitulo.Text = libroSeleccionado.Titulo;
            lblEditorial.Text = libroSeleccionado.Editorial;
            lblIsbn.Text = libroSeleccionado.Isbn.ToString();
            lblUnidades.Text = libroSeleccionado.Unidades.ToString();
            pctCaratula.ImageLocation = libroSeleccionado.Caratula;
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
            string mensaje = Program.acceso.EliminarLibro(libroEliminar.Isbn.ToString());
            if (mensaje != "Libro eliminado correctamente")
            {
                MessageBox.Show(mensaje, "ATENCION");
            }
            else
            {
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
            pctCaratula.Image.Dispose();
            pctCaratula.Image = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
