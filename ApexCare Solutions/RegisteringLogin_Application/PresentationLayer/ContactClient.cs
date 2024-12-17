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
    public partial class ContactClient : Form
    {
        public ContactClient()
        {
            InitializeComponent();
        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagement clientManagement = new ClientManagement();
            clientManagement.Show();
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

        private void btnServiceDesk_Click(object sender, EventArgs e)
        {
            ServiceDesk serviceDesk = new ServiceDesk();    
            serviceDesk.Show(); 
            this.Close();   
        }

        private void btnCustomerSatisfaction_Click(object sender, EventArgs e)
        {
            CustomerSatisfaction customer = new CustomerSatisfaction(); 
            customer.Show();
            this.Close();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WhatsApp whatsApp = new WhatsApp();
            whatsApp.Show();    
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sms sms = new Sms();
            sms.Show(); 
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExtensionChat extensionChat = new ExtensionChat();  
            extensionChat.Show();   
            this.Close();   
        }
    }
}
