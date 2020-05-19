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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void añadirLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnadirLibro frm = new FrmAnadirLibro();
            frm.ShowDialog(this);
        }

        private void borrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrarLibro frm = new FrmBorrarLibro();
            frm.ShowDialog(this);
        }

        private void prestarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestarLibro frm = new FrmPrestarLibro();
            frm.ShowDialog(this);
        }

        private void devolverLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucion frm = new FrmDevolucion();
            frm.ShowDialog(this);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCategorias frm = new FrmConsultarCategorias();
            frm.ShowDialog(this);
        }

        private void consultaAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAutores frm = new FrmConsultarAutores();
            frm.ShowDialog(this);
        }

        private void consultaMorossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarLibroNoDevueltos frm = new FrmConsultarLibroNoDevueltos();
            frm.ShowDialog(this);
        }
    }
}
