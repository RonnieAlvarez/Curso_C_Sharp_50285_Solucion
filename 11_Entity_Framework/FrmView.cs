using _11_Entity_Framework.database;
using _11_Entity_Framework.models;

namespace _11_Entity_Framework
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                List<Producto> productos = context.Productos.ToList();
                this.dgv_Productos.DataSource = productos;
            }
        }
    }
}
