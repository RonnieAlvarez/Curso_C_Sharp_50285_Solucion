namespace _10_SQL_formulario.formularios
{
    partial class frmConsultaXId
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
            btnClose = new Button();
            panel1 = new Panel();
            btnBorrarUsuarioxID = new Button();
            btnActualizaUsuarioxID = new Button();
            lblTituloUsuarioxID = new Label();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(362, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 36);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBorrarUsuarioxID);
            panel1.Controls.Add(btnActualizaUsuarioxID);
            panel1.Controls.Add(lblTituloUsuarioxID);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtID);
            panel1.Location = new Point(33, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 290);
            panel1.TabIndex = 10;
            // 
            // btnBorrarUsuarioxID
            // 
            btnBorrarUsuarioxID.Location = new Point(192, 242);
            btnBorrarUsuarioxID.Name = "btnBorrarUsuarioxID";
            btnBorrarUsuarioxID.Size = new Size(102, 23);
            btnBorrarUsuarioxID.TabIndex = 2;
            btnBorrarUsuarioxID.Text = "Borrar Usuario";
            btnBorrarUsuarioxID.UseVisualStyleBackColor = true;
            btnBorrarUsuarioxID.Click += btnBorrarUsuarioxID_Click;
            // 
            // btnActualizaUsuarioxID
            // 
            btnActualizaUsuarioxID.Location = new Point(49, 242);
            btnActualizaUsuarioxID.Name = "btnActualizaUsuarioxID";
            btnActualizaUsuarioxID.Size = new Size(123, 23);
            btnActualizaUsuarioxID.TabIndex = 2;
            btnActualizaUsuarioxID.Text = "Actualizar Usuario";
            btnActualizaUsuarioxID.UseVisualStyleBackColor = true;
            btnActualizaUsuarioxID.Click += btnActualizaUsuarioxID_Click;
            // 
            // lblTituloUsuarioxID
            // 
            lblTituloUsuarioxID.AutoSize = true;
            lblTituloUsuarioxID.Location = new Point(95, 12);
            lblTituloUsuarioxID.Name = "lblTituloUsuarioxID";
            lblTituloUsuarioxID.Size = new Size(158, 15);
            lblTituloUsuarioxID.TabIndex = 1;
            lblTituloUsuarioxID.Text = "INFORMACION DE USUARIO";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(49, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "eMail";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(49, 163);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(245, 23);
            txtContrasena.TabIndex = 0;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(49, 134);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre Usuario";
            txtNombreUsuario.Size = new Size(245, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(49, 105);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(245, 23);
            txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(119, 47);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Id";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // frmConsultaXId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultaXId";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta x ID";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Panel panel1;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblTituloUsuarioxID;
        private Button btnActualizaUsuarioxID;
        private Button btnBorrarUsuarioxID;
    }
}