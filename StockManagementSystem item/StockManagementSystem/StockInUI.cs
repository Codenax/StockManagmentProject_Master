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
    public partial class StockInUI : Form
    {
        public StockInUI()
        {
            InitializeComponent();
        }
        ///Category ComboBox//////
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        StockInManager stockInManager = new StockInManager();
        StockManagementSystem stockManagementSystem = new StockManagementSystem();       
        private void StockInUI_Load(object sender, EventArgs e)
        {                      
            DataTable cadt = stockInManager.GetCategoryStockInBindingSource();
            categoryStockInBindingSource.DataSource = cadt;          
        }
        ///Category ComboBox End//////
        
        ///Company ComboBox //////
        public DataTable GetCompanyStockInBindingSource()
        {
            stockManagementSystem.CategoryID = Convert.ToInt32(categoryStockInComboBox.SelectedValue);
            string query = @"SELECT Company,CompanyID From CompanyStockIn WHERE CategoryID = '" + stockManagementSystem.CategoryID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable cdt = new DataTable();
            da.Fill(cdt);
            connection.Close();
            return cdt;
        }
        private void categoryStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            DataTable cdt = GetCompanyStockInBindingSource();
            companyStockInBindingSource.DataSource = cdt;
            itemStockInComboBox.Text =
            reoderTextBox.Text =
            stockInQuTextBox.Text=
            availableViewTextBox.Text = "";
        }
        ///Company ComboBoxEnd //////
        
        //////Item ComboBox //////
        public DataTable GetItemStockInBindingSource()
        {
            stockManagementSystem.CompanyID = Convert.ToInt32(companyStockInComboBox.SelectedValue);
            string query = @"SELECT Item, ItemID From Itemes WHERE CompanyID = '" + stockManagementSystem.CompanyID + "' AND CategoryID = '" + stockManagementSystem.CategoryID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable idt = new DataTable();
            da.Fill(idt);
            connection.Close();
            return idt;
        }
        private void companyStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            DataTable idt = GetItemStockInBindingSource();
            itemStockInBindingSource.DataSource = idt;
            availableViewTextBox.Text = "";
        }
        /// ///Item ComboBox End//////
        
        //////ReoderLevel- AvailableQuantityView//////
        private void itemStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReoderLevel();
            AvailableQuantityView();
        }
        private void ReoderLevel()
        {
            stockManagementSystem.ItemID = Convert.ToInt32(itemStockInComboBox.SelectedValue);
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
            stockManagementSystem.ItemID = Convert.ToInt32(itemStockInComboBox.SelectedValue);
            string query = @"SELECT AvailableQuantity From AvailableQuantities WHERE ItemID = '" + stockManagementSystem.ItemID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            DataTable rodt = new DataTable();
            SqlDataReader myReader = null;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                availableViewTextBox.Text = (myReader["AvailableQuantity"].ToString());
            }
            connection.Close();
        }      
        ////////////ReoderLevel- AvailableQuantityView//////END//////

        ////////////StockIn-Database////////////
        private void saveItenInButton_Click(object sender, EventArgs e)
        {
            try
            {
                stockManagementSystem.CategoryName = categoryStockInComboBox.Text;
                stockManagementSystem.CompanyName = companyStockInComboBox.Text;
                stockManagementSystem.Item = itemStockInComboBox.Text;
                stockManagementSystem.StockInQuantity = Convert.ToInt32(stockInQuTextBox.Text);
                if (string.IsNullOrEmpty(stockManagementSystem.CategoryName))
                {
                   MessageBox.Show("Please Filup");
                }
                else
                {
                    string query = @"UPDATE StockIn SET StockInQuantity = StockInQuantity + '" + stockManagementSystem.StockInQuantity + "' WHERE ItemID = '" + stockManagementSystem.ItemID + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int rowAffacted = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowAffacted > 0)
                    {
                        AvailableQuantityView();
                        MessageBox.Show("Quantity Add SuccessFully");
                    }
                  else
                   {
                    string iquery = @"INSERT INTO StockIn(Category,CategoryID,Company,CompanyID,Item,ItemID,StockInQuantity)
                                    VALUES('" + stockManagementSystem.CategoryName + "','" + stockManagementSystem.CategoryID + "','" + stockManagementSystem.CompanyName + "','"
                                              + stockManagementSystem.CompanyID + "','" + stockManagementSystem.Item + "','" + stockManagementSystem.ItemID + "','"
                                              + stockManagementSystem.StockInQuantity + "');";
                    SqlCommand icommand = new SqlCommand(iquery, connection);
                    connection.Open();
                    int irowAffacted = icommand.ExecuteNonQuery();
                    connection.Close();
                    if (irowAffacted > 0)
                    {
                        AvailableQuantityView();
                        MessageBox.Show("Stock in SuccessFully");
                    }
                    else
                    {
                        MessageBox.Show("Stock in Faild");
                    }
                   }
                }                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }                   
        ////////////StockIn-Database End////////////

    }
}
