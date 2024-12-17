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
    public partial class ClientManagement : Form
    {
        public ClientManagement()
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

        private void btnClientDetails_Click(object sender, EventArgs e)
        {
            ClientDetails clientDetails = new ClientDetails();  
            clientDetails.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Close();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            RegisterClient registerClient = new RegisterClient();   
            registerClient.Show();  
            this.Close();   
        }

        private void btnAddNotes_Click(object sender, EventArgs e)
        {
            AddNotes addNotes = new AddNotes();
            addNotes.Show();
            this.Close();
        }

        private void btnContactClient_Click(object sender, EventArgs e)
        {
            ContactClient contactClient = new ContactClient();  
            contactClient.Show();   
            this.Close();   
        }
    }
}
