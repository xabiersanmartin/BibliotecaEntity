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
    public partial class FrmConsultarCategorias : Form
    {
        public FrmConsultarCategorias()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = Program.acceso.DevolverCategorias(out string msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                return;
            }

            cboCategorias.Items.Clear();
            cboCategorias.Items.AddRange(categorias.ToArray());
            cboCategorias.DisplayMember = "Descripcion";
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategorias.SelectedIndex == -1)
            {
                return;
            }

            Categoria categoria = cboCategorias.SelectedItem as Categoria;

            if (categoria.Libros.Count == 0)
            {
                MessageBox.Show("Esta categoria("+categoria.Descripcion +") no tiene libros", "ATENCIÓN");
                cboCategorias.SelectedIndex = -1;
                cboCategorias.Text = "";
                dgvLibrosDeCategoria.DataSource = null;
                dgvLibrosDeCategoria.Rows.Clear();
                return;
            }

            if(categoria.Libros.All(lib => lib.Disponibilidad == false))
            {
                MessageBox.Show("Esta categoría, no tiene ningún libro disponible", "ATENCIÓN");
                cboCategorias.SelectedIndex = -1;
                cboCategorias.Text = "";
                dgvLibrosDeCategoria.DataSource = null;
                dgvLibrosDeCategoria.Rows.Clear();
                return;
            }
            
            dgvLibrosDeCategoria.DataSource = (from lib in categoria.Libros
                                               orderby lib.Titulo
                                               where lib.Disponibilidad == true
                                               select new
                                               {
                                                   lib.Isbn,
                                                   lib.Titulo,
                                                   categorias = string.Concat(lib.Categorias.Select(cat => cat.Descripcion + ", ")).Substring(0, string.Concat(lib.Categorias.Select(cat => cat.Descripcion + ", ")).Length - 2),
                                                   autores = string.Concat(lib.Autores.Select(aut=> aut.Descripcion + ", ")).Substring(0, string.Concat(lib.Autores.Select(aut=> aut.Descripcion + ", ")).Length -2)
                                               }).ToList();

            dgvLibrosDeCategoria.Columns[1].Width = 200;
            dgvLibrosDeCategoria.Columns[2].Width = 200;
            dgvLibrosDeCategoria.Columns[3].Width = 250;

            dgvLibrosDeCategoria.Columns[2].HeaderText = "Categorías de libro";
            dgvLibrosDeCategoria.Columns[3].HeaderText = "Autor/es de libro";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
