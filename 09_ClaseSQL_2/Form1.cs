using System.Data.SqlClient;

namespace _09_ClaseSQL_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";

            List<Producto> listaProductos = new List<Producto>();
            var query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock from Producto;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader()) 
                    {
                        if (dataReader.HasRows) 
                        {
                            while (dataReader.Read()) 
                            {
                                var producto = new Producto();
                                producto.Id=Convert.ToInt32(dataReader["Id"]);
                                producto.Descripciones = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);

                                listaProductos.Add(producto);

                            }
                        }
                    }
                }
            }
            dataGridView1.DataSource=listaProductos;
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
