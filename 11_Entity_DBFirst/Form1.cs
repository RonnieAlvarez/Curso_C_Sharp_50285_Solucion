using _11_Entity_DBFirst.Database;
using _11_Entity_DBFirst.Models;
using System.Runtime.ConstrainedExecution;

namespace _11_Entity_DBFirst
{
    public partial class Frm_View : Form
    {
        public Frm_View()
        {
            InitializeComponent();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            using (CoderContext database = new CoderContext())
            {
                List<Usuario> usuarios = database.Usuarios.ToList();
                this.dgv_Listado.DataSource = usuarios;

                var  usuarioSeleccionado = from usuario in usuarios
                                          where usuario.Id == 3 select usuario;
                
            //    var cer = usuarioSeleccionado.ToList().FirstOrDefault();
            //    MessageBox.Show(cer.Nombre);
                
                var cer3 = usuarios.Where(u=>u.Id == 8).ToList().FirstOrDefault();
                MessageBox.Show(cer3.Nombre);
                
            }
        }
    }
}
