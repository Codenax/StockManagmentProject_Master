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
    public partial class CompanySetupUI : Form
    {
        public CompanySetupUI()
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
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockManagementSystem stockManagementSystem = new StockManagementSystem();
                stockManagementSystem.CompanyName = companyNameTextBox.Text;
                CompaniesMenager companiesMenager = new CompaniesMenager();
                if (string.IsNullOrEmpty(stockManagementSystem.CompanyName))
                {                        
                    messageLabel2.Text = "  Fill Up The Required Information";
                    messageLabel2.ForeColor = Color.Red;
                }
                else
                {
                    string companyyNameQuery = "SELECT * FROM Companies WHERE Company = '" + stockManagementSystem.CompanyName + "'";
                    string companyNameCheck = "Company";
                    int companyNameCount = DataRead(companyyNameQuery, companyNameCheck);
                    if (companyNameCount > 0)
                    {                        
                        messageLabel2.Text = "      Company Name Already Have";
                        messageLabel2.ForeColor = Color.Green;
                    }
                    else
                    {
                        bool isSaved = companiesMenager.Save(stockManagementSystem);
                        if (isSaved)
                        {
                            messageLabel2.Text = "Company Informetion Save Successfully";
                            messageLabel2.ForeColor = Color.Blue;                           
                            DataTable csdt = companiesShowManager.GetCompaniesShow();
                            companyDataGridView.DataSource = csdt;
                        }
                        else
                        {
                            messageLabel2.Text = "Failed";
                            messageLabel2.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        CompaniesShowManager companiesShowManager = new CompaniesShowManager(); 
        private void CompanySetupUI_Load(object sender, EventArgs e)
        {
            DataTable csdt = companiesShowManager.GetCompaniesShow();
            companyDataGridView.DataSource = csdt;
            messageLabel2.Text = "";
        }
        private void companyDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.companyDataGridView.AllowUserToAddRows = false; 
        }
    }
}
