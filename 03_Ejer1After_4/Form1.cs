using System.Security.Cryptography.X509Certificates;

namespace _03_Ejer1After_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcPago_Click(object sender, EventArgs e) { MostrarDatosDeRecibo(); }
        private void btnCerrar_Click(object sender, EventArgs e)    {LimpiarDatosIngresados();}
        decimal CalcularImporteBruto()  { return numCantHoras.Value * numValorHora.Value; }
        decimal CalcularAntiguedad()    { return numAntiguedad.Value * 30;}
        decimal CalcularSubTotal()      { return CalcularImporteBruto()+CalcularAntiguedad();}
        decimal CalcularDescuento()     { return CalcularSubTotal() * 13 / 100;}
        decimal CalcularTotalNeto()     { return CalcularSubTotal() - CalcularDescuento(); }
        private void MostrarDatosDeRecibo()
        {
            this.lblTotalBruto.Text += CalcularImporteBruto().ToString();
            this.lblPagoAntiguedad.Text += CalcularAntiguedad().ToString();
            this.lblDescuento.Text += CalcularDescuento().ToString();
            this.lblTotalNeto.Text += CalcularTotalNeto().ToString();
            grpRecibo.Visible = true;
        }
        private void LimpiarDatosIngresados() {
            grpRecibo.Visible = false;
            txtName.Text = string.Empty;
            numAntiguedad.Value = 0;
            numValorHora.Value = 0;
            numCantHoras.Value = 0;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
