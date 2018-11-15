using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class StockOutManager
    {
        StockOutDaL stockOutDaL = new StockOutDaL();
        public DataTable GetCategoryStockOutBindingSource()
        {
            DataTable dt = stockOutDaL.GetCategoryStockOutBindingSource();
            return dt;
        }  
    }
}
