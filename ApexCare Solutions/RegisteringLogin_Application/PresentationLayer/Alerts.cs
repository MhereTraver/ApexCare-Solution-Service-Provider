using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;
using Vonage.Common;
using RegisteringLogin_Application.BusinessLogicLayer;
using System.Web.Script.Serialization;
using RegisteringLogin_Application.DataAccessLayer;

namespace RegisteringLogin_Application.PresentationLayer
{
    public partial class Alerts : Form
    {
        public Alerts()
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnFieldService_Click(object sender, EventArgs e)
        {
            FieldServiceManagement fieldServiceManagement = new FieldServiceManagement();
            fieldServiceManagement.Show();
            this.Close();
        }

        //SEND INFORMATION TO A TECHNICIAN 
        private void btnSendToTechnician_Click(object sender, EventArgs e)
        {
            WhatsAppMessageInformation whatsAppMessageInformation = new WhatsAppMessageInformation();
            whatsAppMessageInformation.SendWhatsAppMessage(txtCellPhoneNumber.Text, txtMessage.Text);
        }
    }
}
