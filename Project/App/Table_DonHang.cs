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
        dto_DonHang donHang = new dto_DonHang();
        bus_NhanVien busNhanVien= new bus_NhanVien();
        bus_KhachHang busKhachHang = new bus_KhachHang();
        bool isNotNull = false;

        public frmTableDonHang()
        {
            InitializeComponent();
            Load();
        }
     
        private void frmClear()
        {
            txtCuoc.Clear();
            txtDiaChiGui.Clear();
            txtDiaChiNhan.Clear();
            txtKhoiLuong.Clear();
            txtKichThuoc.Clear();
            txtMieuTa.Clear();
            txtMaDonHang.Clear();
        }
        private void ErrLoad(object sender, EventArgs e) {
            cboMaNV_Leave(sender, e);
            txtMaDonHang_Leave(sender, e);
            cboCCCDGui_Leave(sender, e);
            cboCCCDNhan_Leave(sender, e);
            txtDiaChiGui_Leave(sender, e);
            txtDiaChiNhan_Leave(sender, e);
            txtCuoc_Leave(sender, e);
            txtKhoiLuong_Leave(sender, e);
            
        }
        private new void Load()
        {

            DataTable dataTableDonHang = busDonHang.selectDonHang();
           
            dgvDonHang.DataSource= dataTableDonHang;


            DataTable datatableKhachHang1 = busKhachHang.selectKhachHang();
            cboCCCDGui.DataSource = datatableKhachHang1;
            cboCCCDGui.DisplayMember= "CCCD";
            cboCCCDGui.ValueMember= "CCCD";

            DataTable datatableKhachHang2 = busKhachHang.selectKhachHang();
            cboCCCDNhan.DataSource = datatableKhachHang2;
            cboCCCDNhan.DisplayMember = "CCCD";
            cboCCCDNhan.ValueMember = "CCCD";

            DataTable dataTableNhanVien = busNhanVien.selectNhanVien();
            cboMaNV.DataSource = dataTableNhanVien;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
            frmClear();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewCode_Click(object sender, EventArgs e)
        {
            string maDH = donHang.getMaHDAuto();
            txtMaDonHang.Text = maDH;
            txtMaDonHang_Leave(sender, e);
        }

        private void btnLoadDGV_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isNotNull == true)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn thay đổi đơn hàng?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r==DialogResult.Yes)
                {
                    try
                    {
                        dto_DonHang NewdonHang = new dto_DonHang
                            (txtMaDonHang.Text, cboMaNV.Text, cboCCCDNhan.Text, cboCCCDGui.Text, txtDiaChiNhan.Text, txtDiaChiGui.Text,
                            txtMieuTa.Text, double.Parse(txtKhoiLuong.Text), double.Parse(txtKichThuoc.Text), double.Parse(txtCuoc.Text));

                        if (busDonHang.updateDonHang(NewdonHang) == true)
                        {
                            MessageBox.Show("Đơn hàng được tạo thành công");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Đơn hàng lỗi");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu nhập lỗi");
                    }
                }


            }
            else
            {
             ErrLoad(sender, e);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isNotNull == true)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn thêm đơn hàng?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r==DialogResult.Yes)
                {
                    try
                    {
                        dto_DonHang NewdonHang = new dto_DonHang
                    (txtMaDonHang.Text, cboMaNV.Text, cboCCCDNhan.Text, cboCCCDGui.Text, txtDiaChiNhan.Text, txtDiaChiGui.Text,
                    txtMieuTa.Text, double.Parse(txtKhoiLuong.Text), double.Parse(txtKichThuoc.Text), double.Parse(txtCuoc.Text));
                        if (busDonHang.insertDonHang(NewdonHang) == true)
                        {
                            MessageBox.Show("Đơn hàng cập nhật thành công");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu trùng");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu nhập lỗi");
                    }
                }
           

            }
            else
            {
             ErrLoad(sender, e);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDonHang.Text!="")
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc chắn xoá đơn hàng?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        if (busDonHang.deleteDonHang(txtMaDonHang.Text) == true)
                        {
                            MessageBox.Show("Đơn hàng đã được xoá");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Đon hàng không tồn tại");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu đơn hàng lỗi");
                    }
                }
            }
            else
            {
                txtMaDonHang_Leave(sender,e);
            }
       
        }


        private void txtKhoiLuong_Leave(object sender, EventArgs e)
        {
            if (txtKhoiLuong.Text == "")
            {
                errKhoiLuong.SetError(txtKhoiLuong, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errKhoiLuong.Clear();
                isNotNull = true;
            }
        }

        private void txtKichThuoc_Leave(object sender, EventArgs e)
        {
            if (txtKhoiLuong.Text == "")
            {
                errKichThuoc.SetError(txtKhoiLuong, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errKichThuoc.Clear();
                isNotNull = true;
            }
        }

        private void txtCuoc_Leave(object sender, EventArgs e)
        {
            if (txtCuoc.Text == "")
            {
                errCuocVanChuyen.SetError(txtCuoc, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errCuocVanChuyen.Clear();
                isNotNull = true;
            }
        }
        private void cboMaNV_Leave(object sender, EventArgs e)
        {
            if (cboMaNV.Text == "")
            {
                errMaNV.SetError(cboMaNV, "Value is not null");
                isNotNull = false;
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

        private void txtDiaChiGui_Leave(object sender, EventArgs e)
        {
            if (txtDiaChiGui.Text == "")
            {
                errDiaChiGui.SetError(txtDiaChiGui, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errDiaChiGui.Clear();
                isNotNull = true;
            }
        }
        private void txtMaDonHang_Leave(object sender, EventArgs e)
        {

            if (txtMaDonHang.Text == "")
            {
                errMaDonHang.SetError(txtMaDonHang, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errMaDonHang.Clear();
                isNotNull = true;
            }
        }
        private void txtDiaChiNhan_Leave(object sender, EventArgs e)
        {
            if (txtDiaChiNhan.Text == "")
            {
                errDiaChiNhan.SetError(txtDiaChiNhan, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errDiaChiNhan.Clear();
                isNotNull = true;
            }

        }

        private void dgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDonHang.Rows[e.RowIndex];
                txtMaDonHang.Text = row.Cells[0].Value.ToString();
                cboMaNV.Text = row.Cells[1].Value.ToString();
                cboCCCDNhan.Text = row.Cells[2].Value.ToString();
                cboCCCDGui.Text = row.Cells[3].Value.ToString();
                txtDiaChiNhan.Text = row.Cells[4].Value.ToString();
                txtDiaChiGui.Text = row.Cells[5].Value.ToString();
                txtMieuTa.Text = row.Cells[6].Value.ToString();
                txtKhoiLuong.Text = row.Cells[7].Value.ToString();
                txtKichThuoc.Text = row.Cells[8].Value.ToString();
                txtCuoc.Text = row.Cells[9].Value.ToString();

                ErrLoad(sender, e);
            }
        }
    }
}
