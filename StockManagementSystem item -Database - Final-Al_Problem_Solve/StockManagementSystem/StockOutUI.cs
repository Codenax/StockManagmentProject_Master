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
        
        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        StockManagementSystem stockManagementSystem = new StockManagementSystem();

        ///Category BindingSource//////
        StockOutManager stockOutManager = new StockOutManager();
        private void StockOutUI_Load(object sender, EventArgs e)
        {
            DataTable cadt = stockOutManager.GetCategoryStockOutBindingSource();
            categoryStockInBindingSource.DataSource = cadt;
            categoryStockOutComboBox.SelectedValue = -1;
            messageLabel.Text = "";
            messageLabel2.Text = "";
            Notification();
            timer2.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
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
            messageLabel.Text =
            companyStockOutComboBox.Text = "";
            Notification();
            clearReoderQuantityAvilable();
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
            clearReoderQuantityAvilable();
            Notification();
            messageLabel.Text = "";
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
            string query = @"SELECT AvailableQuantity From AvailableQuantities WHERE ItemID = '" + stockManagementSystem.ItemID + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            DataTable rodt = new DataTable();
            SqlDataReader myReader = null;
            myReader = command.ExecuteReader();          
            int avialableQty = 0;            
            if (myReader.Read())
            {
                avialableQty = Convert.ToInt32(myReader["AvailableQuantity"].ToString());
                StockOutavailableQuantity newAvailableQuantity = new StockOutavailableQuantity();
                newAvailableQuantity.Item = itemStockOutComboBox.Text;
                foreach (var stockOut in viewModel)
                {
                    if (newAvailableQuantity.Item == stockOut.Item)
                    {
                        avialableQty -= stockOut.Quantity;
                    }
                }
                availableViewTextBox.Text = avialableQty.ToString();
            }
            else
            {
                availableViewTextBox.Text = "0";

            }
            connection.Close();
            return;     
        }
        private void itemStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                quantityStockOutTextBox.Text = "";
                messageLabel.Text = "";
                ReoderLevel();
                AvailableQuantityView();

                int reorderLavel = Convert.ToInt32(reoderTextBox.Text);
                int quantity = Convert.ToInt32(availableViewTextBox.Text);

                if (reorderLavel > quantity)
                {
                    notificationLebel.Text = "Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....Stock is out of reorder level--Reorder in as soon as possible.....";
                    timer1.Enabled = true;
                    timer1.Interval = 20;
                }
                else
                {
                    Notification();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            } 


        }      
        //////ReoderLevel- AvailableQuantityView//////
        ///Clear box ///////
        private void Notification()
        {
            timer1.Enabled = false;
            notificationLebel.Text = "";
        } 
        private void clearReoderQuantityAvilable()
        {
            itemStockOutComboBox.Text = 
            reoderTextBox.Text =
            quantityStockOutTextBox.Text =
            messageLabel2.Text =            
            availableViewTextBox.Text = ""; 
        }
        ///Clear box end///////
        //////- StockOut AddButton//////              
        private readonly List<StockOutViewModel> viewModel = new List<StockOutViewModel>();
        //StockOutViewModel vmodel = new StockOutViewModel();
        private void addStockOutButton_Click(object sender, EventArgs e)
        {
         try
          {
                  int flag = 0;
                  StockOutViewModel vmodel = new StockOutViewModel();
                  string categryName = categoryStockOutComboBox.Text;
                  string companyName = companyStockOutComboBox.Text;
                  string itemName = itemStockOutComboBox.Text;                  
                  string quantityStockOut = quantityStockOutTextBox.Text;
                  if (String.IsNullOrEmpty(categryName) || String.IsNullOrEmpty(companyName) || String.IsNullOrEmpty(itemName) || String.IsNullOrEmpty(quantityStockOut) || Convert.ToInt32(quantityStockOutTextBox.Text) == 0)
                  {
                      messageLabel.Text = ("  Fill Up The Required Information");
                      messageLabel.ForeColor = Color.Red;
                  }
                  
                  else
                  {
                      int availableQuantity = Convert.ToInt32(availableViewTextBox.Text);
                      int stockOutQuantity = Convert.ToInt32(quantityStockOutTextBox.Text);
                      if (stockOutQuantity > availableQuantity)
                      {
                          messageLabel.Text = " Requested Quantity Is Not Available";
                          messageLabel.ForeColor = Color.Red;
                      }

                     else
                       {
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
                              if (flag == 0)
                              {
                                   viewModel.Add(vmodel);
                              }
                              if  (viewModel.Count == 0)
                              {
                                   viewModel.Add(vmodel);
                              }
                                  ProductListDataGridView.DataSource = null;
                                  ProductListDataGridView.DataSource = viewModel;
                                  ProductListDataGridView.AutoGenerateColumns = false;
                                  itemStockOutComboBox.Text = "";
                                  clearReoderQuantityAvilable();                          
                        }
                  }                                                                                      
           }
          catch (Exception exception)
           {
                 MessageBox.Show(exception.Message);
           }  
       }
        private void ProductListDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ProductListDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
            this.ProductListDataGridView.AllowUserToAddRows = false;
        }        
        //////- StockOut AddButton//////
        /// Sell -Damage-Lost Button////
        private void sellButton_Click(object sender, EventArgs e)
        {
            try
            { 
            if (ProductListDataGridView.DataSource == null )
                {
                    messageLabel.Text = "     Add Item In The List First";
                    messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    for (int i = 0; i < ProductListDataGridView.Rows.Count; i++)
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO StockIn (Item,Company,SalesQuantity)
                                    VALUES('" + ProductListDataGridView.Rows[i].Cells[1].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[2].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[3].Value + "')", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    String SaleDate = DateTime.Now.ToString();
                    for (int i = 0; i < ProductListDataGridView.Rows.Count; i++)
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO SalesDate (Item,SaleQuantity,SaleDate)
                                    VALUES('" + ProductListDataGridView.Rows[i].Cells[1].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[3].Value + "','" + SaleDate + "')", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    messageLabel.Text = "Sales Information Saved Successfully";
                    messageLabel.ForeColor = Color.Green;
                    clearReoderQuantityAvilable();
                    ProductListDataGridView.DataSource = null;
                    viewModel.Clear();
                }
            }
           catch (Exception exception)
           {
               MessageBox.Show(exception.Message);
           }                      
        }        
        private void damageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductListDataGridView.DataSource == null)
                {
                    messageLabel.Text = "      Add Item In The List First";
                    messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    String SalesTime = DateTime.Now.ToString();
                    for (int i = 0; i < ProductListDataGridView.Rows.Count; i++)
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO StockIn (Item,Company,DamageQuantity)
                                    VALUES('" + ProductListDataGridView.Rows[i].Cells[1].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[2].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[3].Value + "')", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    messageLabel.Text = "Damage Information Saved Successfully";
                    messageLabel.ForeColor = Color.Blue;
                    ProductListDataGridView.DataSource = null;
                    clearReoderQuantityAvilable();
                    viewModel.Clear();
                }
             }
           catch (Exception exception)
           {
               MessageBox.Show(exception.Message);
           } 
        }
        private void lostButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductListDataGridView.DataSource == null)
                {
                    messageLabel.Text = "     Add Item In The List First";
                }
                else
                {
                    String SalesTime = DateTime.Now.ToString();
                    for (int i = 0; i < ProductListDataGridView.Rows.Count; i++)
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO StockIn (Item,Company,LostQuantity)
                                    VALUES('" + ProductListDataGridView.Rows[i].Cells[1].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[2].Value + "','"
                                                      + ProductListDataGridView.Rows[i].Cells[3].Value + "')", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    messageLabel.Text = "Lost Information Saved Successfully";
                    messageLabel.ForeColor = Color.Blue;
                    ProductListDataGridView.DataSource ="";
                    clearReoderQuantityAvilable();
                    viewModel.Clear();
                

                }
             }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            } 
        }
        private void quantityStockOutTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (notificationLebel.Left < 0 && (Math.Abs(notificationLebel.Left) > notificationLebel.Width))
                notificationLebel.Left = this.Width;
                notificationLebel.Left -= 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }
     
    }
}
