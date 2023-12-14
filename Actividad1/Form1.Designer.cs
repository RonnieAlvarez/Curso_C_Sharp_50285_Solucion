namespace Actividad1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEdad = new Label();
            lblAltura = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            txtAltura = new TextBox();
            lblResultado = new Label();
            btnConcatenar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(142, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(142, 162);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(142, 194);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(142, 226);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 0;
            lblEdad.Text = "Edad";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(142, 258);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(215, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(144, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(215, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(144, 23);
            txtApellido.TabIndex = 2;
            txtApellido.KeyDown += txtApellido_KeyDown;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(215, 191);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Cedula (10 chrs)";
            txtDni.Size = new Size(144, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyDown += txtDni_KeyDown;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(215, 223);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Edad";
            txtEdad.Size = new Size(144, 23);
            txtEdad.TabIndex = 4;
            txtEdad.KeyDown += txtEdad_KeyDown;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(215, 255);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(144, 23);
            txtAltura.TabIndex = 5;
            txtAltura.KeyDown += txtAltura_KeyDown;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(229, 326);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // btnConcatenar
            // 
            btnConcatenar.Location = new Point(477, 176);
            btnConcatenar.Name = "btnConcatenar";
            btnConcatenar.Size = new Size(94, 23);
            btnConcatenar.TabIndex = 6;
            btnConcatenar.Text = "Concatenar";
            btnConcatenar.UseVisualStyleBackColor = true;
            btnConcatenar.Click += btnConcatenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConcatenar);
            Controls.Add(lblResultado);
            Controls.Add(txtAltura);
            Controls.Add(txtEdad);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblAltura);
            Controls.Add(lblEdad);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEdad;
        private Label lblAltura;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtEdad;
        private TextBox txtAltura;
        private Label lblResultado;
        private Button btnConcatenar;
    }
}
