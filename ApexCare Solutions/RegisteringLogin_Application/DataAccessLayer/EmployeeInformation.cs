using RegisteringLogin_Application.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegisteringLogin_Application.DataAccessLayer
{
    internal class EmployeeInformation : TechnicianManagenent
    {
        public string connection = @"Data Source=TMHERE\SQLEXPRESS;Initial Catalog=ApexCareSolutionsDB;Integrated Security=True;Encrypt=False";

        public override void CreateTechnician(int technicianID, string technicianSurname, string firstName, string email, string jobDescription, string phoneNumber, string employeeKey, string employeeSecret)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spCreateEmployee", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@employeeID", technicianID);
                steps.Parameters.AddWithValue("@surname", technicianSurname);
                steps.Parameters.AddWithValue("@firstName", firstName);
                steps.Parameters.AddWithValue("@email", email);
                steps.Parameters.AddWithValue("@jobDescription", jobDescription);
                steps.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                steps.Parameters.AddWithValue("@employeeKey", employeeKey);
                steps.Parameters.AddWithValue("@employeeSecret", employeeSecret);

                connect.Open();
                steps.ExecuteNonQuery();

            }
        }

        //DISPLAY CUSTOMER INFORMATION FROM THE DATABASE
        public override DataTable DisplayTechnician()
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayTechnicianDetails", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableInfor = new DataTable();
            adapter.Fill(tableInfor);
            return tableInfor;
        }


        //SEARCH A TECHNICIAN FROM THE DATABASE
        public override DataTable SearchTechnicianInTheDB(int technicianID)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spSearchTechnician", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@employeeID", technicianID);

                connect.Open();
                DataTable tableinformation = new DataTable();

                using (SqlDataReader reading = steps.ExecuteReader())
                {
                    tableinformation.Load(reading);
                    return tableinformation;
                }

            }
        }

        //DELETE TECHNICIAN FROM THE DATABASE
        public override void DeleteTechnician(int technicianID)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                SqlCommand steps = new SqlCommand("spDeleteTechnician", connect);
                steps.CommandType = CommandType.StoredProcedure;

                steps.Parameters.AddWithValue("@CustomerID", technicianID);

                connect.Open();
                steps.ExecuteNonQuery();

            }
        }

        public override void UpdateTechnician()
        {
            throw new NotImplementedException();
        }
    }
}
