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
    public partial class FrmConsultarLibroNoDevueltos : Form
    {
        public FrmConsultarLibroNoDevueltos()
        {
            InitializeComponent();
        }

        private void FrmConsultarLibroNoDevueltos_Load(object sender, EventArgs e)
        {
            List<Libro> listLibros = Program.acceso.DevolverLibros(out string msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                return;
            }

            dgvLibrosNoDevueltos.DataSource = (from lib in listLibros
                                               from prest in lib.Prestamos
                                               where prest.FechaDevolucion < DateTime.Today
                                               orderby lib.Titulo
                                               select new {lib.Isbn, lib.Titulo, prest.Lectores.Nombre, prest.Lectores.Telefono, prest.Lectores.Mail}).ToList();

            dgvLibrosNoDevueltos.Columns[2].HeaderText = "Socio";
            dgvLibrosNoDevueltos.Columns[3].HeaderText = "Teléfono Socio";
            dgvLibrosNoDevueltos.Columns[4].HeaderText = "Correo Electrónico Socio";
            dgvLibrosNoDevueltos.Columns[1].Width = 250;
            dgvLibrosNoDevueltos.Columns[3].Width = 120;
            dgvLibrosNoDevueltos.Columns[4].Width = 200;
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
