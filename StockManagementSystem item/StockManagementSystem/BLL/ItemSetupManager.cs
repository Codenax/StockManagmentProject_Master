using StockManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class ItemSetupManager
    {
        ItemSetupDaL itemSetupDaL = new ItemSetupDaL();

        public DataTable GetCategoryBindingSource()
        {
            DataTable dt = itemSetupDaL.GetCategoryBindingSource();
            return dt;
        }
        public DataTable GetCompanyBindingSource()
        {
            DataTable dtc = itemSetupDaL.GetCompanyBindingSource();
            return dtc;
        }


        public bool Save(StockManagementSystem stockManagementSystem)
        {
            bool isSaved = itemSetupDaL.Save(stockManagementSystem);
            return isSaved;
        }
    }
}
