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
    public partial class FieldServiceManagement : Form
    {
        public FieldServiceManagement()
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

        private void btnSendJob_Click(object sender, EventArgs e)
        {
            ConnectTechnician connectTechnician = new ConnectTechnician();  
            connectTechnician.Show();   
            this.Close();   
        }

        private void btnClientDetails_Click(object sender, EventArgs e)
        {
            ClientDetails clientDetails = new ClientDetails();  
            clientDetails.Show();   
            this.Close();   
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Alerts alerts = new Alerts();   
            alerts.Show();
            this.Close();

        }

        private void btnJobStatus_Click(object sender, EventArgs e)
        {
            ManageTechnician manageTechnician = new ManageTechnician();
            manageTechnician.Show();    
            this.Close();   
        }
    }
}
