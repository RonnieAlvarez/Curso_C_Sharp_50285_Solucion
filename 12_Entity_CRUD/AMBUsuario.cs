using _12_Entity_CRUD.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Entity_CRUD
{
    public partial class AMBUsuario : Form
    {
        public AMBUsuario()
        {
            InitializeComponent();
        }
        public AMBUsuario(Usuario usuario):this()
        {
            txt_Nombre.Text = usuario.Nombre;
            txt_Apellido.Text = usuario.Apellido;
            txtNombreUsuario.Text=usuario.NombreUsuario;
            txtPassword.Text = usuario.Contraseña;
            txtEmail.Text = usuario.Mail;

        }
        public Usuario UsuarioCreado { get; private set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Apellido = this.txt_Apellido.Text,
                Nombre = this.txt_Nombre.Text,
                Contraseña = this.txtPassword.Text,
                NombreUsuario = this.txtNombreUsuario.Text,
                Mail = this.txtEmail.Text

            };
            this.UsuarioCreado=usuario;
            this.Close();

        }
    }
}
