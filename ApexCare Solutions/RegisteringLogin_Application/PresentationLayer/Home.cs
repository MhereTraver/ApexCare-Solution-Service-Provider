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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagement clientManagement = new ClientManagement();
            clientManagement.Show();    
            this.Close();
        }

        private void btnServiceDesk_Click(object sender, EventArgs e)
        {
            ServiceDesk serviceDesk = new ServiceDesk();    
            serviceDesk.Show();     
            this.Close();   
        }

        private void btnFieldService_Click(object sender, EventArgs e)
        {
            FieldServiceManagement fieldServiceManagement = new FieldServiceManagement();   
            fieldServiceManagement.Show();  
            this.Close();   
        }

        private void btnCustomerSatisfaction_Click(object sender, EventArgs e)
        {
            CustomerSatisfaction customer = new CustomerSatisfaction(); 
            customer.Show();    
            this.Close();   
        }

        private void btnContractManagement_Click(object sender, EventArgs e)
        {
            ContractManagement contractManagement = new ContractManagement();
            contractManagement.Show();  
            this.Close();
        }
    }
}
