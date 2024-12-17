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
    public partial class ManageTechnician : Form
    {
        public ManageTechnician()
        {
            InitializeComponent();
        }
        EmployeeInformation employeeInformation = new EmployeeInformation();
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
            FieldServiceManagement fieldServiceManagement = new FieldServiceManagement();   
            fieldServiceManagement.Show();  
            this.Show();
        }

        //details upon load of the form
        private void ManageTechnician_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeInformation.DisplayTechnician();
           
        }
        //CREATING A TECHNICIAN INTO THE DATABASE USING  STORED PROCEDURES
        private void btnCreate_Click(object sender, EventArgs e)
        {
            employeeInformation.CreateTechnician(int.Parse(txtId.Text),txtSurname.Text, txtName.Text,txtEmail.Text,txtJob.Text, txtPhoneNumber.Text,txtKey.Text,txtSecret.Text);
            MessageBox.Show("New Technician inserted Successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["employeeID"].Value.ToString();
                txtSurname.Text = row.Cells["surname"].Value.ToString();
                txtName.Text = row.Cells["firstName"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtJob.Text = row.Cells["jobDescription"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["phoneNumber"].Value.ToString();
                txtKey.Text = row.Cells["employeeKey"].Value.ToString();
                txtSecret.Text = row.Cells["employeeSecret"].Value.ToString();


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtJob.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtKey.Text = string.Empty;
            txtSecret.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();  
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeInformation.DisplayTechnician();
        }
    }
}
