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
                
                string reOrder = reoderLevelTextBox.Text;
                string itemName = itemNameTextBox.Text;
                if (categoriesComboBox.SelectedValue == null || companiesComboBox.SelectedValue == null || String.IsNullOrEmpty(itemName) || String.IsNullOrEmpty(reOrder))
                {
                    messageLabel.Text = "Fill Up The Required Information";
                    messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    stockManagementSystem.Item = itemNameTextBox.Text;
                    stockManagementSystem.ReoderLevel = Convert.ToInt32(reoderLevelTextBox.Text);
                    string itemNameQuery = "SELECT * FROM Itemes WHERE Item = '" + stockManagementSystem.Item + "'";
                    string itemNameCheck = "Item";
                    int itemNameCount = DataRead(itemNameQuery, itemNameCheck);
                    if (itemNameCount > 0)
                    {                       
                        messageLabel.Text = "    Item Name Already Have";
                        messageLabel.ForeColor = Color.Green; 
                    }
                    else
                    {
                        bool isSaved = itemSetupManager.Save(stockManagementSystem);
                        if (isSaved)
                        {                     
                            messageLabel.Text = "   Item Name Save Successfully";
                            messageLabel.ForeColor = Color.Blue;
                            categoriesComboBox.Text =
                            companiesComboBox.Text = 
                            itemNameTextBox.Text = 
                            reoderLevelTextBox.Text ="";                      
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
        private void ItemSetupUI_Load(object sender, EventArgs e)
        {
            DataTable dt = itemSetupManager.GetCategoryBindingSource();
            categoriesBindingSource.DataSource = dt;
            DataTable dtc = itemSetupManager.GetCompanyBindingSource();
            companiesBindingSource.DataSource = dtc;                     
            categoriesComboBox.SelectedValue = -1;
            companiesComboBox.SelectedValue = -1;
            messageLabel2.Text = "";
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemNameTextBox.Text = "";
            reoderLevelTextBox.Text = "0";
            messageLabel.Text = "";
            messageLabel2.Text = "";
            companiesComboBox.SelectedValue = -1;
        }

        private void companiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemNameTextBox.Text = "";
            reoderLevelTextBox.Text = "0";
            messageLabel.Text = "";
            messageLabel2.Text = "";
        }
        private void reoderLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                messageLabel2.Text = "Only Number Input";
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    messageLabel2.Text = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
