using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CategoryShowManager
    {
        CategoryShowDaL categoryShowDaL = new CategoryShowDaL();
        public DataTable GetCategoryShow()
        {
            DataTable gdt = categoryShowDaL.GetCategoryShow();
            return gdt;
        }
    }
}
