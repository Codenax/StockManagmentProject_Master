using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class StockManagementSystem
    {
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
        public string CompanyName { get; set; }
        public int CompanyID { get; set; }
        public string Item { get; set; }
        public int ItemID { get; set; }
        public int ReoderLevel { get; set; }

        public int StockInQuantity { get; set; }
        public int StockOutQuantity { get; set; }
    }
}
