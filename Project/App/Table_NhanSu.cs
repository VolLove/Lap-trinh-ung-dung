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
    public partial class frmTableNhanSu : Form
    {
        public frmTableNhanSu()
        {
            InitializeComponent();
            loadData();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");
        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdNhanSu = new SqlCommand();
            DataTable tbNhanSu = new DataTable();

            try
            {
                con.Open();
                cmdNhanSu.CommandText = "sp_SelectNhanVien";
                cmdNhanSu.CommandType = CommandType.StoredProcedure;
                cmdNhanSu.Connection = con;
                da.SelectCommand = cmdNhanSu;
                tbNhanSu.Clear();
                da.Fill(tbNhanSu);
                dvgDonHang.DataSource = tbNhanSu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }
        }

    }
}
