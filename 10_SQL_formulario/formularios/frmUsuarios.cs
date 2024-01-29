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
        private void btnBuscarUsuarioXiD_Click(object sender, EventArgs e)
        {
            frmConsultaXId frmConsultaXId = new frmConsultaXId();
            frmConsultaXId.Show();
        }
    }
}
