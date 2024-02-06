namespace _12_Entity_CRUD
{
    partial class AMBUsuario
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
            btnAceptar = new Button();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txtNombreUsuario = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 214);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(179, 63);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(12, 12);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Nombre";
            txt_Nombre.Size = new Size(179, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(12, 41);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = "Apellido";
            txt_Apellido.Size = new Size(179, 23);
            txt_Apellido.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(12, 70);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre Usuario";
            txtNombreUsuario.Size = new Size(179, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 23);
            textBox4.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(179, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 1;
            // 
            // AMBUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 289);
            ControlBox = false;
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(btnAceptar);
            Name = "AMBUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AMBUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txtNombreUsuario;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}