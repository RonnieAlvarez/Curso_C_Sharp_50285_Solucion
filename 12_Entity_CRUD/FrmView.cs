/*
Incluir estos paquetes desde el administrador de Nuget

"Microsoft.EntityFrameworkCore" Version="6.0.26" 
"Microsoft.EntityFrameworkCore.Design" Version="6.0.26"
"Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.26"
"Microsoft.EntityFrameworkCore.Tools" Version="6.0.26"

En el Nuget console del tools

Scaffold-DbContext -Context CoderContext -OutputDir models -ContextDir database "server=localhost;Database=Coderhouse;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer

*/

using _12_Entity_CRUD.models;
using _12_Entity_CRUD.service;
using Microsoft.Data.SqlClient;

namespace _12_Entity_CRUD
{
    public partial class FrmView : Form
    { Usuario usuarioSeleccionado;
        public FrmView()
        {
            InitializeComponent();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioService.GetUsuarios();
            ActualizarDgv(usuarios);
        }
        private void ActualizarDgv(object objeto)
        {
            dgv_Datos.DataSource = null;
            dgv_Datos.DataSource = objeto;
        }
        private void btn_BuscarxId_Click(object sender, EventArgs e)
        {
            if (validarId() > -1)
            {
                int @id = validarId();
                Usuario usuarioBuscado = UsuarioService.GetUsuario(id);
                List<Usuario> lista = new List<Usuario>() { usuarioBuscado };
                ActualizarDgv(lista);
            }
        }

        private int validarId()
        {
            if (!string.IsNullOrWhiteSpace(this.txt_Id.Text))
            {
                int id = Convert.ToInt32(this.txt_Id.Text);
                return id;
            }
            else
            {
                MessageBox.Show("Vuelve a intentarlo, Id no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Id?.Focus();
                return -1;
            }
        }

        private void btnAgregarUsuario_click(object sender, EventArgs e)
        {
            AMBUsuario frmAlta = new AMBUsuario();
            frmAlta.ShowDialog();
            this.Hide();
            Usuario usuario = frmAlta.UsuarioCreado;
            this.Show();
            if (UsuarioService.AgregarUsuario(usuario))
            {
                MessageBox.Show("Se Agrego un Usuario", "Alta");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (validarId() > -1)
            {
                int @id = validarId();
                bool resultado = ProductoService.EliminarProductoPorId(id);
                if (resultado)
                {
                    MessageBox.Show($"Se Borro el Usuario {id}", "Borrado");
                }

            }
        }

        private void dgv_Datos_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dgv_Datos.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.usuarioSeleccionado = dato as Usuario;
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            AMBUsuario frm = new AMBUsuario(this.usuarioSeleccionado);
            frm.ShowDialog();
            Usuario usuarioModificado = frm.UsuarioCreado;
            if(UsuarioService.ActualizarUsuarioXId(usuarioModificado,this.usuarioSeleccionado.Id))
                {
                MessageBox.Show("Usuario Actualizado", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
