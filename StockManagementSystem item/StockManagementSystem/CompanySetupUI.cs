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
                    messageLabel.Text = "Please Fillup";
                }
                else
                {
                    string companyyNameQuery = "SELECT * FROM Companies WHERE Company = '" + stockManagementSystem.CompanyName + "'";
                    string companyNameCheck = "Company";
                    int companyNameCount = DataRead(companyyNameQuery, companyNameCheck);
                    if (companyNameCount > 0)
                    {
                        MessageBox.Show("Company Name Already Have");
                    }
                    else
                    {
                        bool isSaved = companiesMenager.Save(stockManagementSystem);
                        if (isSaved)
                        {
                            messageLabel.Text = "";
                            MessageBox.Show("Company informetion seve");                            
                            DataTable csdt = companiesShowManager.GetCompaniesShow();
                            companyDataGridView.DataSource = csdt;
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
        CompaniesShowManager companiesShowManager = new CompaniesShowManager(); 
        private void CompanySetupUI_Load(object sender, EventArgs e)
        {
            DataTable csdt = companiesShowManager.GetCompaniesShow();
            companyDataGridView.DataSource = csdt;
        }
    }
}
