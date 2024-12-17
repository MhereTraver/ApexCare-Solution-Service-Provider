using RegisteringLogin_Application.BusinessLogicLayer;
using RegisteringLogin_Application.DataAccessLayer;
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
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
        }

        //Object to access Client properties
        ClientInformation handler = new ClientInformation();
        

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

        //SEARCH BUTTON
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();  
            this.Close();

        }

        private void btnClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagement clientManagement = new ClientManagement(); 
            clientManagement.Show();    
            this.Close();   
        }


        //DISPLAY CUSTOMER INFORMATION UPON FORM LOAD
        private void RegisterClient_Load(object sender, EventArgs e)
        {        
            dataGridView1.DataSource = handler.DisplayCustomerDetails();
        }

        //INSERTING DATA INTO THE DATABASE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            handler.insertDataIntoTheDatabase(int.Parse(txtId.Text), txtName.Text, txtSurname.Text, txtEmail.Text, txtContract.Text, txtPhone.Text, txtAddress.Text);
            MessageBox.Show("Customer Data inserted Successfully");
        }

        //UPDATING DATA INTO THE DATABASE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            handler.UpdateCustomerDataIntoTheDatabase(int.Parse(txtId.Text), txtName.Text, txtSurname.Text, txtEmail.Text, txtContract.Text, txtPhone.Text, txtAddress.Text);
            MessageBox.Show("Customer Data updated Successfully");

        }

        //DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();   
            delete.Show();
            this.Close();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayCustomerDetails();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["CustomerID"].Value.ToString();
                txtName.Text = row.Cells["FirstName"].Value.ToString();
                txtSurname.Text = row.Cells["LastName"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["CustomerAddress"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtContract.Text = row.Cells["CustomerContract"].Value.ToString();


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContract.Text = "";
        }
    }
}
