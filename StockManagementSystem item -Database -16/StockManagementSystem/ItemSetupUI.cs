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
    public partial class ItemSetupUI : Form
    {
        public ItemSetupUI()
        {
            InitializeComponent();
        }
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
      
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
        ItemSetupManager itemSetupManager = new ItemSetupManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockManagementSystem stockManagementSystem = new StockManagementSystem();
                stockManagementSystem.CategoryName = categoriesComboBox.Text;
                stockManagementSystem.CategoryID =Convert.ToInt32(categoriesComboBox.SelectedValue);
                stockManagementSystem.CompanyName = companiesComboBox.Text;
                stockManagementSystem.CompanyID = Convert.ToInt32(companiesComboBox.SelectedValue);
                stockManagementSystem.Item = itemNameTextBox.Text;
                stockManagementSystem.ReoderLevel = Convert.ToInt32(reoderLevelTextBox.Text);

                if (string.IsNullOrEmpty(stockManagementSystem.Item))
                {
                    messageLabel.Text = "Please Fillup";
                }
                else
                {
                    string itemNameQuery = "SELECT * FROM Itemes WHERE Item = '" + stockManagementSystem.Item + "'";
                    string itemNameCheck = "Item";
                    int itemNameCount = DataRead(itemNameQuery, itemNameCheck);
                    if (itemNameCount > 0)
                    {
                        MessageBox.Show("Item Name Already Have");
                    }
                    else
                    {
                        bool isSaved = itemSetupManager.Save(stockManagementSystem);
                        if (isSaved)
                        {
                            MessageBox.Show("Item informetion seve");
                            messageLabel.Text = "";                           
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }       
        private void ItemSetupUI_Load(object sender, EventArgs e)
        {
            DataTable dt = itemSetupManager.GetCategoryBindingSource();
            categoriesBindingSource.DataSource = dt;

            DataTable dtc = itemSetupManager.GetCompanyBindingSource();
            companiesBindingSource.DataSource = dtc;
        }
    }
}
