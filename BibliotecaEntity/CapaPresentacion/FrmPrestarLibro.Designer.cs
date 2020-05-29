namespace CapaPresentacion
{
    partial class FrmPrestarLibro
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
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.txtNumeroCarnet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.lblSocioNoValido = new System.Windows.Forms.Label();
            this.btnMostrarLibros = new System.Windows.Forms.Button();
            this.lblNumeroCarnet = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtNumeroCarnetNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreLector = new System.Windows.Forms.TextBox();
            this.txtContrasenaLector = new System.Windows.Forms.TextBox();
            this.txtTelefonoLector = new System.Windows.Forms.TextBox();
            this.txtMailLector = new System.Windows.Forms.TextBox();
            this.btnAnadirLector = new System.Windows.Forms.Button();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rbtIsbn = new System.Windows.Forms.RadioButton();
            this.rbtTitulo = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe el título/isbn del libro";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(197, 116);
            this.txtNombreLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(216, 20);
            this.txtNombreLibro.TabIndex = 1;
            this.txtNombreLibro.TextChanged += new System.EventHandler(this.txtNombreLibro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prestar un libro";
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.Location = new System.Drawing.Point(455, 509);
            this.btnPrestarLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(110, 36);
            this.btnPrestarLibro.TabIndex = 3;
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.UseVisualStyleBackColor = true;
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // txtNumeroCarnet
            // 
            this.txtNumeroCarnet.Location = new System.Drawing.Point(710, 121);
            this.txtNumeroCarnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroCarnet.Name = "txtNumeroCarnet";
            this.txtNumeroCarnet.Size = new System.Drawing.Size(206, 20);
            this.txtNumeroCarnet.TabIndex = 4;
            this.txtNumeroCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCarnet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Carnet";
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(137, 184);
            this.dgvLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.RowHeadersWidth = 51;
            this.dgvLibro.RowTemplate.Height = 24;
            this.dgvLibro.Size = new System.Drawing.Size(922, 292);
            this.dgvLibro.TabIndex = 6;
            // 
            // lblSocioNoValido
            // 
            this.lblSocioNoValido.AutoSize = true;
            this.lblSocioNoValido.ForeColor = System.Drawing.Color.Red;
            this.lblSocioNoValido.Location = new System.Drawing.Point(627, 153);
            this.lblSocioNoValido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSocioNoValido.Name = "lblSocioNoValido";
            this.lblSocioNoValido.Size = new System.Drawing.Size(287, 13);
            this.lblSocioNoValido.TabIndex = 7;
            this.lblSocioNoValido.Text = "El socio asociado al número de carnet no está dado de alta";
            // 
            // btnMostrarLibros
            // 
            this.btnMostrarLibros.Location = new System.Drawing.Point(29, 184);
            this.btnMostrarLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarLibros.Name = "btnMostrarLibros";
            this.btnMostrarLibros.Size = new System.Drawing.Size(94, 32);
            this.btnMostrarLibros.TabIndex = 8;
            this.btnMostrarLibros.Text = "Mostrar Libros";
            this.btnMostrarLibros.UseVisualStyleBackColor = true;
            this.btnMostrarLibros.Click += new System.EventHandler(this.btnMostrarLibros_Click);
            // 
            // lblNumeroCarnet
            // 
            this.lblNumeroCarnet.AutoSize = true;
            this.lblNumeroCarnet.Location = new System.Drawing.Point(350, 223);
            this.lblNumeroCarnet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroCarnet.Name = "lblNumeroCarnet";
            this.lblNumeroCarnet.Size = new System.Drawing.Size(78, 13);
            this.lblNumeroCarnet.TabIndex = 9;
            this.lblNumeroCarnet.Text = "Número Carnet";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(350, 258);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(350, 295);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 11;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(350, 326);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(350, 362);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail";
            // 
            // txtNumeroCarnetNuevo
            // 
            this.txtNumeroCarnetNuevo.Location = new System.Drawing.Point(518, 223);
            this.txtNumeroCarnetNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroCarnetNuevo.Name = "txtNumeroCarnetNuevo";
            this.txtNumeroCarnetNuevo.Size = new System.Drawing.Size(174, 20);
            this.txtNumeroCarnetNuevo.TabIndex = 14;
            // 
            // txtNombreLector
            // 
            this.txtNombreLector.Location = new System.Drawing.Point(518, 258);
            this.txtNombreLector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreLector.Name = "txtNombreLector";
            this.txtNombreLector.Size = new System.Drawing.Size(174, 20);
            this.txtNombreLector.TabIndex = 15;
            // 
            // txtContrasenaLector
            // 
            this.txtContrasenaLector.Location = new System.Drawing.Point(518, 291);
            this.txtContrasenaLector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasenaLector.Name = "txtContrasenaLector";
            this.txtContrasenaLector.Size = new System.Drawing.Size(174, 20);
            this.txtContrasenaLector.TabIndex = 16;
            // 
            // txtTelefonoLector
            // 
            this.txtTelefonoLector.Location = new System.Drawing.Point(518, 326);
            this.txtTelefonoLector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoLector.Name = "txtTelefonoLector";
            this.txtTelefonoLector.Size = new System.Drawing.Size(174, 20);
            this.txtTelefonoLector.TabIndex = 17;
            // 
            // txtMailLector
            // 
            this.txtMailLector.Location = new System.Drawing.Point(518, 358);
            this.txtMailLector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMailLector.Name = "txtMailLector";
            this.txtMailLector.Size = new System.Drawing.Size(174, 20);
            this.txtMailLector.TabIndex = 18;
            // 
            // btnAnadirLector
            // 
            this.btnAnadirLector.Location = new System.Drawing.Point(455, 427);
            this.btnAnadirLector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirLector.Name = "btnAnadirLector";
            this.btnAnadirLector.Size = new System.Drawing.Size(110, 36);
            this.btnAnadirLector.TabIndex = 19;
            this.btnAnadirLector.Text = "Añadir Socio";
            this.btnAnadirLector.UseVisualStyleBackColor = true;
            this.btnAnadirLector.Click += new System.EventHandler(this.btnAnadirLector_Click);
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.Location = new System.Drawing.Point(710, 291);
            this.chkPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(154, 17);
            this.chkPass.TabIndex = 20;
            this.chkPass.Text = "Mostrar/ocultar contraseña";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(9, 600);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 33);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rbtIsbn
            // 
            this.rbtIsbn.AutoSize = true;
            this.rbtIsbn.Location = new System.Drawing.Point(230, 148);
            this.rbtIsbn.Name = "rbtIsbn";
            this.rbtIsbn.Size = new System.Drawing.Size(45, 17);
            this.rbtIsbn.TabIndex = 22;
            this.rbtIsbn.TabStop = true;
            this.rbtIsbn.Text = "Isbn";
            this.rbtIsbn.UseVisualStyleBackColor = true;
            this.rbtIsbn.CheckedChanged += new System.EventHandler(this.rbtIsbn_CheckedChanged);
            // 
            // rbtTitulo
            // 
            this.rbtTitulo.AutoSize = true;
            this.rbtTitulo.Location = new System.Drawing.Point(309, 148);
            this.rbtTitulo.Name = "rbtTitulo";
            this.rbtTitulo.Size = new System.Drawing.Size(53, 17);
            this.rbtTitulo.TabIndex = 23;
            this.rbtTitulo.TabStop = true;
            this.rbtTitulo.Text = "Título";
            this.rbtTitulo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(419, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmPrestarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 652);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbtTitulo);
            this.Controls.Add(this.rbtIsbn);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.btnAnadirLector);
            this.Controls.Add(this.txtMailLector);
            this.Controls.Add(this.txtTelefonoLector);
            this.Controls.Add(this.txtContrasenaLector);
            this.Controls.Add(this.txtNombreLector);
            this.Controls.Add(this.txtNumeroCarnetNuevo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumeroCarnet);
            this.Controls.Add(this.btnMostrarLibros);
            this.Controls.Add(this.lblSocioNoValido);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroCarnet);
            this.Controls.Add(this.btnPrestarLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrestarLibro";
            this.Text = "Prestar un libro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrestarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.TextBox txtNumeroCarnet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.Label lblSocioNoValido;
        private System.Windows.Forms.Button btnMostrarLibros;
        private System.Windows.Forms.Label lblNumeroCarnet;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNumeroCarnetNuevo;
        private System.Windows.Forms.TextBox txtNombreLector;
        private System.Windows.Forms.TextBox txtContrasenaLector;
        private System.Windows.Forms.TextBox txtTelefonoLector;
        private System.Windows.Forms.TextBox txtMailLector;
        private System.Windows.Forms.Button btnAnadirLector;
        private System.Windows.Forms.CheckBox chkPass;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RadioButton rbtIsbn;
        private System.Windows.Forms.RadioButton rbtTitulo;
        private System.Windows.Forms.Button btnBuscar;
    }
}