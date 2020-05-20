namespace CapaPresentacion
{
    partial class FrmAnadirLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtSipnosis = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.cboAutores = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarCaratula = new System.Windows.Forms.Button();
            this.pctCaratula = new System.Windows.Forms.PictureBox();
            this.btnAnadirLibro = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAnadirCategoria = new System.Windows.Forms.Button();
            this.btnAnadirAutor = new System.Windows.Forms.Button();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.lblCategoriaSeleccionada = new System.Windows.Forms.Label();
            this.lblEliminarCategoria = new System.Windows.Forms.Label();
            this.txtFiltrarAutor = new System.Windows.Forms.TextBox();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.lblAutoresSeleccionados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(229, 93);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(102, 20);
            this.txtIsbn.TabIndex = 0;
            this.txtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsbn_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(229, 141);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(245, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(229, 189);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(191, 20);
            this.txtEditorial.TabIndex = 2;
            // 
            // txtSipnosis
            // 
            this.txtSipnosis.Location = new System.Drawing.Point(229, 231);
            this.txtSipnosis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSipnosis.Multiline = true;
            this.txtSipnosis.Name = "txtSipnosis";
            this.txtSipnosis.Size = new System.Drawing.Size(234, 87);
            this.txtSipnosis.TabIndex = 3;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(229, 400);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(76, 20);
            this.txtUnidades.TabIndex = 5;
            this.txtUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidades_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Isbn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sipnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Carátula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 404);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unidades";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Añadir nuevo libro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 571);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Autores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 452);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Categorías";
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(229, 452);
            this.cboCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(128, 21);
            this.cboCategorias.TabIndex = 15;
            this.cboCategorias.SelectedIndexChanged += new System.EventHandler(this.cboCategorias_SelectedIndexChanged);
            this.cboCategorias.Enter += new System.EventHandler(this.cboCategorias_Enter);
            this.cboCategorias.Leave += new System.EventHandler(this.cboCategorias_Leave);
            // 
            // cboAutores
            // 
            this.cboAutores.FormattingEnabled = true;
            this.cboAutores.Location = new System.Drawing.Point(431, 566);
            this.cboAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboAutores.Name = "cboAutores";
            this.cboAutores.Size = new System.Drawing.Size(128, 21);
            this.cboAutores.TabIndex = 16;
            this.cboAutores.SelectedIndexChanged += new System.EventHandler(this.cboAutores_SelectedIndexChanged);
            this.cboAutores.Enter += new System.EventHandler(this.cboAutores_Enter);
            this.cboAutores.Leave += new System.EventHandler(this.cboAutores_Leave);
            // 
            // btnSeleccionarCaratula
            // 
            this.btnSeleccionarCaratula.Location = new System.Drawing.Point(229, 332);
            this.btnSeleccionarCaratula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionarCaratula.Name = "btnSeleccionarCaratula";
            this.btnSeleccionarCaratula.Size = new System.Drawing.Size(101, 37);
            this.btnSeleccionarCaratula.TabIndex = 17;
            this.btnSeleccionarCaratula.Text = "Seleccionar Carátula";
            this.btnSeleccionarCaratula.UseVisualStyleBackColor = true;
            this.btnSeleccionarCaratula.Click += new System.EventHandler(this.btnSeleccionarCaratula_Click);
            // 
            // pctCaratula
            // 
            this.pctCaratula.Location = new System.Drawing.Point(580, 93);
            this.pctCaratula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctCaratula.Name = "pctCaratula";
            this.pctCaratula.Size = new System.Drawing.Size(370, 276);
            this.pctCaratula.TabIndex = 18;
            this.pctCaratula.TabStop = false;
            // 
            // btnAnadirLibro
            // 
            this.btnAnadirLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirLibro.Location = new System.Drawing.Point(646, 668);
            this.btnAnadirLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirLibro.Name = "btnAnadirLibro";
            this.btnAnadirLibro.Size = new System.Drawing.Size(132, 56);
            this.btnAnadirLibro.TabIndex = 19;
            this.btnAnadirLibro.Text = "Añadir Libro";
            this.btnAnadirLibro.UseVisualStyleBackColor = true;
            this.btnAnadirLibro.Click += new System.EventHandler(this.btnAnadirLibro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(9, 756);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 37);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1153, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 33);
            this.label10.TabIndex = 21;
            this.label10.Text = "Añadir categoría";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(1168, 236);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(186, 20);
            this.txtCategoria.TabIndex = 22;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(1168, 496);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(186, 20);
            this.txtAutor.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1162, 429);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 33);
            this.label11.TabIndex = 23;
            this.label11.Text = "Añadir autor";
            // 
            // btnAnadirCategoria
            // 
            this.btnAnadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCategoria.Location = new System.Drawing.Point(1208, 292);
            this.btnAnadirCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirCategoria.Name = "btnAnadirCategoria";
            this.btnAnadirCategoria.Size = new System.Drawing.Size(122, 41);
            this.btnAnadirCategoria.TabIndex = 25;
            this.btnAnadirCategoria.Text = "Añadir Categoría";
            this.btnAnadirCategoria.UseVisualStyleBackColor = true;
            this.btnAnadirCategoria.Click += new System.EventHandler(this.btnAnadirCategoria_Click);
            // 
            // btnAnadirAutor
            // 
            this.btnAnadirAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAutor.Location = new System.Drawing.Point(1208, 547);
            this.btnAnadirAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirAutor.Name = "btnAnadirAutor";
            this.btnAnadirAutor.Size = new System.Drawing.Size(122, 41);
            this.btnAnadirAutor.TabIndex = 26;
            this.btnAnadirAutor.Text = "Añadir Autor";
            this.btnAnadirAutor.UseVisualStyleBackColor = true;
            this.btnAnadirAutor.Click += new System.EventHandler(this.btnAnadirAutor_Click);
            // 
            // lstCategorias
            // 
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.Location = new System.Drawing.Point(429, 436);
            this.lstCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(157, 95);
            this.lstCategorias.TabIndex = 27;
            this.lstCategorias.DoubleClick += new System.EventHandler(this.lstCategorias_DoubleClick);
            this.lstCategorias.Leave += new System.EventHandler(this.lstCategorias_Leave);
            // 
            // lblCategoriaSeleccionada
            // 
            this.lblCategoriaSeleccionada.AutoSize = true;
            this.lblCategoriaSeleccionada.Location = new System.Drawing.Point(429, 417);
            this.lblCategoriaSeleccionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaSeleccionada.Name = "lblCategoriaSeleccionada";
            this.lblCategoriaSeleccionada.Size = new System.Drawing.Size(132, 13);
            this.lblCategoriaSeleccionada.TabIndex = 28;
            this.lblCategoriaSeleccionada.Text = "Categorías Seleccionadas";
            // 
            // lblEliminarCategoria
            // 
            this.lblEliminarCategoria.AutoSize = true;
            this.lblEliminarCategoria.Location = new System.Drawing.Point(605, 474);
            this.lblEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminarCategoria.Name = "lblEliminarCategoria";
            this.lblEliminarCategoria.Size = new System.Drawing.Size(192, 13);
            this.lblEliminarCategoria.TabIndex = 29;
            this.lblEliminarCategoria.Text = "Doble click para eliminar una categoría";
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Location = new System.Drawing.Point(229, 567);
            this.txtFiltrarAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.Size = new System.Drawing.Size(138, 20);
            this.txtFiltrarAutor.TabIndex = 30;
            this.txtFiltrarAutor.Click += new System.EventHandler(this.txtFiltrarAutor_Click);
            this.txtFiltrarAutor.TextChanged += new System.EventHandler(this.txtFiltrarAutor_TextChanged);
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(642, 557);
            this.lstAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(150, 69);
            this.lstAutores.TabIndex = 31;
            this.lstAutores.DoubleClick += new System.EventHandler(this.lstAutores_DoubleClick);
            this.lstAutores.Leave += new System.EventHandler(this.lstAutores_Leave);
            // 
            // lblAutoresSeleccionados
            // 
            this.lblAutoresSeleccionados.AutoSize = true;
            this.lblAutoresSeleccionados.Location = new System.Drawing.Point(640, 539);
            this.lblAutoresSeleccionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutoresSeleccionados.Name = "lblAutoresSeleccionados";
            this.lblAutoresSeleccionados.Size = new System.Drawing.Size(116, 13);
            this.lblAutoresSeleccionados.TabIndex = 32;
            this.lblAutoresSeleccionados.Text = "Autores Seleccionados";
            // 
            // FrmAnadirLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 803);
            this.Controls.Add(this.lblAutoresSeleccionados);
            this.Controls.Add(this.lstAutores);
            this.Controls.Add(this.txtFiltrarAutor);
            this.Controls.Add(this.lblEliminarCategoria);
            this.Controls.Add(this.lblCategoriaSeleccionada);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.btnAnadirAutor);
            this.Controls.Add(this.btnAnadirCategoria);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnadirLibro);
            this.Controls.Add(this.pctCaratula);
            this.Controls.Add(this.btnSeleccionarCaratula);
            this.Controls.Add(this.cboAutores);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtSipnosis);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtIsbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAnadirLibro";
            this.Text = "Añadir Libro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnadirLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCaratula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtSipnosis;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.ComboBox cboAutores;
        private System.Windows.Forms.Button btnSeleccionarCaratula;
        private System.Windows.Forms.PictureBox pctCaratula;
        private System.Windows.Forms.Button btnAnadirLibro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAnadirCategoria;
        private System.Windows.Forms.Button btnAnadirAutor;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.Label lblCategoriaSeleccionada;
        private System.Windows.Forms.Label lblEliminarCategoria;
        private System.Windows.Forms.TextBox txtFiltrarAutor;
        private System.Windows.Forms.ListBox lstAutores;
        private System.Windows.Forms.Label lblAutoresSeleccionados;
    }
}