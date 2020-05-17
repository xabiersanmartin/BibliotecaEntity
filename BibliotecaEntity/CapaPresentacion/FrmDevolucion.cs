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
    public partial class FrmDevolucion : Form
    {
        int numeroCarnet = 0;
        public FrmDevolucion()
        {
            InitializeComponent();
        }
        private void EstablecerAnchoColumnas()
        {
            dgvPrestamos.Columns[0].Width = 0;
            dgvPrestamos.Columns[1].Width = 300;
            dgvPrestamos.Columns[2].Width = 100;
            dgvPrestamos.Columns[3].Width = 100;
            dgvPrestamos.Columns[4].Width = 100;
            dgvPrestamos.Columns[0].Visible = false;
        }

        private void btnBuscarPrestamos_Click(object sender, EventArgs e)
        {

            List<Prestamo> prestamosLector = Program.acceso.PrestamosLector(txtNumeroCarnet.Text, out string msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                dgvPrestamos.DataSource = null;
                dgvPrestamos.Rows.Clear();
                return;
            }

            dgvPrestamos.DataSource = (from prest in prestamosLector
                                       select new { prest.IdLibro, prest.Libro.Titulo, prest.Lectores.Nombre, prest.FechaPrestado, prest.FechaDevolucion }).ToList();
            EstablecerAnchoColumnas();
            numeroCarnet = int.Parse(txtNumeroCarnet.Text);
        }

        private void txtNumeroCarnet_Click(object sender, EventArgs e)
        {
            txtNumeroCarnet.Text = "";
        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            if (numeroCarnet == 0)
            {
                MessageBox.Show("Antes de devolver un libro, debes introducir el socio", "ATENCIÓN");
                return;
            }

            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debes elegir en el recuadro que libro quieres prestar", "ATENCIÓN");
                return;
            }

            List<string> mensajesDevueltos = new List<string>();
            for (int i = 0; i < dgvPrestamos.SelectedRows.Count; i++)
            {
               int isbn = int.Parse(dgvPrestamos.SelectedRows[i].Cells[0].Value.ToString());
                mensajesDevueltos.Add(Program.acceso.EliminarPrestamo(isbn, numeroCarnet));
            }

            
            //ver si alguna devolución ha ido mal
            if (mensajesDevueltos.Where(m => m != "Libro devuelto con exito") == null)
            {
                MessageBox.Show("Uno de los libros no se pudo devolver correctamente, vuelva a buscar sus préstamos para verificar sus préstamos","ATENCIÓN");
                txtNumeroCarnet.Text = "";
                dgvPrestamos.DataSource = null;
                dgvPrestamos.Rows.Clear();
            }
            else
            {
                if (mensajesDevueltos.Count > 1)
                {
                    MessageBox.Show("Libros devueltos con exito");
                }
                else
                {
                    MessageBox.Show("Libro devuelto con exito");
                }
                
                List<Prestamo> prestamosLector = Program.acceso.PrestamosLector(numeroCarnet.ToString(), out string msg);

                if (msg != "")
                {
                    MessageBox.Show(msg, "ATENCIÓN");
                    dgvPrestamos.DataSource = null;
                    dgvPrestamos.Rows.Clear();
                    return;
                }

                dgvPrestamos.DataSource = (from prest in prestamosLector
                                           select new { prest.IdLibro,prest.Libro.Titulo, prest.Lectores.Nombre, prest.FechaPrestado, prest.FechaDevolucion }).ToList();
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
