using System.Security.Cryptography.X509Certificates;

namespace _06_ListasWF
{
    public partial class frm_listas : Form
    {
        Dictionary<string, string> ciudadesxPaises = new Dictionary<string, string>();
        public frm_listas()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------------------------------

            string[] razasDePerrosArray = new string[5];
            razasDePerrosArray[0] = "Dalmata";
            razasDePerrosArray[1] = "Ovejero Aleman";
            razasDePerrosArray[2] = "Salchicha";
            razasDePerrosArray[3] = "Caniche";
            razasDePerrosArray[4] = "Pequines";

            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                lstRazasDePerros.Items.Add(razasDePerrosArray[i]);
            }

            string[] razasPerrosInicializado = { "Bulldog", "Pastor Aleman", "Pequines", "Salchicha" };
            for (int i = 0; i < razasPerrosInicializado.Length; i++)
            {
                lstRazasPerrosInicializado.Items.Add(razasPerrosInicializado[i]);
            }



            Producto[] BebidasGaseosas =
            {
                new Producto(1, "Coca Cola",28,38, "Gaseosa"),
                new Producto(1, "Manaos", 84,150,"Gaseosa"),
                new Producto(1, "Peps1", 18,30,"Gaseosa"),
                new Producto(1, "Fanta", 45,65, "Gaseosa")
            };

            Producto BebidaMasCara = new();

            foreach (Producto bebida in BebidasGaseosas)
            {
                if (bebida.PrecioDeCompra > BebidaMasCara.PrecioDeCompra)
                {
                    BebidaMasCara = bebida;
                }
            }
            lblBebidadMasCara.Text += BebidaMasCara.Descripcion.ToUpper();

            //-----------------------------------------
            ciudadesxPaises.Add("Bucaramanga", "Chile");
            ciudadesxPaises.Add("Bogota", "Colombia");
            ciudadesxPaises.Add("Sucre", "Bolivia");
            ciudadesxPaises.Add("Lima", "Bolivia");
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Mexico DF", "Mexico");
            ciudadesxPaises.Add("Asunción", "Paraguay");

            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string valorABuscar = txtValorIngresado.Text;
            bool cityRemoved = false;
            foreach (var pair in ciudadesxPaises.ToList()) 
            {
                if (pair.Key == valorABuscar || pair.Value == valorABuscar)
                {
                    ciudadesxPaises.Remove(pair.Key); 
                    cityRemoved = true;
                    break;
                }
            }

            if (!cityRemoved)
            {
                MessageBox.Show("La ciudad no fue encontrada.");
                return;
            }


            lstCiudadesPais.Items.Clear();
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorABuscar = txtValorIngresado.Text;
            string? pais;
            if (ciudadesxPaises.ContainsKey(valorABuscar))
            {
                ciudadesxPaises.TryGetValue(valorABuscar, out pais);
                MessageBox.Show($"El pais al que pertenece la ciudad de {valorABuscar} es : " + pais);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Clear();
            lstCiudadesPais.Items.Clear();
            MessageBox.Show("Se limpio el contenido del diccionario !!");
        }
    }

}
