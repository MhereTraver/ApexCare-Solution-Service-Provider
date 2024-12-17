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
using RegisteringLogin_Application.BusinessLogicLayer;

namespace RegisteringLogin_Application.PresentationLayer
{
    public partial class Sms : Form
    {
        public Sms()
        {
            InitializeComponent();
        }

        private void btnConnectTechnician_Click(object sender, EventArgs e)
        {
            ConnectTechnician connectTechnician = new ConnectTechnician();
            connectTechnician.Show();
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            //a1f80edb thats the key
            // b76qIdgrxcujozWD  that is the secret
            var credintials = Credentials.FromApiKeyAndSecret(
              txtKey.Text, txtSecret.Text
            );
            var VonageClient = new VonageClient(credintials);
            var response = VonageClient.SmsClient.SendAnSmsAsync(new Vonage.Messaging.SendSmsRequest()
            {
                To = txtNumber.Text,
                From = txtFrom.Text,
                Text = txtTextArea.Text
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactClient contactClient = new ContactClient();  
            contactClient.Show();
            this.Close();

        }

        private void Sms_Load(object sender, EventArgs e)
        {
            SQLDataHandler sQLAccess = new SQLDataHandler();
            dataGridView1.DataSource = sQLAccess.FetchDataFromDB();
        }
    }
}
