using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteringLogin_Application.BusinessLogicLayer
{
    internal class SQLDataHandler
    {
       
        string connection = @"Data Source=TMHERE\SQLEXPRESS;Initial Catalog=ApexCareSolutionsDB;Integrated Security=True;Encrypt=False";
        public DataTable FetchDataFromDB()
        {
            string query = @"SELECT * FROM Employee";
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            return dataTable;
        }
    }
}
