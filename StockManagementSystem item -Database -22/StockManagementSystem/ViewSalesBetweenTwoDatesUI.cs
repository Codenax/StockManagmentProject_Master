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
    public partial class ViewSalesBetweenTwoDatesUI : Form
    {
        public ViewSalesBetweenTwoDatesUI()
        {
            InitializeComponent();
        }

        static String connectionString = @"Data Source=JAHANGIR_PC;Initial Catalog=StockManagementSystem;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public DataTable GetResultBetweenTwoDate()
        {
           DateTime  fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
           DateTime toDate = Convert.ToDateTime(toDateTimePicker.Text);

           string query = @"SELECT Item,SaleQuantity FROM SalesDateSearch WHERE  SaleDate BETWEEN '" + fromDate + "' AND '" + toDate + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        } 
        private void searchDateButton_Click(object sender, EventArgs e)
        {
           
            DateTime fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            DateTime toDate = Convert.ToDateTime(toDateTimePicker.Text);
            if (toDate.Day >= fromDate.Day)
            {
                DataTable dt = GetResultBetweenTwoDate();
                dateSearchViewdataGridView.DataSource = dt;
                MessageBox.Show("Your Serch Result");                                                
            }
            else
            {
                MessageBox.Show("Two Date Must be Equal or Greater than from date"); 
            }
        }
        private void dateSearchViewdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dateSearchViewdataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
            this.dateSearchViewdataGridView.AllowUserToAddRows = false;   
        }
    }
}
