﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    class CompaniesDaL
    {
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public bool Save(StockManagementSystem stockManagementSystem)
        {
            string query = @"INSERT INTO Companies(Company)
                                    VALUES('" + stockManagementSystem.CompanyName + "');";
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
