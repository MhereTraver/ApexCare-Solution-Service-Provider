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
    public partial class ReportIssue : Form
    {
        public ReportIssue()
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

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            ServiceDesk serviceDesk = new ServiceDesk();
            serviceDesk.Show();
            this.Close();
        }
    }
}
