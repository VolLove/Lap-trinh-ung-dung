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
    public partial class frmTable_PhongBan : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");
        public frmTable_PhongBan()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdDonHang = new SqlCommand();
            DataTable tbDonHang = new DataTable();

            try
            {
                connection.Open();
                cmdDonHang.CommandText = "sp_SelectNhanVien";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;
                da.SelectCommand = cmdDonHang;
                tbDonHang.Clear();
                da.Fill(tbDonHang);
                dvgPhongBan.DataSource = tbDonHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmChancePhongBan chancePhongBan = new frmChancePhongBan();
            chancePhongBan.Text = "Phòng ban mới";
            chancePhongBan.ShowDialog();
        }

     
        private void btnSua_Click(object sender, EventArgs e)
        {
            frmChancePhongBan chancePhongBan = new frmChancePhongBan();
            chancePhongBan.Text = "Chỉnh sửa thông tin phòng ban";
            chancePhongBan.ShowDialog();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
