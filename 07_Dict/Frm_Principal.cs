using static System.Collections.Specialized.BitVector32;

namespace _07_Dict
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Dictionary<string, Dictionary<string, double>> catalogoPetShop = new Dictionary<string, Dictionary<string, double>>();

            catalogoPetShop.Add("Alimentos para Gatos Adultos",
                new Dictionary<string, double> { { "Cat Chow",900},
                                                 { "Wiskas", 1200},
                                                 { "Pedigres", 1800}});
            catalogoPetShop.Add("Alimentos para Perros Cachorros",
                new Dictionary<string, double> { { "Doc Chow", 700},
                                                 { "Proplan", 900},
                                                 { "Pedigres",1100}});
            catalogoPetShop.Add("Alimentos para Gatos Cachorros",
                new Dictionary<string, double> { { "Cat Chow", 650},
                                                 { "Wiskas", 850},
                                                 { "Pedigres",1250}});
            catalogoPetShop.Add("Alimentos para Perros Adultos",
                new Dictionary<string, double> { { "Doc Chow", 850},
                                                 { "Proplan", 1350},
                                                 { "Pedigres", 1450}});

            lstAlimento.Items.Add("Sección\t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, Double>> seccion in catalogoPetShop)
            {
                lstAlimento.Items.Add(seccion.Key);
                foreach (KeyValuePair <string, double> precioValor in seccion.Value)
                {
                    lstAlimento.Items.Add("\t\t\t\t\t" + precioValor.Key + "\t\t" + precioValor.Value);
                    //lstAlimento.Items.Add(seccion.Key + "\t\t\t\t\t" + precioValor.Key + "\t\t" + precioValor.Value);
                }
            }
        }
    }
}