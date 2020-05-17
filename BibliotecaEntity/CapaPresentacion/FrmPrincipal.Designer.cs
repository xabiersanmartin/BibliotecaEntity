namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENID@ A LA BIBLIOTECA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirLibroToolStripMenuItem,
            this.borrarLibroToolStripMenuItem,
            this.prestarLibroToolStripMenuItem,
            this.devolverLibroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirLibroToolStripMenuItem
            // 
            this.añadirLibroToolStripMenuItem.Name = "añadirLibroToolStripMenuItem";
            this.añadirLibroToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.añadirLibroToolStripMenuItem.Text = "Añadir Libro";
            this.añadirLibroToolStripMenuItem.Click += new System.EventHandler(this.añadirLibroToolStripMenuItem_Click);
            // 
            // borrarLibroToolStripMenuItem
            // 
            this.borrarLibroToolStripMenuItem.Name = "borrarLibroToolStripMenuItem";
            this.borrarLibroToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.borrarLibroToolStripMenuItem.Text = "Borrar Libro";
            this.borrarLibroToolStripMenuItem.Click += new System.EventHandler(this.borrarLibroToolStripMenuItem_Click);
            // 
            // prestarLibroToolStripMenuItem
            // 
            this.prestarLibroToolStripMenuItem.Name = "prestarLibroToolStripMenuItem";
            this.prestarLibroToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.prestarLibroToolStripMenuItem.Text = "Prestar Libro";
            this.prestarLibroToolStripMenuItem.Click += new System.EventHandler(this.prestarLibroToolStripMenuItem_Click);
            // 
            // devolverLibroToolStripMenuItem
            // 
            this.devolverLibroToolStripMenuItem.Name = "devolverLibroToolStripMenuItem";
            this.devolverLibroToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.devolverLibroToolStripMenuItem.Text = "Devolver Libro";
            this.devolverLibroToolStripMenuItem.Click += new System.EventHandler(this.devolverLibroToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Bienvenida";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverLibroToolStripMenuItem;
    }
}

