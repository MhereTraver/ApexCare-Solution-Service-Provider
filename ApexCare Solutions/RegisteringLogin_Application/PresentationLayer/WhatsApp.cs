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
    public partial class WhatsApp : Form
    {
        public WhatsApp()
        {
            InitializeComponent();
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

        private void btnConnectTechnician_Click(object sender, EventArgs e)
        {
            ConnectTechnician connectTechnician = new ConnectTechnician();
            connectTechnician.Show();   
            this.Close();   
        }

        private void SendWhatsAppMessage(string technicianNumber, string message)
        {
            try
            {
                if (technicianNumber == "")
                {
                    MessageBox.Show("Kindly add a Technician`s Phone number");

                    return;
                }
                else if (message == "")
                {
                    MessageBox.Show("Your message cannot be empty!!!");
                    return;
                }
                else if (technicianNumber.Length < 10)
                {
                    MessageBox.Show("Your Number is Short");
                    return;

                }
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone" + technicianNumber +
                    "&text=" + " " + "PREMIER SERVICE SOLUTION⏳ \n \t " + " " + message);
                MessageBox.Show("Poceed to send a Whats app Message😎");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendWhatsAppMessage(txtNumber.Text, txtTextArea.Text);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactClient contactClient = new ContactClient();
            contactClient.Show();
            this.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = string.Empty;
            txtTextArea.Text = string.Empty;
        }
    }
}
