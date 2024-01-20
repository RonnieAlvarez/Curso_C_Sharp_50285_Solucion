namespace _08_DGV_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListaMayoresClass listaMayores;
        private void CargarMayores()
        {
            dgvNombres.DataSource = null;
            dgvNombres.AutoGenerateColumns = true;
            dgvNombres.DataSource = listaMayores.GetListaClientes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*            List<string> nombres = new List<string> { "Roman", "Ana", "Fabrizio" };
                        nombres.Add("Juan");
                        nombres.Add("Jose");
                        foreach (string nombre in nombres) lstNombres.Items.Add(nombre); */
            listaMayores = new ListaMayoresClass();
            ClienteClass[] clientes =
             {
                new ClienteClass(12345, "Juan Perez", "Larrea 432", 54),
                new ClienteClass(25452, "Elisabeth Aguirre", "La rioja 852", 35),
                new ClienteClass(19812, "Rodrigo Ruiz", "Av la plata 1564", 85),
                new ClienteClass(9283, "Rene Mendez", "Larrea 432", 45),
                new ClienteClass(12034, "Elena Gonzalez", "Lavalle 432", 25)
             };
            listaMayores.InsertarEnLista(clientes);
            CargarMayores();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            ClienteClass aModificar = new ClienteClass(12345, "Juan Perez", "Larrea 432", 54);
            ClienteClass clienteNuevo = new ClienteClass(54752, "Laura Fernandez", "Rodriguez Peña 1845", 71);
            listaMayores.Modificar(aModificar, clienteNuevo);
            CargarMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ClienteClass clienteNuevo = new ClienteClass(12345, "Juan Perez", "Larrea 432", 54);
            dgvNombres.DataSource = null;
            listaMayores.Borrar(clienteNuevo);
            CargarMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaMayores.Ordenar();
            CargarMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvNombres.DataSource=null;
            dgvNombres.Refresh();
            listaMayores.LimpiarLista();
        }
    }
}
