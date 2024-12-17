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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {         
            DataHandler handling = new DataHandler();
            handling.RegisterAUser(txtEmail.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
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
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
