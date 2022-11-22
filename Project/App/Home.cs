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
    public partial class frmHome : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");

        public frmHome()
        {
            InitializeComponent();
        }


        private void mnuDonHang_Click(object sender, EventArgs e)
        {
            frmTableDonHang tableDonHang = new frmTableDonHang();
            tableDonHang.ShowDialog();
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }


        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableKhachHang tableKhachHang = new frmTableKhachHang();
            tableKhachHang.ShowDialog();
            this.Close();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableNhanSu tableNhanSu = new frmTableNhanSu();
            tableNhanSu.ShowDialog();
            this.Close();
        }
    }
}
