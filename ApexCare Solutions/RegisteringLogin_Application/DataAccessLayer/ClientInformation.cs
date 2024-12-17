using RegisteringLogin_Application.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringLogin_Application.DataAccessLayer
{
    internal class ClientInformation : ClientManagement
    {
        //DELETE CUSTOMER FROM THE DATABASE
        public string connection = @"Data Source=TMHERE\SQLEXPRESS;Initial Catalog=ApexCareSolutionsDB;Integrated Security=True;Encrypt=False";
        public override void DeletingCustomerFromTheDatabase(int id)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spDeleteCustomer", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@CustomerID", id);

                connect.Open();
                steps.ExecuteNonQuery();

            }
        }


        //DISPLAY CUSTOMER`S DETAILS FROM THE DATABASE
        public override DataTable DisplayCustomerDetails()
        {    
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter("spShowCustomerDetails", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableInfor = new DataTable();
            adapter.Fill(tableInfor);
            return tableInfor;
        }


        //INSERT CUSTOMER DETAILS INTO THE DATABASE
        public override void insertDataIntoTheDatabase(int id, string name, string surname, string email, string contract, string phoneNumber, string address)
        {
            
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spCreateCustomerData", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@CustomerID", id);
                steps.Parameters.AddWithValue("@FirstName", name);
                steps.Parameters.AddWithValue("@LastName", surname);
                steps.Parameters.AddWithValue("@Email", email);
                steps.Parameters.AddWithValue("@CustomerContract", contract);
                steps.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                steps.Parameters.AddWithValue("@CustomerAddress", address);

                connect.Open();
                steps.ExecuteNonQuery();

            }
        }


        //SEARCH CUSTOMER FROM THE DATABASE
        public override DataTable SearchCustomerDataFromTheDatabase(int id)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spSearchCustomer", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@CustomerID", id);

                connect.Open();
                DataTable tableinformation = new DataTable();

                using (SqlDataReader reading = steps.ExecuteReader())
                {
                    tableinformation.Load(reading);
                    return tableinformation;
                }
            }
        }


        ////UPDATING CUSTOMER INFORMATION INTO THE DATABASE
        public override void UpdateCustomerDataIntoTheDatabase(int id, string name, string surname, string email, string contract, string phoneNumber, string address)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spUpdateCustomerDetails", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@CustomerID", id);
                steps.Parameters.AddWithValue("@FirstName", name);
                steps.Parameters.AddWithValue("@LastName", surname);
                steps.Parameters.AddWithValue("@Email", email);
                steps.Parameters.AddWithValue("@CustomerContract", contract);
                steps.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                steps.Parameters.AddWithValue("@CustomerAddress", address);

                connect.Open();
                steps.ExecuteNonQuery();

            }
        }
    }
}
