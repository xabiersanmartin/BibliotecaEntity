﻿using System;
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
    }
}
