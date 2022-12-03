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
    public partial class frmTableKhachHang : Form
    {
        bus_KhachHang khachHang = new bus_KhachHang();
        public frmTableKhachHang()
        {
            InitializeComponent();
            dvgDonHang.DataSource = khachHang.selectKhachHang();
        }
      
    }
}
