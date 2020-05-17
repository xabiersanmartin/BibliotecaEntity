namespace CapaPresentacion
{
    partial class FrmDevolucion
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCarnet = new System.Windows.Forms.TextBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnDevolverLibro = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarPrestamos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEVOLVER LIBRO";
            // 
            // txtNumeroCarnet
            // 
            this.txtNumeroCarnet.Location = new System.Drawing.Point(261, 138);
            this.txtNumeroCarnet.Name = "txtNumeroCarnet";
            this.txtNumeroCarnet.Size = new System.Drawing.Size(194, 22);
            this.txtNumeroCarnet.TabIndex = 2;
            this.txtNumeroCarnet.Click += new System.EventHandler(this.txtNumeroCarnet_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(100, 201);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(1049, 363);
            this.dgvPrestamos.TabIndex = 3;
            // 
            // btnDevolverLibro
            // 
            this.btnDevolverLibro.Location = new System.Drawing.Point(517, 593);
            this.btnDevolverLibro.Name = "btnDevolverLibro";
            this.btnDevolverLibro.Size = new System.Drawing.Size(136, 41);
            this.btnDevolverLibro.TabIndex = 4;
            this.btnDevolverLibro.Text = "Devolver Libro";
            this.btnDevolverLibro.UseVisualStyleBackColor = true;
            this.btnDevolverLibro.Click += new System.EventHandler(this.btnDevolverLibro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 705);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 41);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscarPrestamos
            // 
            this.btnBuscarPrestamos.Location = new System.Drawing.Point(503, 130);
            this.btnBuscarPrestamos.Name = "btnBuscarPrestamos";
            this.btnBuscarPrestamos.Size = new System.Drawing.Size(150, 37);
            this.btnBuscarPrestamos.TabIndex = 6;
            this.btnBuscarPrestamos.Text = "Buscar prestamos";
            this.btnBuscarPrestamos.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamos.Click += new System.EventHandler(this.btnBuscarPrestamos_Click);
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 757);
            this.Controls.Add(this.btnBuscarPrestamos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDevolverLibro);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.txtNumeroCarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmDevolucion";
            this.Text = "Devolver un libro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCarnet;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnDevolverLibro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscarPrestamos;
    }
}