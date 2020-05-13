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
            ((System.ComponentModel.ISupportInitialize)(this.pctCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(305, 114);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(135, 22);
            this.txtIsbn.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(305, 174);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(325, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(305, 233);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(253, 22);
            this.txtEditorial.TabIndex = 2;
            // 
            // txtSipnosis
            // 
            this.txtSipnosis.Location = new System.Drawing.Point(305, 284);
            this.txtSipnosis.Multiline = true;
            this.txtSipnosis.Name = "txtSipnosis";
            this.txtSipnosis.Size = new System.Drawing.Size(311, 106);
            this.txtSipnosis.TabIndex = 3;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(305, 492);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 22);
            this.txtUnidades.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Isbn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sipnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Caratula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unidades";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "Añadir nuevo libro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Autores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Categorias";
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(305, 552);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(169, 24);
            this.cboCategorias.TabIndex = 15;
            this.cboCategorias.SelectedIndexChanged += new System.EventHandler(this.cboCategorias_SelectedIndexChanged);
            // 
            // cboAutores
            // 
            this.cboAutores.FormattingEnabled = true;
            this.cboAutores.Location = new System.Drawing.Point(305, 613);
            this.cboAutores.Name = "cboAutores";
            this.cboAutores.Size = new System.Drawing.Size(169, 24);
            this.cboAutores.TabIndex = 16;
            this.cboAutores.SelectedIndexChanged += new System.EventHandler(this.cboAutores_SelectedIndexChanged);
            // 
            // btnSeleccionarCaratula
            // 
            this.btnSeleccionarCaratula.Location = new System.Drawing.Point(305, 408);
            this.btnSeleccionarCaratula.Name = "btnSeleccionarCaratula";
            this.btnSeleccionarCaratula.Size = new System.Drawing.Size(135, 46);
            this.btnSeleccionarCaratula.TabIndex = 17;
            this.btnSeleccionarCaratula.Text = "Seleccionar Caratula";
            this.btnSeleccionarCaratula.UseVisualStyleBackColor = true;
            this.btnSeleccionarCaratula.Click += new System.EventHandler(this.btnSeleccionarCaratula_Click);
            // 
            // pctCaratula
            // 
            this.pctCaratula.Location = new System.Drawing.Point(773, 114);
            this.pctCaratula.Name = "pctCaratula";
            this.pctCaratula.Size = new System.Drawing.Size(421, 289);
            this.pctCaratula.TabIndex = 18;
            this.pctCaratula.TabStop = false;
            // 
            // btnAnadirLibro
            // 
            this.btnAnadirLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirLibro.Location = new System.Drawing.Point(634, 716);
            this.btnAnadirLibro.Name = "btnAnadirLibro";
            this.btnAnadirLibro.Size = new System.Drawing.Size(135, 46);
            this.btnAnadirLibro.TabIndex = 19;
            this.btnAnadirLibro.Text = "Añadir Libro";
            this.btnAnadirLibro.UseVisualStyleBackColor = true;
            this.btnAnadirLibro.Click += new System.EventHandler(this.btnAnadirLibro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 899);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 46);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1537, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 41);
            this.label10.TabIndex = 21;
            this.label10.Text = "Añadir categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(1557, 291);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(246, 22);
            this.txtCategoria.TabIndex = 22;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(1557, 611);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(246, 22);
            this.txtAutor.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1550, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 41);
            this.label11.TabIndex = 23;
            this.label11.Text = "Añadir autor";
            // 
            // btnAnadirCategoria
            // 
            this.btnAnadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCategoria.Location = new System.Drawing.Point(1610, 360);
            this.btnAnadirCategoria.Name = "btnAnadirCategoria";
            this.btnAnadirCategoria.Size = new System.Drawing.Size(162, 51);
            this.btnAnadirCategoria.TabIndex = 25;
            this.btnAnadirCategoria.Text = "Añadir Categoria";
            this.btnAnadirCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAnadirAutor
            // 
            this.btnAnadirAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirAutor.Location = new System.Drawing.Point(1610, 696);
            this.btnAnadirAutor.Name = "btnAnadirAutor";
            this.btnAnadirAutor.Size = new System.Drawing.Size(162, 45);
            this.btnAnadirAutor.TabIndex = 26;
            this.btnAnadirAutor.Text = "Añadir Autor";
            this.btnAnadirAutor.UseVisualStyleBackColor = true;
            // 
            // FrmAnadirLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 957);
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
    }
}