using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CompaniesShowManager
    {
        CompaniesShowDaL companiesShowDaL = new CompaniesShowDaL();
       public DataTable GetCompaniesShow()
        {
            DataTable csdt = companiesShowDaL.GetCompaniesShow();
            return csdt;
        }
    }
}
