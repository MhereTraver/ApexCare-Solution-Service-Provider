using RegisteringLogin_Application.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteringLogin_Application.DataAccessLayer
{
    internal class DataHandler
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=TMHERE\SQLEXPRESS;Initial Catalog=ApexCareSolutionsDB;Integrated Security=True;Encrypt=False");
        public DataHandler() { }


        //LOGIN A USER THAT IS ALREADY REGISTERED
        public bool LoginUser(string username, string password)
        {

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string selectData = "SELECT * FROM admin WHERE username = @username AND passowrd = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@pass", password);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {

                                MessageBox.Show(username + " " + "Logged In Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                          
                                 Home home = new Home();
                                Login form1 = new Login();

                                 home.Show();
                                 form1.Close();
                                 form1.Hide();
                                 
                            }
                            else
                            {
                                MessageBox.Show(username + "Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(username + "Error Connecting:", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    
                }
            }
            return true;
        }

        //REGISTER A NEW USER
        public bool RegisterAUser( string email, string username, string password)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=TMHERE\SQLEXPRESS;Initial Catalog=ApexCareSolutionsDB;Integrated Security=True;Encrypt=False");
            if (email == "" || username == "" || password == "")
            {
               
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        string checkUsername = "SELECT * FROM admin WHERE username = '"
                            + username.Trim() + "'";
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                              
                                MessageBox.Show(username + "is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 return true;
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, passowrd, date_created) " +
                                    " VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@email", email.Trim());
                                    cmd.Parameters.AddWithValue("@username", username.Trim());
                                    cmd.Parameters.AddWithValue("@pass", password.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);


                                    cmd.ExecuteNonQuery();


                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error connecting to the Database:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }return true;
            }
        }      
    }
}
