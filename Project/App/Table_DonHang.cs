using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_App;
using DTO_App;


namespace App
{
    public partial class frmTableDonHang : Form
    {
        
        bus_DonHang donHang = new bus_DonHang();
        
        public frmTableDonHang()
        {
            InitializeComponent();
            dvgDonHang.DataSource = donHang.selectDonHang();
        }
     

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                DataGridViewRow row = this.dvgDonHang.Rows[e.RowIndex];
                txtMaDonHang.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
