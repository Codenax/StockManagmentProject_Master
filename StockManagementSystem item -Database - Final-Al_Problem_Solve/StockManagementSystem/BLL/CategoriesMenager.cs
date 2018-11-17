using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CategoriesMenager
    {
        CategoriesDaL CategoriesDaL = new CategoriesDaL();
        public bool Save(StockManagementSystem stockManagementSystem)
        {
            bool isSaved = CategoriesDaL.Save(stockManagementSystem);
            return isSaved;
        }
    }
}
