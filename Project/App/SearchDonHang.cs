using BUS_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_App
{
    public partial class frmSearchDonHang : Form
    {
        bus_DonHang busDonHang = new bus_DonHang();
        public frmSearchDonHang()
        {
            InitializeComponent();
            Load("");
        }


  
        private new void Load(string s)
        {
            if (rdoGui.Checked)
            {
                DataTable dataTableDonHang = busDonHang.sp_SearchDonHangByCC(s);
                dgvDonHang.DataSource = dataTableDonHang;
            }
            if (rdoNhan.Checked)
            {
                DataTable dataTableDonHang = busDonHang.sp_SearchDonHangByCCNhan(s);
                dgvDonHang.DataSource = dataTableDonHang;
            }
  
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load("");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string textSearch = txtSearch.Text;
            Load(textSearch);
        }

    }
}
