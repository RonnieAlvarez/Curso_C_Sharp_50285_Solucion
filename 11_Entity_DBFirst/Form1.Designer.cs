namespace _11_Entity_DBFirst
{
    partial class Frm_View
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
            btn_Cargar = new Button();
            dgv_Listado = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Listado).BeginInit();
            SuspendLayout();
            // 
            // btn_Cargar
            // 
            btn_Cargar.Location = new Point(12, 89);
            btn_Cargar.Name = "btn_Cargar";
            btn_Cargar.Size = new Size(157, 101);
            btn_Cargar.TabIndex = 0;
            btn_Cargar.Text = "Cargar";
            btn_Cargar.UseVisualStyleBackColor = true;
            btn_Cargar.Click += btn_Cargar_Click;
            // 
            // dgv_Listado
            // 
            dgv_Listado.AllowUserToAddRows = false;
            dgv_Listado.AllowUserToDeleteRows = false;
            dgv_Listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Listado.Location = new Point(12, 206);
            dgv_Listado.Name = "dgv_Listado";
            dgv_Listado.ReadOnly = true;
            dgv_Listado.RowTemplate.Height = 25;
            dgv_Listado.Size = new Size(776, 232);
            dgv_Listado.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._2024_02_02_12_35_15_Clipboard;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(175, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 187);
            panel1.TabIndex = 2;
            // 
            // Frm_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgv_Listado);
            Controls.Add(btn_Cargar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Frm_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_View";
            ((System.ComponentModel.ISupportInitialize)dgv_Listado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Cargar;
        private DataGridView dgv_Listado;
        private Panel panel1;
    }
}
