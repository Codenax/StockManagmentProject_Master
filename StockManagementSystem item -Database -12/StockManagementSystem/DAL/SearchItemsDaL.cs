using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    class SearchItemsDaL
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

    }
}
