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

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonHang frmDanh = new frmDonHang();
            frmDanh.Show();

        }

        private void đơnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
