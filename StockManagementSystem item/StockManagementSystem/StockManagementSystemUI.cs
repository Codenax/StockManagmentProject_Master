using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class StockManagementSystemUI : Form
    {
        public StockManagementSystemUI()
        {
            InitializeComponent();
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySetupUI cts = new CategorySetupUI();
            cts.ShowDialog();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanySetupUI cps = new CompanySetupUI();
            cps.ShowDialog();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetupUI its = new ItemSetupUI();
            its.ShowDialog();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInUI si = new StockInUI();
            si.ShowDialog();
        }
    }
}
