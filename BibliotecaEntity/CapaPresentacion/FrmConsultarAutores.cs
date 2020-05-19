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
    public partial class FrmConsultarAutores : Form
    {
        public FrmConsultarAutores()
        {
            InitializeComponent();
        }

        private void txtNombreAutor_TextChanged(object sender, EventArgs e)
        {
            //Borramos los registros que se hayan podido almacenar en el datagridview y del label, ya que va hacer una nueva busqueda.
            dgvLibrosAutor.DataSource = null;
            dgvLibrosAutor.Rows.Clear();
            lblNombreAutor.Text = "";
            if (!String.IsNullOrEmpty(txtNombreAutor.Text))
            {
                List<Libro> librosAutor = Program.acceso.BuscarLibros(txtNombreAutor.Text);

                if (librosAutor.Count == 0)
                {
                    return;
                }
                else
                {
                    dgvAutoresLibro.DataSource = (from lib in librosAutor
                                                 from aut in lib.Autores
                                                 select new { aut.IdAutor, Autores = aut.Descripcion}).ToList();
                    dgvAutoresLibro.Columns[0].Visible = false;
                }
            }
            else
            {
                dgvAutoresLibro.DataSource = null;
                dgvAutoresLibro.Rows.Clear();
            }
        }

        private void dgvLibrosAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idAutor = int.Parse(dgvAutoresLibro.CurrentRow.Cells[0].Value.ToString());
            string nombreAutor = dgvAutoresLibro.CurrentRow.Cells[1].Value.ToString();

            List<Libro> librosDeAutor = Program.acceso.DevolverLibrosAutor(idAutor, out string msg);

            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }

            lblNombreAutor.Text = nombreAutor;
            dgvLibrosAutor.DataSource = (from lib in librosDeAutor
                                         select new { lib.Isbn, lib.Titulo }).ToList();
            dgvLibrosAutor.Columns[0].Width = 80;
            dgvLibrosAutor.Columns[1].Width = 310;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
