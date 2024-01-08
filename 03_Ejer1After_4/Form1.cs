using System.Security.Cryptography.X509Certificates;

namespace _03_Ejer1After_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcPago_Click(object sender, EventArgs e)
        {
            decimal importeBruto = CalcularImporteBruto();
            decimal antiguedad =  numAntiguedad.Value * 30;
            decimal subTotal = (importeBruto + antiguedad);
            decimal descuento = subTotal * 13 / 100;
            decimal totalNeto = subTotal - descuento;

            this.lblTotalBruto.Text += importeBruto.ToString();
            this.lblPagoAntiguedad.Text += antiguedad.ToString();
            this.lblDescuento.Text += descuento.ToString();
            this.lblTotalNeto.Text += totalNeto.ToString();

            grpRecibo.Visible = true;
        }

        decimal CalcularImporteBruto() {
            decimal importeBruto = Convert.ToDecimal(this.numCantHoras.Value) * Convert.ToDecimal(this.numValorHora.Value);
            return importeBruto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            grpRecibo.Visible = false;
            txtName.Text=string.Empty;
            numAntiguedad.Value=0;
            numValorHora.Value=0;
            numCantHoras.Value = 0;
    }

             
    }
}
