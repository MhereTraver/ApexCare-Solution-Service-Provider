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
    public partial class ContractManagement : Form
    {
        public ContractManagement()
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

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();   
            signup.Show();  
            this.Close();   
        }

        private void btnCompliments_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();    
            payment.Show(); 
            this.Close();   
        }

        private void btnSurveys_Click(object sender, EventArgs e)
        {
            TypesOfServices typesOfServices = new TypesOfServices();    
            typesOfServices.Show(); 
            this.Show();
        }
    }
}
