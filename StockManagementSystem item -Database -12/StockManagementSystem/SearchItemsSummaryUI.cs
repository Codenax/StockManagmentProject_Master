using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
namespace StockManagementSystem
{
    public partial class SearchItemsSummaryUI : Form
    {
        public SearchItemsSummaryUI()
        {
            InitializeComponent();
        }
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SearchItemsManager searchItemsManager = new SearchItemsManager();
        StockManagementSystem stockManagementSystem = new StockManagementSystem();               
       
        private void companySearchComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dtc = searchItemsManager.GetCompanyBindingSource();
            companiesBindingSource.DataSource = dtc;
        }
        private void categorySearchComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = searchItemsManager.GetCategoryBindingSource();
            categoriesBindingSource.DataSource = dt;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(companySearchComboBox.Text))
            {
                GetCategorySearchVelu();
            }

            else if (string.IsNullOrEmpty(categorySearchComboBox.Text))
            {
                GetCompanySearchVelu();
            }
            else
            {
                GetCat_ComSearchVelu();
            }                        
        }                   
        public void GetCompanySearchVelu()
        {           
            stockManagementSystem.CompanyName = companySearchComboBox.Text;
            string query = @"SELECT Item, Company,Category,AvailableQuantity,ReoderLevel From SearchCom_Cat WHERE Company = '" + stockManagementSystem.CompanyName + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable codt = new DataTable();
            da.Fill(codt);
            connection.Close();
            viewSearchResultDataGridView.DataSource = codt;         
        }
        public void GetCategorySearchVelu()
        {
            stockManagementSystem.CategoryName = categorySearchComboBox.Text;
            string query = @"SELECT Item, Company,Category,AvailableQuantity,ReoderLevel From SearchCom_Cat WHERE Category = '" + stockManagementSystem.CategoryName + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable cadt = new DataTable();
            da.Fill(cadt);
            connection.Close();
            viewSearchResultDataGridView.DataSource = cadt;                       
        }
        public void GetCat_ComSearchVelu()
        {
            stockManagementSystem.CategoryName = categorySearchComboBox.Text;
            stockManagementSystem.CompanyName = companySearchComboBox.Text;
            string query = @"SELECT Item, Company,Category,AvailableQuantity,ReoderLevel From SearchCom_Cat WHERE Category = '" + stockManagementSystem.CategoryName + "' AND Company ='"+ stockManagementSystem.CompanyName+"' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable cadt = new DataTable();
            da.Fill(cadt);
            connection.Close();
            viewSearchResultDataGridView.DataSource = cadt;           
        }       
        private void clearButton_Click(object sender, EventArgs e)
        {
            categorySearchComboBox.Text =
            companySearchComboBox.Text ="";
            
        }
        private void viewSearchResultDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.viewSearchResultDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
            this.viewSearchResultDataGridView.AllowUserToAddRows = false;           
        }

       
    }
}
