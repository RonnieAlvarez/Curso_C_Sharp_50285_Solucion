namespace _05UserLogin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            UserClass user = new UserClass(txtName.Text, txtLastName.Text, txtEmail.Text, txtDNI.Text, txtAddress.Text, Convert.ToInt32(txtAge.Text));
            if (!user.IsAdult()) lblAdult.Text = "You are not of age ";
            else lblAdult.Text = "Adult";
            if (user.Name().Length > 0)
                lblFullName.Text = user.Name();
            else
                lblFullName.Text = "You have to enter your name";
            if (user.IsGmailProvider()) lblEmailProvider.Text = "Your eMail Provider is Gmail";
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
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#236C9D"); // Cambia el color cuando el cursor entra
        }

        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#2980B9"); // Cambia el color cuando el cursor sale
        }

    }
}

