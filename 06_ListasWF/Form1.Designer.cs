namespace _06_ListasWF
{
    partial class frm_listas
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
            lstRazasDePerros = new ListBox();
            lstRazasPerrosInicializado = new ListBox();
            lblBebidadMasCara = new Label();
            lstCiudadesPais = new ListBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            txtValorIngresado = new TextBox();
            SuspendLayout();
            // 
            // lstRazasDePerros
            // 
            lstRazasDePerros.FormattingEnabled = true;
            lstRazasDePerros.ItemHeight = 15;
            lstRazasDePerros.Location = new Point(187, 12);
            lstRazasDePerros.Name = "lstRazasDePerros";
            lstRazasDePerros.Size = new Size(120, 94);
            lstRazasDePerros.TabIndex = 0;
            // 
            // lstRazasPerrosInicializado
            // 
            lstRazasPerrosInicializado.FormattingEnabled = true;
            lstRazasPerrosInicializado.ItemHeight = 15;
            lstRazasPerrosInicializado.Location = new Point(383, 12);
            lstRazasPerrosInicializado.Name = "lstRazasPerrosInicializado";
            lstRazasPerrosInicializado.Size = new Size(120, 94);
            lstRazasPerrosInicializado.TabIndex = 0;
            // 
            // lblBebidadMasCara
            // 
            lblBebidadMasCara.AutoSize = true;
            lblBebidadMasCara.Location = new Point(187, 143);
            lblBebidadMasCara.Name = "lblBebidadMasCara";
            lblBebidadMasCara.Size = new Size(255, 15);
            lblBebidadMasCara.TabIndex = 1;
            lblBebidadMasCara.Text = "La Bebida mas cara de las Bebidas gaseosas es: ";
            // 
            // lstCiudadesPais
            // 
            lstCiudadesPais.FormattingEnabled = true;
            lstCiudadesPais.ItemHeight = 15;
            lstCiudadesPais.Location = new Point(187, 194);
            lstCiudadesPais.Name = "lstCiudadesPais";
            lstCiudadesPais.Size = new Size(316, 124);
            lstCiudadesPais.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(187, 334);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(268, 334);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(349, 334);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(428, 334);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtValorIngresado
            // 
            txtValorIngresado.Location = new Point(187, 363);
            txtValorIngresado.Name = "txtValorIngresado";
            txtValorIngresado.Size = new Size(316, 23);
            txtValorIngresado.TabIndex = 4;
            txtValorIngresado.Text = "Digite el valor a buscar o eliminar";
            // 
            // frm_listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValorIngresado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lstCiudadesPais);
            Controls.Add(lblBebidadMasCara);
            Controls.Add(lstRazasPerrosInicializado);
            Controls.Add(lstRazasDePerros);
            Name = "frm_listas";
            Text = "Listas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRazasDePerros;
        private ListBox lstRazasPerrosInicializado;
        private Label lblBebidadMasCara;
        private ListBox lstCiudadesPais;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnLimpiar;
        private TextBox txtValorIngresado;
    }
}
