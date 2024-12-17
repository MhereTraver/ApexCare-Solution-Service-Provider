using RegisteringLogin_Application.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteringLogin_Application.PresentationLayer
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            RegisterClient registerClient = new RegisterClient();   
            registerClient.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();    
            this.Close();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();   
            this.Close();   
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        //DELETING A CUSTOMER FROM THE DATABASE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CrudOperations handler = new CrudOperations();
            handler.DeletingCustomerFromTheDatabase(int.Parse(txtSearchBox.Text));
            MessageBox.Show("Customer details deleted");

            txtSearchBox.Text = string.Empty;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTechnician manageTechnician = new ManageTechnician(); 
            manageTechnician.Show();    
            this.Close();   
        }
    }
}
