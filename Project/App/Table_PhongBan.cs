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

namespace GUI_App
{
    public partial class frmTablePhongBan : Form
    {
        bus_PhongBan busPhongBan = new bus_PhongBan();
        public frmTablePhongBan()
        {
            InitializeComponent();
            dvgPhongBan.DataSource = busPhongBan.selectPhongBan();
        }

    }
}
