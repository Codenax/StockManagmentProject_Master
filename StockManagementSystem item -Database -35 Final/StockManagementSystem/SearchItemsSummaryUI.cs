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

        private void SearchItemsSummaryUI_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";         
            CompanyCategoryLoadAndClear();
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();

        }
        private void CompanyCategoryLoadAndClear()
        {
            DataTable dt = searchItemsManager.GetCategoryBindingSource();
            categoriesBindingSource.DataSource = dt;
            companySearchComboBox.SelectedValue = -1;
            categorySearchComboBox.SelectedValue = -1;
            messageLabel.Text = "";
           
        }
        private void companySearchComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dtc = searchItemsManager.GetCompanyBindingSource();
            companiesBindingSource.DataSource = dtc;
            messageLabel.Text = "";

        }
        private void companySearchComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = GetCategoryBindingSourceSelectedCompany();
            categoriesBindingSource.DataSource = dt;
            categorySearchComboBox.SelectedValue = -1;
            messageLabel.Text = "";

        }
        private void categorySearchComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }  
        public DataTable GetCategoryBindingSourceSelectedCompany()
        {
            stockManagementSystem.CompanyID = Convert.ToInt32(companySearchComboBox.SelectedValue);
            string query = @"SELECT SL, Category From CategoryListCompanySelect WHERE CompanyID = '" + stockManagementSystem.CompanyID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable cscdt = new DataTable();
            da.Fill(cscdt);
            connection.Close();
            return cscdt;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {

           if (string.IsNullOrEmpty(companySearchComboBox.Text))
            {
                GetCategorySearchVelu();
                CompanyCategoryLoadAndClear();
            }
                
            else if (string.IsNullOrEmpty(categorySearchComboBox.Text))
            {
                GetCompanySearchVelu();
                CompanyCategoryLoadAndClear();
            }

            else 
            {
                GetCat_ComSearchVelu();
                CompanyCategoryLoadAndClear();
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
            stockManagementSystem.CompanyID = Convert.ToInt32(companySearchComboBox.SelectedValue);
            stockManagementSystem.CategoryID = Convert.ToInt32(categorySearchComboBox.SelectedValue);
            string query = @"SELECT Item, Company,Category,AvailableQuantity,ReoderLevel From SearchCom_Cat WHERE CompanyID = '" + stockManagementSystem.CompanyID + "' AND CategoryID ='" + stockManagementSystem.CategoryID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable cadt = new DataTable();
            da.Fill(cadt);
            connection.Close();
            viewSearchResultDataGridView.DataSource = cadt;           
        }       

        private void viewSearchResultDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.viewSearchResultDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
            this.viewSearchResultDataGridView.AllowUserToAddRows = false;           
        }    
        Bitmap bmp;
        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewSearchResultDataGridView.DataSource != null)
                {
                    int height = viewSearchResultDataGridView.Height;
                    viewSearchResultDataGridView.Height = viewSearchResultDataGridView.RowCount * viewSearchResultDataGridView.RowTemplate.Height * 2;
                    bmp = new Bitmap(viewSearchResultDataGridView.Width, viewSearchResultDataGridView.Height);
                    viewSearchResultDataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, viewSearchResultDataGridView.Width, viewSearchResultDataGridView.Height));
                    viewSearchResultDataGridView.Height = height;
                    printDocument1.Print();
                }
                else
                {
                    messageLabel.Text = " Search First ";
                    messageLabel.ForeColor = Color.Red;   
                }              
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }  
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        } 
    }
}
