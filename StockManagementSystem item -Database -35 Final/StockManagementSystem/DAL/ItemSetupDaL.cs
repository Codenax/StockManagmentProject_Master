using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    class ItemSetupDaL
    {
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public DataTable GetCategoryBindingSource()
        {
            string query = @"SELECT * FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        public DataTable GetCompanyBindingSource()
        {
            string query = @"SELECT * FROM Companies";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dtc = new DataTable();
            da.Fill(dtc);
            connection.Close();
            return dtc;
        }

        public bool Save(StockManagementSystem stockManagementSystem)
        {
            string query = @"INSERT INTO Itemes(Category,CategoryID,Company,CompanyID,Item,ReoderLevel)
                                    VALUES('" + stockManagementSystem.CategoryName + "','" + stockManagementSystem.CategoryID + "','" + stockManagementSystem.CompanyName + "','"
                                            +stockManagementSystem.CompanyID+"','"+stockManagementSystem.Item+"','"+stockManagementSystem.ReoderLevel+"');";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffacted = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffacted > 0)
            {
                return true;
            }
            return false; 
        }
    }
}
