namespace _08_DGV_List
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
            lstNombres = new ListBox();
            dgvNombres = new DataGridView();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            btnOrdenar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNombres).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 15;
            lstNombres.Location = new Point(231, 24);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(267, 79);
            lstNombres.TabIndex = 0;
            // 
            // dgvNombres
            // 
            dgvNombres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNombres.Location = new Point(63, 220);
            dgvNombres.Name = "dgvNombres";
            dgvNombres.RowTemplate.Height = 25;
            dgvNombres.Size = new Size(643, 201);
            dgvNombres.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnOrdenar);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Location = new Point(59, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 42);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(386, 13);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(273, 13);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(160, 13);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(47, 13);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvNombres);
            Controls.Add(lstNombres);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNombres).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstNombres;
        private DataGridView dgvNombres;
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnOrdenar;
        private Button btnBorrar;
        private Button btnModificar;
    }
}
