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
    public partial class FrmAnadirLibro : Form
    {
        string rutaCaratulas = Path.GetDirectoryName(Application.ExecutablePath) + @"\Caratulas\";
        string nombreImagen;
        string rutaImagen;
        bool controlImagen = false;
        List<Categoria> anadirCategorias = new List<Categoria>();
        List<Autor> anadirAutores = new List<Autor>();
        string caratula = "";
        public FrmAnadirLibro()
        {
            InitializeComponent();
        }

        private void FrmAnadirLibro_Load(object sender, EventArgs e)
        {
            //Empiezan en false puesto que se pondran visibles dependiendo del focus del combobox de categórias
            lstCategorias.Visible = false;
            lblCategoriaSeleccionada.Visible = false;
            lblEliminarCategoria.Visible = false;

            List<Categoria> categorias = Program.acceso.DevolverCategorias(out string msg);
            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                return;
            }
            cboCategorias.Items.Clear();
            cboCategorias.Items.AddRange(categorias.ToArray());
            cboCategorias.DisplayMember = "Descripcion";

            List<Autor> autores = Program.acceso.DevolverAutores(out string msg2);
            if (msg2 != "")
            {
                MessageBox.Show(msg2, "ATENCIÓN");
                return;
            }
            cboAutores.Items.Clear();
            cboAutores.Items.AddRange(autores.ToArray());
            cboAutores.DisplayMember = "Descripcion";
        }

        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            if (anadirAutores.Count == 0)
            {
                MessageBox.Show("Debes añadir minimo un autor para poder añadir este libro", "ATENCIÓN");
                return;
            }
            if (anadirCategorias.Count == 0)
            {
                MessageBox.Show("Debes añadir minimo una categoría para poder añadir este libro", "ATENCIÓN");
                return;
            }
            string mensaje = Program.acceso.AnadirLibro(txtIsbn.Text, txtTitulo.Text, txtEditorial.Text, txtSipnosis.Text, txtUnidades.Text, caratula, anadirCategorias, anadirAutores);
            MessageBox.Show(mensaje);

            switch (mensaje)
            {
                case "Este isbn ya pertenece a un libro":
                    txtIsbn.Text = "";
                    break;

                case "El isbn no puede ser 0, ni tampoco un número negativo":
                    txtIsbn.Text = "";
                    break;

                case "Las unidades del libro no pueden ser 0 ni menores de 0":
                    txtUnidades.Text = "";
                    break;

                case "Formato de isbn incorrecto, debe ser númerico":
                    txtIsbn.Text = "";
                    break;

                case "Formato de unidades incorrecto, debe ser númerico":
                    txtUnidades.Text = "";
                    break;
                case "Libro añadido correctamente":
                    txtIsbn.Text = "";
                    txtEditorial.Text = "";
                    txtSipnosis.Text = "";
                    txtUnidades.Text = "";
                    txtTitulo.Text = "";
                    pctCaratula.Image.Dispose();
                    pctCaratula.Image = null;
                    cboAutores.SelectedIndex = -1;
                    cboCategorias.SelectedIndex = -1;
                    anadirAutores.Clear();
                    anadirCategorias.Clear();
                    nombreImagen = "";
                    rutaImagen = "";
                    controlImagen = true;
                    break;
                default:
                    break;
            }
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategorias.SelectedIndex == -1)
            {
                return;
            }
            Categoria anadirCategoria = cboCategorias.SelectedItem as Categoria;
            if (anadirCategorias.Contains(anadirCategoria))
            {
                return;
            }
            anadirCategorias.Add(anadirCategoria);
            lstCategorias.Items.Clear();
            lstCategorias.Items.AddRange(anadirCategorias.ToArray());
            lstCategorias.DisplayMember = "Descripcion";
        }

        private void cboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAutores.SelectedIndex == -1)
            {
                return;
            }
            Autor anadirAutor = cboAutores.SelectedItem as Autor;
            if (anadirAutores.Contains(anadirAutor))
            {
                return;
            }
            anadirAutores.Add(anadirAutor);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (File.Exists(rutaCaratulas + nombreImagen) && controlImagen == false)
            {
                pctCaratula.Image.Dispose();
                pctCaratula.Image = null;
                File.Delete(rutaCaratulas + nombreImagen);
            }
            Close();
        }

        private void btnSeleccionarCaratula_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif| Png Image|*.png"; //Filtro para evitar que seleccionen cualquier cosa del ordenador.
            saveFileDialog1.Title = "Selecciona la carátula";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                nombreImagen = saveFileDialog1.SafeFileName;
                rutaImagen = saveFileDialog1.FileName;
                if (!File.Exists(rutaCaratulas + nombreImagen))
                {
                    File.Copy(rutaImagen, rutaCaratulas + nombreImagen);
                }
                else
                {
                    MessageBox.Show("La carátula seleccionada ya esta asignada a un libro", "ATENCIÓN");
                    return;
                }
                pctCaratula.Image = new Bitmap(rutaCaratulas + nombreImagen);
                pctCaratula.SizeMode = PictureBoxSizeMode.StretchImage;
                caratula = nombreImagen;
                controlImagen = false;
            }
        }

        private void btnAnadirCategoria_Click(object sender, EventArgs e)
        {
            string mensaje = Program.acceso.AnadirCategoria(txtCategoria.Text);
            MessageBox.Show(mensaje);
            txtCategoria.Text = "";

            List<Categoria> categoriasNuevas = Program.acceso.DevolverCategorias(out string msg);
            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                return;
            }
            cboCategorias.Items.Clear();
            cboCategorias.Items.AddRange(categoriasNuevas.ToArray());
            cboCategorias.DisplayMember = "Descripcion";
        }

        private void btnAnadirAutor_Click(object sender, EventArgs e)
        {
            string mensaje = Program.acceso.AnadirAutor(txtAutor.Text);
            MessageBox.Show(mensaje);
            txtAutor.Text = "";

            List<Autor> autoresNuevos = Program.acceso.DevolverAutores(out string msg);
            if (msg != "")
            {
                MessageBox.Show(msg, "ATENCIÓN");
                return;
            }
            cboAutores.Items.Clear();
            cboAutores.Items.AddRange(autoresNuevos.ToArray());
            cboAutores.DisplayMember = "Descripcion";
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cboCategorias_Enter(object sender, EventArgs e)
        {
            lstCategorias.Visible = true;
            lblCategoriaSeleccionada.Visible = true;
            lblEliminarCategoria.Visible = true;
        }

        private void cboCategorias_Leave(object sender, EventArgs e)
        {
            if (lstCategorias.Focused)
            {
                lstCategorias.Visible = true;
                lblCategoriaSeleccionada.Visible = true;
                lblEliminarCategoria.Visible = true;
            }
            else
            {
                lstCategorias.Visible = false;
                lblCategoriaSeleccionada.Visible = false;
                lblEliminarCategoria.Visible = false;
            }
             
        }

        private void lstCategorias_DoubleClick(object sender, EventArgs e)
        {
            Categoria categoria = lstCategorias.SelectedItem as Categoria;
            anadirCategorias.Remove(categoria);

            if (anadirCategorias.Count != 0)
            {
                lstCategorias.Items.Clear();
                lstCategorias.Items.AddRange(anadirCategorias.ToArray());
                lstCategorias.DisplayMember = "Descripcion";
            }
            else
            {
                lstCategorias.Items.Clear();
                cboCategorias.SelectedIndex = -1;
            }
        }

        private void lstCategorias_Leave(object sender, EventArgs e)
        {
            lstCategorias.Visible = false;
            lblCategoriaSeleccionada.Visible = false;
            lblEliminarCategoria.Visible = false;
        }
    }
}
