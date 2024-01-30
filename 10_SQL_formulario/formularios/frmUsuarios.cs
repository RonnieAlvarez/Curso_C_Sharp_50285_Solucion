using _10_SQL_formulario.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_SQL_formulario.formularios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }
        public void obtenerDatos()
        {
            UsuarioData dbUsuario = new UsuarioData();
            List<modelo.clsUsuario> lstUsuarios = dbUsuario.ListarUsuarios();
            UsuariosListar(lstUsuarios);
        }
        private void UsuariosListar(List<modelo.clsUsuario> lstUsuarios)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = lstUsuarios;
            dataGridView1.AutoGenerateColumns = true;
            panel3.Visible = true;
            lblTitulo.Text = "LISTADO DE USUARIOS";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            btnBuscarUsuarioXiD.Visible = true;
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                UsuarioData dbUsuario = new UsuarioData();
                int id = int.Parse(txtID.Text);
                modelo.clsUsuario usuarioObtenido = dbUsuario.ObtenerUsuarioPorId(@id);
                txtNombre.Text = usuarioObtenido.Nombre.ToString();
                txtApellido.Text = usuarioObtenido.Apellido.ToString();
                txtNombreUsuario.Text = usuarioObtenido.NombreUsuario.ToString();
                txtContrasena.Text = usuarioObtenido.Password.ToString();
                txtEmail.Text = usuarioObtenido.Email;
                //SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnBorrarUsuarioxID_Click(object sender, EventArgs e)
        {
            UsuarioData dbUsuario = new UsuarioData();
            int id = int.Parse(txtID.Text);

            if (dbUsuario.BorraUsuarioPorId(@id)) TareaCompletada("eliminación");
            else TareaCompletada("eliminación no");
        }

        private void btnActualizaUsuarioxID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            UsuarioData dbUsuario = new UsuarioData();
            modelo.clsUsuario usuarioActualizar = new(
               txtNombre.Text,
               txtApellido.Text,
               txtNombreUsuario.Text,
               txtContrasena.Text,
               txtEmail.Text
            );
            if (dbUsuario.UpdateUsuarioPorId(@id, usuarioActualizar)) TareaCompletada("actualización");
            else TareaCompletada("actualización no");
            this.Close();
        }
        private void TareaCompletada(string msm)
        {
            MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
