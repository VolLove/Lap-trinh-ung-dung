using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class frmNewDonHang : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");

        public frmNewDonHang()
        {
            InitializeComponent();

        }

        private void frmNewDonHang_Load(object sender, EventArgs e)
        {
            SqlCommand cmdDonHang = new SqlCommand();
            string stringDonHang = "Đơn hàng: ";
            DateTime dateTime;
            DataTable tbDonHang = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                dateTime= DateTime.Now;
                connection.Open();
                cmdDonHang.CommandText = "sp_SelectDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;
                da.SelectCommand = cmdDonHang;
                tbDonHang.Clear();
                da.Fill(tbDonHang); 
                stringDonHang = stringDonHang+ tbDonHang.Rows.Count.ToString() + dateTime.DayOfYear + dateTime.Year;
               lblMaDonHang.Text = stringDonHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }

    }
}
