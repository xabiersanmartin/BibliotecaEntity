namespace CapaPresentacion
{
    partial class FrmConsultarAutores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.dgvAutoresLibro = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLibrosAutor = new System.Windows.Forms.DataGridView();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre libro";
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.Location = new System.Drawing.Point(201, 104);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(269, 22);
            this.txtNombreAutor.TabIndex = 1;
            this.txtNombreAutor.TextChanged += new System.EventHandler(this.txtNombreAutor_TextChanged);
            // 
            // dgvAutoresLibro
            // 
            this.dgvAutoresLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoresLibro.Location = new System.Drawing.Point(76, 170);
            this.dgvAutoresLibro.Name = "dgvAutoresLibro";
            this.dgvAutoresLibro.RowHeadersWidth = 51;
            this.dgvAutoresLibro.RowTemplate.Height = 24;
            this.dgvAutoresLibro.Size = new System.Drawing.Size(463, 373);
            this.dgvAutoresLibro.TabIndex = 2;
            this.dgvAutoresLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibrosAutor_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar autor/es por libro";
            // 
            // dgvLibrosAutor
            // 
            this.dgvLibrosAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosAutor.Location = new System.Drawing.Point(874, 170);
            this.dgvLibrosAutor.Name = "dgvLibrosAutor";
            this.dgvLibrosAutor.RowHeadersWidth = 51;
            this.dgvLibrosAutor.RowTemplate.Height = 24;
            this.dgvLibrosAutor.Size = new System.Drawing.Size(585, 373);
            this.dgvLibrosAutor.TabIndex = 4;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(922, 105);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(0, 17);
            this.lblNombreAutor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Libros de Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autor:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 635);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 45);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmConsultarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 692);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreAutor);
            this.Controls.Add(this.dgvLibrosAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAutoresLibro);
            this.Controls.Add(this.txtNombreAutor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmConsultarAutores";
            this.Text = "Consultar libros por autor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.DataGridView dgvAutoresLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLibrosAutor;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
    }
}