using System.ComponentModel;

namespace _02_Clase_FormLogin
{
    public partial class Form1 : Form
    {
        object[,] objUser = new object[3, 3];
        byte cuentaErrores = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objUser[0, 0] = "Juan";
            objUser[0, 1] = "12345678";
            objUser[0, 2] = "Administrator";

            objUser[1, 0] = "Pedro";
            objUser[1, 1] = "87654321";
            objUser[1, 2] = "User";

            objUser[2, 0] = "Maria";
            objUser[2, 1] = "12345678";
            objUser[2, 2] = "Unprofiled";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objUser.GetLength(0); i++)
            {
                if (objUser[i, 0].ToString() == txtName.Text)
                {
                    if (objUser[i, 1].ToString() == txtPassword.Text)
                    {
                        lblProfile.Text = objUser[i, 2].ToString();
                        lblMessage.Text = "Success";
                        lblMessage.BackColor = Color.Teal;
                    }
                    else
                    {
                        if (cuentaErrores == 0) lblMessage.Text = "Fail ";
                        else lblMessage.Text = "Fail "+ cuentaErrores.ToString();
                        lblMessage.BackColor = Color.Red;
                        cuentaErrores++;
                        if (cuentaErrores >= 5)
                        {
                            btnLogin.Enabled = false;
                            txtName.Enabled = false;
                            txtPassword.Enabled = false;
                            lblMessage.Text = "To many fails";
                            lblMessage.BackColor = Color.Red;
                        }
                    }
                        break;
                }
                else
                {
                    continue;
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength >= 8 && cuentaErrores<5)
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
