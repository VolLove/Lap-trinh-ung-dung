using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_App;
using BUS_App;
using Microsoft.Reporting.WinForms;

namespace GUI_App
{
    public partial class frmViewReport : Form
    {
        bus_DonHang busDonHang = new bus_DonHang();
        dto_DonHang donHang = new dto_DonHang();
        bus_NhanVien busNhanVien = new bus_NhanVien();
        bus_KhachHang busKhachHang = new bus_KhachHang();
        public frmViewReport()
        {
            InitializeComponent();
        }

        private void ViewReportDonHang_Load(object sender, EventArgs e)
        {
            DataSet dataSet = busDonHang.report();
            reportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = "reportDonHang.rdlc";
            if (dataSet.Tables[0].Rows.Count>0)
            {
                ReportDataSource report = new ReportDataSource();
                report.Name = "DONHANG";
                report.Value = dataSet.Tables[0];
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(report);
                this.reportViewer.RefreshReport();
            }


        }

    }
}
