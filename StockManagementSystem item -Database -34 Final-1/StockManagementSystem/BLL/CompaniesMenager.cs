using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CompaniesMenager
    {
        CompaniesDaL companyDaL = new CompaniesDaL();
         public bool Save(StockManagementSystem stockManagementSystem)
        {
            bool isSaved = companyDaL.Save(stockManagementSystem);
            return isSaved;
        }
    }
}
