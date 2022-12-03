using BUS_App;
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
        bus_NhanVien busNhanVien = new bus_NhanVien();
        public frmTableNhanSu()
        {
            InitializeComponent();
            dvgDonHang.DataSource = busNhanVien.selectNhanVien();
        }
    }
}
