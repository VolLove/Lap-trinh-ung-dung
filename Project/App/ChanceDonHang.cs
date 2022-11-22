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
    public partial class ChanceDonHang : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");

        public ChanceDonHang()
        {
            InitializeComponent();

        }

        private void frmNewDonHang_Load(object sender, EventArgs e)
        {
            SqlCommand cmdDonHang = new SqlCommand();
            string stringDonHang = "Đơn hàng: ";
            DateTime dateTime;
            DataTable tbDonHang = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                dateTime= DateTime.Now;
                connection.Open();
                cmdDonHang.CommandText = "sp_SelectDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;
                da.SelectCommand = cmdDonHang;
                tbDonHang.Clear();
                da.Fill(tbDonHang); 
                stringDonHang = stringDonHang+ tbDonHang.Rows.Count.ToString() + dateTime.DayOfYear + dateTime.Year;
               lblMaDonHang.Text = stringDonHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }
        private bool bl = true;

        private void txtMaNhanVien_Leave(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                errorProvider1.SetError(txtMaNhanVien, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider1.Clear();
                bl = true;
            }

        }

        private void txtKhoiLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtKhoiLuong.Text);
                errorProvider2.Clear();
                bl = true;
            }
            catch (Exception)
            {
                if (txtKhoiLuong.Text=="")
                {
                    errorProvider2.SetError(txtKhoiLuong, "Value is not null");

                }
                else
                {
                    errorProvider2.SetError(txtKhoiLuong, "Value is not number");
                }
                    bl = false;

            }
        }

        private void txtKichThuoc_Leave(object sender, EventArgs e)
        {

            try
            {
                double x = double.Parse(txtKichThuoc.Text);
                errorProvider3.Clear();
                bl = true;
            }
            catch (Exception)
            {
                if (txtKichThuoc.Text == "")
                {
                    errorProvider3.SetError(txtKichThuoc, "Value is not null");

                }
                else
                {
                    errorProvider3.SetError(txtKichThuoc, "Value is not number");
                }
                bl = false;

            }
        }
        private void txtCuoc_Leave(object sender, EventArgs e)
        {

            try
            {
                double x = double.Parse(txtCuoc.Text);
                errorProvider4.Clear();
                bl = true;
            }
            catch (Exception)
            {
                if (txtCuoc.Text == "")
                {
                    errorProvider4.SetError(txtCuoc, "Value is not null");

                }
                else
                {
                    errorProvider4.SetError(txtCuoc, "Value is not number");
                }
                bl = false;

            }
        }

        private void txtMieuTa_Leave(object sender, EventArgs e)
        {

            if (txtMieuTa.Text == "")
            {
                errorProvider5.SetError(txtMieuTa, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider5.Clear();
                bl = true;
            }
        }

        private void txtNameFrom_Leave(object sender, EventArgs e)
        {

            if (txtNameFrom.Text == "")
            {
                errorProvider6.SetError(txtNameFrom, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider6.Clear();
                bl = true;
            }
        }

        private void cbxGioiTinhFrom_Leave(object sender, EventArgs e)
        {

            if (cbxGioiTinhFrom.Text == "")
            {
                errorProvider7.SetError(cbxGioiTinhFrom, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider7.Clear();
                bl = true;
            }
        }

        private void txtCCCDFrom_Leave(object sender, EventArgs e)
        {
            if (txtCCCDFrom.Text == "")
            {
                errorProvider8.SetError(txtCCCDFrom, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider8.Clear();
                bl = true;
            }
        }

        private void txtDiaChiFrom_Leave(object sender, EventArgs e)
        {
            if (txtDiaChiFrom.Text == "")
            {
                errorProvider9.SetError(txtDiaChiFrom, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider9.Clear();
                bl = true;
            }
        }

        private void txtSDTFrom_Leave(object sender, EventArgs e)
        {
            if (txtSDTFrom.Text == "")
            {
                errorProvider10.SetError(txtSDTFrom, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider10.Clear();
                bl = true;
            }
        }

        private void txtNameTo_Leave(object sender, EventArgs e)
        {
            if (txtNameTo.Text == "")
            {
                errorProvider11.SetError(txtNameTo, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider11.Clear();
                bl = true;
            }
        }

        private void cbxGioiTinhTo_Leave(object sender, EventArgs e)
        {
            if (cbxGioiTinhTo.Text == "")
            {
                errorProvider12.SetError(cbxGioiTinhTo, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider12.Clear();
                bl = true;
            }
        }

        private void txtCCCDTo_Leave(object sender, EventArgs e)
        {
            if (txtCCCDTo.Text == "")
            {
                errorProvider13.SetError(txtCCCDTo, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider13.Clear();
                bl = true;
            }
        }

        private void txtDiaChiTo_Leave(object sender, EventArgs e)
        {
            if (txtDiaChiTo.Text == "")
            {
                errorProvider14.SetError(txtDiaChiTo, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider14.Clear();
                bl = true;
            }
        }

        private void txtSDTTo_Leave(object sender, EventArgs e)
        {
            if (txtSDTTo.Text == "")
            {
                errorProvider15.SetError(txtSDTTo, "Value is not null");
                bl = false;
            }
            else
            {
                errorProvider15.Clear();
                bl = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtCCCDFrom_Leave(sender, e);
            this.txtCCCDTo_Leave(sender, e);
            this.txtCuoc_Leave(sender, e);
            this.txtDiaChiFrom_Leave(sender, e);
            this.txtDiaChiTo_Leave (sender, e);
            this.txtKhoiLuong_Leave(sender, e);
            this.txtKichThuoc_Leave(sender, e);
            this.txtMaNhanVien_Leave(sender, e);
            this.txtMieuTa_Leave(sender, e);
            this.txtNameFrom_Leave(sender, e);
            this.txtNameTo_Leave(sender, e);
            this.txtSDTFrom_Leave(sender, e);
            this.txtSDTTo_Leave(sender, e);
            this.cbxGioiTinhFrom_Leave(sender, e);
            this.cbxGioiTinhTo_Leave(sender, e);
            if (bl==true)
            {
                SqlCommand cmdDonHang = new SqlCommand();

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error/n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    throw;
                }
                finally { connection.Close(); }
            }
        }
    }
}
