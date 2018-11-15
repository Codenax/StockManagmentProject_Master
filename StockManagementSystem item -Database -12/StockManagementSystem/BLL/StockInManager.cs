using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class StockInManager
    {
        StockInDaL stockInDaL = new StockInDaL();
        public DataTable GetCategoryStockInBindingSource()
        {
            DataTable dt = stockInDaL.GetCategoryStockInBindingSource();
            return dt;
        }      
    }
}
