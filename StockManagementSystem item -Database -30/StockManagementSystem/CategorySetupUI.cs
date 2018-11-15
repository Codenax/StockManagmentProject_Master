using StockManagementSystem.BLL;
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
    public partial class CategorySetupUI : Form
    {
        public CategorySetupUI()
        {
            InitializeComponent();
        }
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        int Serial = 0;
        int DataRead(string query, string chackValue)
        {
            try
            {              
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                int count = 0;
                if (dataReader.Read())
                {
                    dataReader[chackValue].ToString();
                    count = 1;
                }
                connection.Close();
                return count;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }                
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockManagementSystem stockManagementSystem = new StockManagementSystem();
                stockManagementSystem.CategoryName = categoryNameTextBox.Text;
                CategoriesMenager categoriesMenager = new CategoriesMenager();
                if (string.IsNullOrEmpty(stockManagementSystem.CategoryName))
                {                       
                    messageLabel.Text = " Fill Up The Required Information";
                    messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    string categoryNameQuery = "SELECT * FROM Categories WHERE Category = '" + stockManagementSystem.CategoryName + "'";
                    string categoryNameCheck = "Category";
                    int categoryNameCount = DataRead(categoryNameQuery, categoryNameCheck);
                    if (categoryNameCount > 0)
                    {                       
                        messageLabel.Text = "    Category Name Already Have";
                        messageLabel.ForeColor = Color.Green;                        
                    }
                    else
                    {
                        bool isSaved = categoriesMenager.Save(stockManagementSystem);
                        if (isSaved)
                        {
                            messageLabel.Text = "Category Informetion Save Successfully";
                            messageLabel.ForeColor = Color.Blue;                                                        
                            DataTable cdt = categoryShowManager.GetCategoryShow();
                            categoryDataGridView.DataSource = cdt;
                        }
                        else
                        {
                            messageLabel.Text = ("Failed");
                            messageLabel.ForeColor = Color.Red;                            
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {           
            try
            {
                StockManagementSystem stockManagementSystem = new StockManagementSystem();
                stockManagementSystem.CategoryName = categoryNameTextBox.Text;
                CategoriesMenager categoriesMenager = new CategoriesMenager();
                if (string.IsNullOrEmpty(stockManagementSystem.CategoryName))
                {                       
                    messageLabel.Text = " Fill Up The Required Information";
                    messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    string categoryNameQuery = "SELECT * FROM Categories WHERE Category = '" + stockManagementSystem.CategoryName + "'";
                    string categoryNameCheck = "Category";
                    int categoryNameCount = DataRead(categoryNameQuery, categoryNameCheck);
                    if (categoryNameCount > 0)
                    {                       
                        messageLabel.Text = "    Category Name Already Have";
                        messageLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        connection.Open();
                        string updeteQuery = "UPDATE Categories SET Category = '" + categoryNameTextBox.Text + "' WHERE SL ='" + Serial + "'";
                        SqlDataAdapter Ud = new SqlDataAdapter(updeteQuery, connection);
                        Ud.SelectCommand.ExecuteNonQuery();
                        connection.Close();                       
                        {                           
                            messageLabel.Text = "Category Name Update Successfully";
                            messageLabel.ForeColor = Color.Blue;
                            DataTable cdt = categoryShowManager.GetCategoryShow();
                            categoryDataGridView.DataSource = cdt;
                        }                      
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void categoryDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Serial = Convert.ToInt32(categoryDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            categoryNameTextBox.Text = categoryDataGridView.SelectedRows[0].Cells[1].Value.ToString();    
        }
        CategoryShowManager categoryShowManager = new CategoryShowManager();      
        private void CategorySetupUI_Load(object sender, EventArgs e)
        {
            DataTable cdt = categoryShowManager.GetCategoryShow();
            categoryDataGridView.DataSource = cdt;
            messageLabel.Text = "";
        }

        private void categoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            this.categoryDataGridView.AllowUserToAddRows = false;
        }
    }
}
