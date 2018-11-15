using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class SearchItemsManager
    {
        SearchItemsDaL searchItemsDaL = new SearchItemsDaL();
        public DataTable GetCategoryBindingSource()
        {
            DataTable dt = searchItemsDaL.GetCategoryBindingSource();
            return dt;
        }
        public DataTable GetCompanyBindingSource()
        {
            DataTable dtc = searchItemsDaL.GetCompanyBindingSource();
            return dtc;
        }

    }
}
