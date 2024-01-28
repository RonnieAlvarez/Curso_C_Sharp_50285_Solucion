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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            UsuariosListar();
        }

        private void UsuariosListar()
        {
            List<modelo.Usuario> listaUsuarios = new List<modelo.Usuario>();
            dataGridView1.DataSource = listaUsuarios;
            dataGridView1.AutoGenerateColumns = true;
        }

      
    }
}
