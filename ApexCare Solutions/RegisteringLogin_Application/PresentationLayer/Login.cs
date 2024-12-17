using RegisteringLogin_Application.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RegisteringLogin_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.LoginUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegisterHere_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void checkboxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
