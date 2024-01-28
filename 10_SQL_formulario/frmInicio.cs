using _10_SQL_formulario.formularios;

namespace _10_SQL_formulario
{
    public partial class frmInicio : Form
    {

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios frmUsuarios = new();
            frmUsuarios.Show();
        }
    }
}

