using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_App
{
    public partial class frmTablePhongBan : Form
    {
        public frmTablePhongBan()
        {
            InitializeComponent();
            loadData();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");
        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdDonHang = new SqlCommand();
            DataTable tbDonHang = new DataTable();

            try
            {
                con.Open();
                cmdDonHang.CommandText = "sp_SelectPhongBan";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = con;
                da.SelectCommand = cmdDonHang;
                tbDonHang.Clear();
                da.Fill(tbDonHang);
                dvgPhongBan.DataSource = tbDonHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }
        }
    }
}
