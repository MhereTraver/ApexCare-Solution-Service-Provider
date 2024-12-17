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
    public partial class ConnectTechnician : Form
    {
        public ConnectTechnician()
        {
            InitializeComponent();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();    
            this.Close();   
        }

        private void btnConnectTechnician_Click(object sender, EventArgs e)
        {
            ServiceDesk service = new ServiceDesk();    
            service.Show(); 
            this.Close();   
        }

        private void btnFieldService_Click(object sender, EventArgs e)
        {
            FieldServiceManagement fieldServiceManagement = new FieldServiceManagement();   
            fieldServiceManagement.Show();
            this.Close();

        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            WhatsApp whatsApp = new WhatsApp();
            whatsApp.Show();    
            this.Close();   
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            Sms sms = new Sms();
            sms.Show(); 
            this.Close();   
        }

        private void ConnectTechnician_Load(object sender, EventArgs e)
        {
            //LOAD THE DATA FROM THE SQL DATABASE AUTOMATICALLY UPON THE FOAM LOAD
            SQLDataHandler sQLAccess = new SQLDataHandler();
            dataGridView1.DataSource = sQLAccess.FetchDataFromDB();
        }

        private void btnSendJob_Click(object sender, EventArgs e)
        {
            ExtensionChat extensionChat = new ExtensionChat();
            extensionChat.Show();   
            this.Close();   
        }
    }
}
