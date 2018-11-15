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

namespace StockManagementSystem
{
    public partial class StockOutUI : Form
    {
        public StockOutUI()
        {
            InitializeComponent();
        }
        //List<RowIndex> rowIndex = new List<RowIndex>
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        StockManagementSystem stockManagementSystem = new StockManagementSystem();

        ///Category BindingSource//////
        StockOutManager stockOutManager = new StockOutManager();
        private void StockOutUI_Load(object sender, EventArgs e)
        {
            DataTable cadt = stockOutManager.GetCategoryStockOutBindingSource();
            categoryStockInBindingSource.DataSource = cadt;

        }
        ///Category BindingSource End//////

        ///Company BindingSource //////
        public DataTable GetCompanyStockOutBindingSource()
        {
            stockManagementSystem.CategoryID = Convert.ToInt32(categoryStockOutComboBox.SelectedValue);
            string query = @"SELECT Company,CompanyID From CompanyStockIn WHERE CategoryID = '" + stockManagementSystem.CategoryID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable cdt = new DataTable();
            da.Fill(cdt);
            connection.Close();
            return cdt;
        }
        private void categoryStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable cdt = GetCompanyStockOutBindingSource();
            companyStockInBindingSource.DataSource = cdt;
            itemStockOutComboBox.Text =
            reoderTextBox.Text =
            quantityStockOutTextBox.Text =
            availableViewTextBox.Text = "";
        }
        ///Company BindingSource end //////

        //////Item BindingSource //////
        public DataTable GetItemStockOutBindingSource()
        {
            stockManagementSystem.CompanyID = Convert.ToInt32(companyStockOutComboBox.SelectedValue);
            string query = @"SELECT Item, ItemID From Itemes WHERE CompanyID = '" + stockManagementSystem.CompanyID + "' AND CategoryID = '" + stockManagementSystem.CategoryID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable idt = new DataTable();
            da.Fill(idt);
            connection.Close();
            return idt;
        }
        private void companyStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable idt = GetItemStockOutBindingSource();
            itemStockInBindingSource.DataSource = idt;
            reoderTextBox.Text =
            quantityStockOutTextBox.Text =
            availableViewTextBox.Text = "";           
        }
        //////Item BindingSource End //////
        private void ReoderLevel()
        {
            stockManagementSystem.ItemID = Convert.ToInt32(itemStockOutComboBox.SelectedValue);
            string query = @"SELECT ReoderLevel From Itemes WHERE ItemID = '" + stockManagementSystem.ItemID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            DataTable rodt = new DataTable();
            SqlDataReader myReader = null;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                reoderTextBox.Text = (myReader["ReoderLevel"].ToString());
            }
            connection.Close();
        }
        private void AvailableQuantityView()
        {
            stockManagementSystem.ItemID = Convert.ToInt32(itemStockOutComboBox.SelectedValue);
            string query = @"SELECT AvailableQuantity From StockIn WHERE ItemID = '" + stockManagementSystem.ItemID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            DataTable rodt = new DataTable();
            SqlDataReader myReader = null;
            myReader = command.ExecuteReader();
            if (myReader.Read())
            {
                availableViewTextBox.Text = (myReader["AvailableQuantity"].ToString());
            }
            else
            {
                availableViewTextBox.Text ="0";

            }
            connection.Close();
        }
        private void itemStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityStockOutTextBox.Text = "";
            ReoderLevel();
            AvailableQuantityView();
        }
        
        //////ReoderLevel- AvailableQuantityView//////
        //////- StockOut AddButton//////
              
        private readonly List<StockOutViewModel> viewModel = new List<StockOutViewModel>();
        private int _serial = 1;
        private void addStockOutButton_Click(object sender, EventArgs e)
        {
         try
          {
              int flag = 0;    
               StockOutViewModel vmodel = new StockOutViewModel();
               vmodel.Item = itemStockOutComboBox.Text;
               vmodel.Company = companyStockOutComboBox.Text;               
               vmodel.Quantity = Convert.ToInt32(quantityStockOutTextBox.Text);
                                           
               foreach (var viewm in viewModel)
               {
                   if (viewm.Item == itemStockOutComboBox.Text)
                   {
                       flag = 1;
                       viewm.Quantity += Convert.ToInt32(quantityStockOutTextBox.Text);
                       break;
                   }
               }            
             if (flag==0)
             {
                 viewModel.Add(vmodel);
             }
             if(viewModel.Count == 0)
             {
                 viewModel.Add(vmodel);
             }

             ProductListDataGridView.DataSource = null;
             ProductListDataGridView.DataSource = viewModel;
             ProductListDataGridView.AutoGenerateColumns = false;                                             
           }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }                
        }                    
        //////- StockOut AddButton//////
        private void sellButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductListDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ProductListDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
            this.ProductListDataGridView.AllowUserToAddRows = false; 
        }
    }
}
