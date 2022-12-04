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
        
        bus_DonHang busDonHang = new bus_DonHang();
       
        bool isNotNull = true;

        public frmTableDonHang()
        {
            InitializeComponent();
            dvgDonHang.DataSource = busDonHang.selectDonHang();
        }
     


        private void dvgDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                DataGridViewRow row = this.dvgDonHang.Rows[e.RowIndex];
                txtMaDonHang.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            dto_DonHang donHang = new dto_DonHang();
            string maNV = donHang.getMaHDAuto();

        }

    

        private void cboMaNV_Leave(object sender, EventArgs e)
        {
            if (cboMaNV.Text == "")
            {
                errMaNV.SetError(cboMaNV, "Value is not null");
                isNotNull= false;
            }
            else
            {
                errMaNV.Clear();
                isNotNull = true;
            }
        }

        private void cboCCCDGui_Leave(object sender, EventArgs e)
        {
            if (cboCCCDGui.Text == "")
            {
                errCCCDGui.SetError(cboCCCDGui, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errCCCDGui.Clear();
                isNotNull = true;
            }
        }

        private void cboCCCDNhan_Leave(object sender, EventArgs e)
        {
            if (cboCCCDNhan.Text == "")
            {
                errCCCDNhan.SetError(cboCCCDNhan, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errCCCDNhan.Clear();
                isNotNull = true;
            }
        }
    }
}
