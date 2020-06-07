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
    public partial class FrmPrestarLibro : Form
    {
        public FrmPrestarLibro()
        {
            InitializeComponent();
        }

        private void FrmPrestarLibro_Load(object sender, EventArgs e)
        {
            lblSocioNoValido.Visible = false;
            MostrarControles(false);
            txtContrasenaLector.PasswordChar = '*';
            rbtTitulo.Checked = true;
            btnBuscar.Visible = false;
        }

        private void txtNombreLibro_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombreLibro.Text) && rbtTitulo.Checked == true)
            {

                List<Libro> librosBuscados = Program.acceso.BuscarLibros(txtNombreLibro.Text);



                if (librosBuscados.Count == 0)
                {
                    return;
                }
                else
                {
                    dgvLibro.DataSource = (from lib in librosBuscados
                                           select new { Isbn = lib.Isbn, lib.Titulo, lib.Editorial, lib.Sipnosis, disponibles = (lib.Unidades - lib.Prestamos.Count) }).ToList();
                    EstablecerAnchoColumnas();
                }
            }
            else
            {
                dgvLibro.DataSource = null;
                dgvLibro.Rows.Clear();
            }
        }

        private void EstablecerAnchoColumnas()
        {
            dgvLibro.Columns[0].Width = 80;
            dgvLibro.Columns[1].Width = 150;
            dgvLibro.Columns[2].Width = 150;
            dgvLibro.Columns[3].Width = 400;
            dgvLibro.Columns[4].Width = 80;
        }

        private void MostrarControles(bool mostrar)
        {
            lblNumeroCarnet.Visible = lblNombre.Visible = lblContrasena.Visible = lblTelefono.Visible = lblMail.Visible = txtNumeroCarnetNuevo.Visible = txtNombreLector.Visible = txtContrasenaLector.Visible = txtTelefonoLector.Visible = txtMailLector.Visible = btnAnadirLector.Visible = chkPass.Visible = mostrar;
        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            txtNombreLibro.Text = "";
            string msg = "";
            List<Libro> libros = Program.acceso.DevolverLibros(out msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCION");
                return;
            }

            dgvLibro.DataSource = (from lib in libros
                                   select new { lib.Isbn, lib.Titulo, lib.Editorial, lib.Sipnosis, lib.Unidades }).ToList();
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            if (txtNumeroCarnet.Text == "")
            {
                MessageBox.Show("No puedes dejar el Número de socio vacio", "ATENCIÓN");
                return;
            }

            int ComprobarNumeroCarnet;
            if (!int.TryParse(txtNumeroCarnet.Text, out ComprobarNumeroCarnet))
            {
                MessageBox.Show("El número de carnet debe ser númerico", "ATENCION");
                txtNumeroCarnet.Text = "";
                return;
            }

            bool esSocio = Program.acceso.ComprobarNumeroCarnet(ComprobarNumeroCarnet);

            if (esSocio == false)
            {
                lblSocioNoValido.Visible = true;
                DialogResult result = MessageBox.Show("No existe este socio, ¿Quieres dar de alta un nuevo socio?", "ATENCIÓN", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvLibro.Visible = false;
                    btnPrestarLibro.Visible = false;
                    btnMostrarLibros.Visible = false;
                    txtNombreLibro.Enabled = false;
                    txtNumeroCarnet.Enabled = false;
                    MostrarControles(true);
                    txtNumeroCarnetNuevo.Text = txtNumeroCarnet.Text;
                }
                else
                {
                    lblSocioNoValido.Visible = false;
                    txtNumeroCarnet.Text = "";
                    return;
                }
            }
            else
            {
                if (dgvLibro.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debes elegir en el recuadro que libro quieres prestar", "ATENCIÓN");
                    return;
                }
                int isbnSeleccionado = int.Parse(dgvLibro.SelectedRows[0].Cells[0].Value.ToString());

                string mensaje = Program.acceso.AnadirPrestamo(isbnSeleccionado, int.Parse(txtNumeroCarnet.Text));

                MessageBox.Show(mensaje);
                txtNombreLibro.Text = "";
            }
        }

        private void btnAnadirLector_Click(object sender, EventArgs e)
        {
            string mensaje = Program.acceso.AnadirLector(txtNumeroCarnetNuevo.Text, txtNombreLector.Text, txtContrasenaLector.Text, txtTelefonoLector.Text, txtMailLector.Text);
            MessageBox.Show(mensaje);

            if (mensaje == "Socio añadido correctamente")
            {
                lblSocioNoValido.Visible = false;
                MostrarControles(false);
                dgvLibro.Visible = true;
                btnPrestarLibro.Visible = true;
                btnMostrarLibros.Visible = true;
                txtNombreLibro.Enabled = true;
                txtNumeroCarnet.Enabled = true;
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtContrasenaLector.PasswordChar = '\0';
            }
            else
            {
                txtContrasenaLector.PasswordChar = '*';
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumeroCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void rbtIsbn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtIsbn.Checked == true)
            {
                btnBuscar.Visible = true;
            }
            else
            {
                btnBuscar.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombreLibro.Text) && rbtIsbn.Checked)
            {
                if (int.TryParse(txtNombreLibro.Text,out int isbn))
                {
                    Libro libroBuscado = Program.acceso.LibroIsbn(isbn, out string msg);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "ATENCIÓN");
                        return;
                    }
                    else
                    {
                        List<Libro> listaParaDGV = new List<Libro> { libroBuscado };
                        dgvLibro.DataSource = (from lib in listaParaDGV
                                              select new { lib.Isbn, lib.Titulo, lib.Editorial, lib.Sipnosis, disponibles = lib.Unidades - lib.Prestamos.Count }).ToList(); // TODO Error de ejecución si el lib no tiene Prestamos
                        EstablecerAnchoColumnas();
                    }
                }
                else
                {
                    MessageBox.Show("El isbn debe ser numérico", "ATENCIÓN");
                    txtNombreLibro.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("El recuadro de la busqueda por isbn no puede estar vacío", "ATENCIÓN");
                return;
            }
        }
    }
}
