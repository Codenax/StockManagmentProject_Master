using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    class CompaniesShowDaL
    {
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
       public DataTable GetCompaniesShow()
        {
            string query = @"SELECT * FROM Companies";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable csdt = new DataTable();
            da.Fill(csdt);
            connection.Close();
            return csdt;
        }
    }
}
