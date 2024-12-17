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
using Vonage.Request;
using Vonage;

namespace RegisteringLogin_Application.PresentationLayer
{
    public partial class ExtensionChat : Form
    {
        public ExtensionChat()
        {
            InitializeComponent();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();   
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();    
            this.Close();   
        }

        private void ExtensionChat_Load(object sender, EventArgs e)
        {
            SQLDataHandler sQLAccess = new SQLDataHandler();
            dataGridView1.DataSource = sQLAccess.FetchDataFromDB();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = string.Empty;
            txtSecret.Text = string.Empty;
            txtMessage.Text = string.Empty;
            txtKey.Text = string.Empty;
            txtFrom.Text = string.Empty;
        }

        private void btnContactClient_Click(object sender, EventArgs e)
        {
            ContactClient client = new ContactClient(); 
            client.Show();
            this.Close();
        }

        private void btnConnectTechnician_Click(object sender, EventArgs e)
        {
            ConnectTechnician connectTechnician = new ConnectTechnician();  
            connectTechnician.Show();   
            this.Close();   
        }
        //Message to the receipient
        private void btnSend_Click(object sender, EventArgs e)
        {
            var credintials = Credentials.FromApiKeyAndSecret(
              txtKey.Text, txtSecret.Text
            );
            var VonageClient = new VonageClient(credintials);
            var response = VonageClient.SmsClient.SendAnSmsAsync(new Vonage.Messaging.SendSmsRequest()
            {
                To = txtNumber.Text,
                From = txtFrom.Text,
                Text = txtMessage.Text
            });

        }
    }
}
