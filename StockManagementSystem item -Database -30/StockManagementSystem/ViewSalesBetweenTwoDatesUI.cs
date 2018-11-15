using DGV2Printer;
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
          try{ 
            DateTime fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            DateTime toDate = Convert.ToDateTime(toDateTimePicker.Text);
            if (toDate.Day >= fromDate.Day)
            {
                DataTable dt = GetResultBetweenTwoDate();
                dateSearchViewdataGridView.DataSource = dt;
            }
            else
            {
                messageLebel.Text = "To Date Must be Equal or Greater than from date";
            }
          }
         catch (Exception exception)
         {
             MessageBox.Show(exception.Message);
         } 
                      
        }
        private void dateSearchViewdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dateSearchViewdataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
            this.dateSearchViewdataGridView.AllowUserToAddRows = false;
        }

        private void ViewSalesBetweenTwoDatesUI_Load(object sender, EventArgs e)
        {
            messageLebel.Text = "";
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            messageLebel.Text = "";
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            messageLebel.Text = "";
        }

        Bitmap bmp;
        private void printButton_Click(object sender, EventArgs e)
        {
            int height = dateSearchViewdataGridView.Height;
            dateSearchViewdataGridView.Height = dateSearchViewdataGridView.RowCount * dateSearchViewdataGridView.RowTemplate.Height * 2;
            bmp = new Bitmap(dateSearchViewdataGridView.Width, dateSearchViewdataGridView.Height);
            dateSearchViewdataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, dateSearchViewdataGridView.Width, dateSearchViewdataGridView.Height));
            dateSearchViewdataGridView.Height = height;
            printDocument1.Print();
    
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


    }
}
