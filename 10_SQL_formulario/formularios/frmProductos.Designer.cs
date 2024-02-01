namespace _10_SQL_formulario.formularios
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            panel1 = new Panel();
            btnBorrarProductoxID = new Button();
            panel4 = new Panel();
            btnLimpiarDatos = new Button();
            txtIdUsuario = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCosto = new TextBox();
            txtDescripciones = new TextBox();
            txtID = new TextBox();
            btnAgregarProducto = new Button();
            btnActualizaProductoxID = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnBuscarProductoXiD = new Button();
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
            panel1.Controls.Add(btnBorrarProductoxID);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(btnActualizaProductoxID);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnBuscarProductoXiD);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 550);
            panel1.TabIndex = 0;
            // 
            // btnBorrarProductoxID
            // 
            btnBorrarProductoxID.BackColor = Color.Red;
            btnBorrarProductoxID.CausesValidation = false;
            btnBorrarProductoxID.FlatStyle = FlatStyle.Flat;
            btnBorrarProductoxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarProductoxID.ForeColor = SystemColors.ControlLightLight;
            btnBorrarProductoxID.Location = new Point(552, 260);
            btnBorrarProductoxID.Name = "btnBorrarProductoxID";
            btnBorrarProductoxID.Size = new Size(121, 35);
            btnBorrarProductoxID.TabIndex = 9;
            btnBorrarProductoxID.Text = "Borrar Producto";
            btnBorrarProductoxID.UseVisualStyleBackColor = false;
            btnBorrarProductoxID.Click += btnBorrarProductoxID_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLimpiarDatos);
            panel4.Controls.Add(txtIdUsuario);
            panel4.Controls.Add(txtStock);
            panel4.Controls.Add(txtPrecioVenta);
            panel4.Controls.Add(txtCosto);
            panel4.Controls.Add(txtDescripciones);
            panel4.Controls.Add(txtID);
            panel4.Location = new Point(24, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 174);
            panel4.TabIndex = 11;
            // 
            // btnLimpiarDatos
            // 
            btnLimpiarDatos.BackColor = Color.FromArgb(0, 192, 192);
            btnLimpiarDatos.CausesValidation = false;
            btnLimpiarDatos.FlatStyle = FlatStyle.Flat;
            btnLimpiarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarDatos.ForeColor = SystemColors.ControlLightLight;
            btnLimpiarDatos.Location = new Point(526, 130);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(102, 31);
            btnLimpiarDatos.TabIndex = 10;
            btnLimpiarDatos.Text = "Limpiar Datos";
            btnLimpiarDatos.UseVisualStyleBackColor = false;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(326, 138);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.PlaceholderText = "IdUsuario";
            txtIdUsuario.Size = new Size(138, 23);
            txtIdUsuario.TabIndex = 5;
            txtIdUsuario.KeyDown += txtIdUsuario_KeyDown;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(48, 138);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock";
            txtStock.Size = new Size(122, 23);
            txtStock.TabIndex = 4;
            txtStock.KeyDown += TextBox_KeyDown;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(326, 99);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "Precio Venta";
            txtPrecioVenta.Size = new Size(245, 23);
            txtPrecioVenta.TabIndex = 3;
            txtPrecioVenta.KeyDown += TextBox_KeyDown;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(48, 99);
            txtCosto.Name = "txtCosto";
            txtCosto.PlaceholderText = "Costo";
            txtCosto.Size = new Size(245, 23);
            txtCosto.TabIndex = 2;
            txtCosto.KeyDown += TextBox_KeyDown;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(48, 53);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.PlaceholderText = "Descripciones";
            txtDescripciones.Size = new Size(523, 23);
            txtDescripciones.TabIndex = 1;
            txtDescripciones.KeyDown += TextBox_KeyDown;
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
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Blue;
            btnAgregarProducto.CausesValidation = false;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = SystemColors.ControlLightLight;
            btnAgregarProducto.Location = new Point(200, 260);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(121, 35);
            btnAgregarProducto.TabIndex = 7;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnActualizaProductoxID
            // 
            btnActualizaProductoxID.BackColor = Color.FromArgb(255, 128, 0);
            btnActualizaProductoxID.CausesValidation = false;
            btnActualizaProductoxID.FlatStyle = FlatStyle.Flat;
            btnActualizaProductoxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizaProductoxID.ForeColor = SystemColors.ControlLightLight;
            btnActualizaProductoxID.Location = new Point(376, 260);
            btnActualizaProductoxID.Name = "btnActualizaProductoxID";
            btnActualizaProductoxID.Size = new Size(121, 35);
            btnActualizaProductoxID.TabIndex = 8;
            btnActualizaProductoxID.Text = "Actualizar Producto";
            btnActualizaProductoxID.UseVisualStyleBackColor = false;
            btnActualizaProductoxID.Click += btnActualizaProductoxID_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(650, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnBuscarProductoXiD
            // 
            btnBuscarProductoXiD.BackColor = Color.FromArgb(0, 192, 192);
            btnBuscarProductoXiD.CausesValidation = false;
            btnBuscarProductoXiD.FlatStyle = FlatStyle.Flat;
            btnBuscarProductoXiD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarProductoXiD.ForeColor = SystemColors.ControlLightLight;
            btnBuscarProductoXiD.Location = new Point(24, 260);
            btnBuscarProductoXiD.Name = "btnBuscarProductoXiD";
            btnBuscarProductoXiD.Size = new Size(121, 35);
            btnBuscarProductoXiD.TabIndex = 6;
            btnBuscarProductoXiD.Text = "Buscar X ID";
            btnBuscarProductoXiD.UseVisualStyleBackColor = false;
            btnBuscarProductoXiD.Click += btnBuscarProductoxID_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.Location = new Point(253, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ProductoS";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.OliveDrab;
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
            label2.Location = new Point(181, 522);
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
            label1.Location = new Point(168, 507);
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
            lblWelcome.Location = new Point(69, 172);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(145, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "ProductoS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += frmProductos_Load;
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
        private Button btnBorrarProductoxID;
        private Button btnActualizaProductoxID;
        private TextBox txtIdUsuario;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtCosto;
        private TextBox txtDescripciones;
        private TextBox txtID;
        private Button btnBuscarProductoXiD;
        private Button btnAgregarProducto;
        private Button btnLimpiarDatos;
    }

     
}