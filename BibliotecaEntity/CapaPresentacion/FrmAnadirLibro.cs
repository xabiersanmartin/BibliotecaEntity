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
    public partial class FrmAnadirLibro : Form
    {
        List<Categoria> anadirCategorias = new List<Categoria>();
        List<Autor> anadirAutores = new List<Autor>();
        string caratula = "";
        public FrmAnadirLibro()
        {
            InitializeComponent();
        }

        private void FrmAnadirLibro_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = Program.acceso.DevolverCategorias();

            cboCategorias.Items.Clear();
            cboCategorias.Items.AddRange(categorias.ToArray());
            cboCategorias.DisplayMember = "Descripcion";

            List<Autor> autores = Program.acceso.DevolverAutores();
            cboAutores.Items.Clear();
            cboAutores.Items.AddRange(autores.ToArray());
            cboAutores.DisplayMember = "Descripcion";
        }

        private void btnAnadirLibro_Click(object sender, EventArgs e)
        {
            if (anadirAutores.Count == 0)
            {
                MessageBox.Show("Debes añadir minimo un autor para poder añadir este libro","ATENCIÓN");
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
            Close();
        }

        private void btnSeleccionarCaratula_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif| Png Image|*.png"; //Filtro para evitar que seleccionen cualquier cosa del ordenador.
            saveFileDialog1.Title = "Selecciona la caratula";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                pctCaratula.ImageLocation = saveFileDialog1.FileName;
                pctCaratula.SizeMode = PictureBoxSizeMode.StretchImage;
                caratula = saveFileDialog1.FileName;
            }
        }
    }
}
