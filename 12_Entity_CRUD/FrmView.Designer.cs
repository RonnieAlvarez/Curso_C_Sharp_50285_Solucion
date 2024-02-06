namespace _12_Entity_CRUD
{
    partial class FrmView
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
            btn_Listar = new Button();
            dgv_Datos = new DataGridView();
            txt_Id = new TextBox();
            btn_BuscarxId = new Button();
            btnAgregarUsuario = new Button();
            btnEliminarProducto = new Button();
            btnActualizarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Datos).BeginInit();
            SuspendLayout();
            // 
            // btn_Listar
            // 
            btn_Listar.Location = new Point(12, 12);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(125, 78);
            btn_Listar.TabIndex = 0;
            btn_Listar.Text = "Listar";
            btn_Listar.UseVisualStyleBackColor = true;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // dgv_Datos
            // 
            dgv_Datos.AllowUserToAddRows = false;
            dgv_Datos.AllowUserToDeleteRows = false;
            dgv_Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Datos.Location = new Point(154, 12);
            dgv_Datos.MultiSelect = false;
            dgv_Datos.Name = "dgv_Datos";
            dgv_Datos.ReadOnly = true;
            dgv_Datos.RowTemplate.Height = 25;
            dgv_Datos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Datos.Size = new Size(634, 426);
            dgv_Datos.TabIndex = 1;
            dgv_Datos.SelectionChanged += dgv_Datos_SelectionChanged;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(23, 96);
            txt_Id.Name = "txt_Id";
            txt_Id.PlaceholderText = "Id a Buscar";
            txt_Id.Size = new Size(100, 23);
            txt_Id.TabIndex = 2;
            // 
            // btn_BuscarxId
            // 
            btn_BuscarxId.Location = new Point(12, 125);
            btn_BuscarxId.Name = "btn_BuscarxId";
            btn_BuscarxId.Size = new Size(125, 78);
            btn_BuscarxId.TabIndex = 0;
            btn_BuscarxId.Text = "Buscar x Id";
            btn_BuscarxId.UseVisualStyleBackColor = true;
            btn_BuscarxId.Click += btn_BuscarxId_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(12, 209);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(125, 59);
            btnAgregarUsuario.TabIndex = 3;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(12, 274);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(125, 59);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnActualizarUsuario
            // 
            btnActualizarUsuario.Location = new Point(12, 339);
            btnActualizarUsuario.Name = "btnActualizarUsuario";
            btnActualizarUsuario.Size = new Size(125, 59);
            btnActualizarUsuario.TabIndex = 3;
            btnActualizarUsuario.Text = "Actualizar Usuario";
            btnActualizarUsuario.UseVisualStyleBackColor = true;
            btnActualizarUsuario.Click += btnActualizarUsuario_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizarUsuario);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(txt_Id);
            Controls.Add(dgv_Datos);
            Controls.Add(btn_BuscarxId);
            Controls.Add(btn_Listar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmView";
            ((System.ComponentModel.ISupportInitialize)dgv_Datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Listar;
        private DataGridView dgv_Datos;
        private TextBox txt_Id;
        private Button btn_BuscarxId;
        private Button btnAgregarUsuario;
        private Button btnEliminarProducto;
        private Button btnActualizarUsuario;
    }
}
