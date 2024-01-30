namespace _10_SQL_formulario.formularios
{
    partial class frmUsuarios
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
            panel1 = new Panel();
            btnBorrarUsuarioxID = new Button();
            panel4 = new Panel();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            btnActualizaUsuarioxID = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnBuscarUsuarioXiD = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnBorrarUsuarioxID);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnActualizaUsuarioxID);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnBuscarUsuarioXiD);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 550);
            panel1.TabIndex = 0;
            // 
            // btnBorrarUsuarioxID
            // 
            btnBorrarUsuarioxID.Location = new Point(350, 274);
            btnBorrarUsuarioxID.Name = "btnBorrarUsuarioxID";
            btnBorrarUsuarioxID.Size = new Size(102, 23);
            btnBorrarUsuarioxID.TabIndex = 2;
            btnBorrarUsuarioxID.Text = "Borrar Usuario";
            btnBorrarUsuarioxID.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtContrasena);
            panel4.Controls.Add(txtNombreUsuario);
            panel4.Controls.Add(txtApellido);
            panel4.Controls.Add(txtNombre);
            panel4.Controls.Add(txtID);
            panel4.Location = new Point(24, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 174);
            panel4.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "eMail";
            txtEmail.Size = new Size(291, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(326, 90);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(245, 23);
            txtContrasena.TabIndex = 0;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(48, 90);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre Usuario";
            txtNombreUsuario.Size = new Size(245, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(326, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(245, 23);
            txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(48, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(258, 14);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Id";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // btnActualizaUsuarioxID
            // 
            btnActualizaUsuarioxID.Location = new Point(183, 272);
            btnActualizaUsuarioxID.Name = "btnActualizaUsuarioxID";
            btnActualizaUsuarioxID.Size = new Size(123, 23);
            btnActualizaUsuarioxID.TabIndex = 2;
            btnActualizaUsuarioxID.Text = "Actualizar Usuario";
            btnActualizaUsuarioxID.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(24, 301);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 235);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(650, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
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
            btnClose.Location = new Point(659, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 36);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnBuscarUsuarioXiD
            // 
            btnBuscarUsuarioXiD.BackColor = Color.FromArgb(0, 192, 192);
            btnBuscarUsuarioXiD.CausesValidation = false;
            btnBuscarUsuarioXiD.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuarioXiD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsuarioXiD.ForeColor = SystemColors.ControlLightLight;
            btnBuscarUsuarioXiD.Location = new Point(24, 260);
            btnBuscarUsuarioXiD.Name = "btnBuscarUsuarioXiD";
            btnBuscarUsuarioXiD.Size = new Size(121, 35);
            btnBuscarUsuarioXiD.TabIndex = 7;
            btnBuscarUsuarioXiD.Text = "Buscar X ID";
            btnBuscarUsuarioXiD.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.Location = new Point(298, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "USUARIOS";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 550);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 324);
            label2.Name = "label2";
            label2.Size = new Size(95, 16);
            label2.TabIndex = 1;
            label2.Text = "Ronnie Alvarez";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 309);
            label1.Name = "label1";
            label1.Size = new Size(108, 16);
            label1.TabIndex = 1;
            label1.Text = "Desarrollado por:";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(81, 170);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(156, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Inventarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.service_provider_icon;
            pictureBox1.Location = new Point(69, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button btnBorrarUsuarioxID;
        private Button btnActualizaUsuarioxID;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private Button btnBuscarUsuarioXiD;
    }

     
}