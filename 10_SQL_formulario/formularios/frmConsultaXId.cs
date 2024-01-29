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
    public partial class frmConsultaXId : Form
    {
        public frmConsultaXId()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                UsuarioData dbUsuario = new UsuarioData();
                int id = int.Parse(txtID.Text);
                modelo.clsUsuario usuarioObtenido = dbUsuario.ObtenerUsuarioPorId(@id);
                txtNombre.Text =usuarioObtenido.Nombre.ToString();
                txtApellido.Text = usuarioObtenido.Apellido.ToString();
                txtNombreUsuario.Text = usuarioObtenido.NombreUsuario.ToString();
                txtContrasena.Text = usuarioObtenido.Password.ToString();
                txtEmail.Text = usuarioObtenido.Email;
                //SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
