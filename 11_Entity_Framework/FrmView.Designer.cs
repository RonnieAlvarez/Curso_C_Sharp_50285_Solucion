namespace _11_Entity_Framework
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
            dgv_Productos = new DataGridView();
            btn_Cargar = new Button();
            lbl_Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            SuspendLayout();
            // 
            // dgv_Productos
            // 
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Location = new Point(2, 207);
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.RowTemplate.Height = 25;
            dgv_Productos.Size = new Size(786, 231);
            dgv_Productos.TabIndex = 0;
            // 
            // btn_Cargar
            // 
            btn_Cargar.Location = new Point(2, 127);
            btn_Cargar.Name = "btn_Cargar";
            btn_Cargar.Size = new Size(141, 74);
            btn_Cargar.TabIndex = 1;
            btn_Cargar.Text = "Cargar Datos";
            btn_Cargar.UseVisualStyleBackColor = true;
            btn_Cargar.Click += btn_Cargar_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(322, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(172, 28);
            lbl_Titulo.TabIndex = 2;
            lbl_Titulo.Text = "Model Code First";
            lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Titulo);
            Controls.Add(btn_Cargar);
            Controls.Add(dgv_Productos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmView";
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Productos;
        private Button btn_Cargar;
        private Label lbl_Titulo;
    }
}
