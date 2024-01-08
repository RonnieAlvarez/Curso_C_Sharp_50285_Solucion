namespace _03_Ejer1After_4
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
            lblName = new Label();
            lblAntiguedad = new Label();
            lblValorHora = new Label();
            lblCantHorasTrabajadas = new Label();
            btnCalcPago = new Button();
            txtName = new TextBox();
            numValorHora = new NumericUpDown();
            numCantHoras = new NumericUpDown();
            grpRecibo = new GroupBox();
            lblTotalNeto = new Label();
            lblDescuento = new Label();
            lblPagoAntiguedad = new Label();
            lblTotalBruto = new Label();
            lblTituloRecibo = new Label();
            btnCerrar = new Button();
            numAntiguedad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numValorHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantHoras).BeginInit();
            grpRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAntiguedad).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(59, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.Location = new Point(59, 154);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(97, 15);
            lblAntiguedad.TabIndex = 0;
            lblAntiguedad.Text = "Antiguedad años";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(59, 181);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(62, 15);
            lblValorHora.TabIndex = 0;
            lblValorHora.Text = "Valor Hora";
            // 
            // lblCantHorasTrabajadas
            // 
            lblCantHorasTrabajadas.AutoSize = true;
            lblCantHorasTrabajadas.Location = new Point(59, 206);
            lblCantHorasTrabajadas.Name = "lblCantHorasTrabajadas";
            lblCantHorasTrabajadas.Size = new Size(66, 15);
            lblCantHorasTrabajadas.TabIndex = 0;
            lblCantHorasTrabajadas.Text = "Cant Horas";
            // 
            // btnCalcPago
            // 
            btnCalcPago.Location = new Point(59, 256);
            btnCalcPago.Name = "btnCalcPago";
            btnCalcPago.Size = new Size(75, 23);
            btnCalcPago.TabIndex = 1;
            btnCalcPago.Text = "Calcular Pago";
            btnCalcPago.UseVisualStyleBackColor = true;
            btnCalcPago.Click += btnCalcPago_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 2;
            // 
            // numValorHora
            // 
            numValorHora.Location = new Point(155, 173);
            numValorHora.Name = "numValorHora";
            numValorHora.Size = new Size(120, 23);
            numValorHora.TabIndex = 4;
            // 
            // numCantHoras
            // 
            numCantHoras.Location = new Point(155, 198);
            numCantHoras.Name = "numCantHoras";
            numCantHoras.Size = new Size(120, 23);
            numCantHoras.TabIndex = 4;
            // 
            // grpRecibo
            // 
            grpRecibo.Controls.Add(lblTotalNeto);
            grpRecibo.Controls.Add(lblDescuento);
            grpRecibo.Controls.Add(lblPagoAntiguedad);
            grpRecibo.Controls.Add(lblTotalBruto);
            grpRecibo.Controls.Add(lblTituloRecibo);
            grpRecibo.Controls.Add(btnCerrar);
            grpRecibo.Location = new Point(425, 42);
            grpRecibo.Name = "grpRecibo";
            grpRecibo.Size = new Size(532, 359);
            grpRecibo.TabIndex = 5;
            grpRecibo.TabStop = false;
            grpRecibo.Visible = false;
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Location = new Point(88, 214);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(67, 15);
            lblTotalNeto.TabIndex = 4;
            lblTotalNeto.Text = "Total Neto: ";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(91, 182);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(71, 15);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuentos:";
            // 
            // lblPagoAntiguedad
            // 
            lblPagoAntiguedad.AutoSize = true;
            lblPagoAntiguedad.Location = new Point(88, 139);
            lblPagoAntiguedad.Name = "lblPagoAntiguedad";
            lblPagoAntiguedad.Size = new Size(209, 15);
            lblPagoAntiguedad.TabIndex = 4;
            lblPagoAntiguedad.Text = "Pago por Antiguedad (CantAños*$30):";
            // 
            // lblTotalBruto
            // 
            lblTotalBruto.AutoSize = true;
            lblTotalBruto.Location = new Point(88, 87);
            lblTotalBruto.Name = "lblTotalBruto";
            lblTotalBruto.Size = new Size(191, 15);
            lblTotalBruto.TabIndex = 4;
            lblTotalBruto.Text = "Total Bruto (CantHoras*ValorHora):";
            // 
            // lblTituloRecibo
            // 
            lblTituloRecibo.AutoSize = true;
            lblTituloRecibo.Location = new Point(149, 19);
            lblTituloRecibo.Name = "lblTituloRecibo";
            lblTituloRecibo.Size = new Size(200, 15);
            lblTituloRecibo.TabIndex = 3;
            lblTituloRecibo.Text = "Recibo de Pago Por horas Trabajadas";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(222, 330);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // numAntiguedad
            // 
            numAntiguedad.Location = new Point(155, 146);
            numAntiguedad.Name = "numAntiguedad";
            numAntiguedad.Size = new Size(120, 23);
            numAntiguedad.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 450);
            Controls.Add(grpRecibo);
            Controls.Add(numCantHoras);
            Controls.Add(numAntiguedad);
            Controls.Add(numValorHora);
            Controls.Add(txtName);
            Controls.Add(btnCalcPago);
            Controls.Add(lblCantHorasTrabajadas);
            Controls.Add(lblValorHora);
            Controls.Add(lblAntiguedad);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numValorHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantHoras).EndInit();
            grpRecibo.ResumeLayout(false);
            grpRecibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAntiguedad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAntiguedad;
        private Label lblDescuento;
        public  Label lblValorHora;
        public  Label lblCantHorasTrabajadas;
        private Button btnCalcPago;
        private TextBox txtName;
        public  NumericUpDown numAntiguedad;
        public  NumericUpDown numValorHora;
        public  NumericUpDown numCantHoras;
        private GroupBox grpRecibo;
        private Button btnCerrar;
        private Label lblPagoAntiguedad;
        private Label lblTotalBruto;
        private Label lblTituloRecibo;
        private Label lblTotalNeto;
    }
}
