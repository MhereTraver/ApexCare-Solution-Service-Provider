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
    public partial class CustomerSatisfaction : Form
    {
        public CustomerSatisfaction()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            Complaints complaints = new Complaints();   
            complaints.Show();  
            this.Close();   
        }

        private void btnContactClient_Click(object sender, EventArgs e)
        {
            ContactClient contactClient = new ContactClient();  
            contactClient.Show();   
            this.Close();   
        }

        private void btnCompliments_Click(object sender, EventArgs e)
        {
            Compliments compliments = new Compliments();
            compliments.Show(); 
            this.Close();   
        }

        private void btnSurveys_Click(object sender, EventArgs e)
        {
            Survey survey = new Survey();   
            survey.Show();  
            this.Close();   
        }
    }
}
