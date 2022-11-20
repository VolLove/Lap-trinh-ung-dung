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
    public partial class frmTableNhanVien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");
        public frmTableNhanVien()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdDonHang = new SqlCommand();
            DataTable tbDonHang = new DataTable();

            try
            {
                con.Open();
                cmdDonHang.CommandText = "sp_SelectNhanVien";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = con;
                da.SelectCommand = cmdDonHang;
                tbDonHang.Clear();
                da.Fill(tbDonHang);
                dvgDonHang.DataSource = tbDonHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }
        }

    }
}
