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
using DTO_App;

namespace App
{
    public partial class frmTableNhanSu : Form
    {
        bus_NhanVien busNhanVien = new bus_NhanVien();
        dto_NhanVien dtoNhanVien = new dto_NhanVien();
        bus_PhongBan busPhongBan = new bus_PhongBan();
        bool isNotNull = false;

        public frmTableNhanSu()
        {
            InitializeComponent();
            Load();
        }
        private new void Load()
        {
            dgvDonHang.DataSource = busNhanVien.selectNhanVien();

            DataTable dataTablePhongBan = busPhongBan.selectPhongBan();

            cboPhongBan.DataSource= dataTablePhongBan;
            cboPhongBan.ValueMember = "MaPhong";
            cboPhongBan.DisplayMember= "MaPhong";
            FrmClear();
        }

        private void FrmClear()
        {
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtLuong.Clear();
            txtMaNhanVien.Clear();
            txtName.Clear();
            txtSDT.Clear();
        }
        private void ErrLoad(object sender, EventArgs e)
        {
            txtDiaChi_Leave(sender, e);
            txtCCCD_Leave(sender, e);
            txtLuong_Leave(sender, e);
            txtMaNhanVien_Leave(sender, e);
            txtName_Leave(sender, e);
            txtSDT_Leave(sender, e);
            cboGioiTinh_Leave(sender, e);
            cboPhongBan_Leave(sender, e);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isNotNull==true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thêm thông tin nhân viên mới?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) 
                {
                    try
                    {
                        DateTime dateTime = DateTime.Parse(dtmNgaySinh.Text);
                        dto_NhanVien newNhanVien = new dto_NhanVien(txtMaNhanVien.Text, txtName.Text, dateTime, txtDiaChi.Text, txtCCCD.Text, txtSDT.Text, cboGioiTinh.Text, double.Parse(txtLuong.Text), cboPhongBan.Text);
                        if (busNhanVien.insertNhanVien(newNhanVien) == true)
                        {
                            MessageBox.Show("Nhân viên mới đã được cập nhật");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu trùng");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu nhập lỗi!");
                    }
                }
             
           
                
            }
            else
            {
              ErrLoad(sender, e);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isNotNull == true)
            {
                DialogResult r = MessageBox.Show("Bạn muốn lưu thay đổi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        DateTime dateTime = DateTime.Parse(dtmNgaySinh.Text);
                        dto_NhanVien newNhanVien = new dto_NhanVien
                            (txtMaNhanVien.Text, txtName.Text, dateTime, txtDiaChi.Text, txtCCCD.Text,
                            txtSDT.Text, cboGioiTinh.Text, double.Parse(txtLuong.Text), cboPhongBan.Text);
                        if (busNhanVien.updateKhachHang(newNhanVien)==true)
                        {
                            MessageBox.Show("Thông tin đã được cập nhật!");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin không thể cập nhật!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu nhập lỗi!");
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
            if (txtMaNhanVien.Text!="")
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn xoá hồ sơ nhân viên?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);   
                if(r == DialogResult.Yes)
                {
                    try
                    {
                        if (busNhanVien.deletKhachHang(txtMaNhanVien.Text) == true)
                        {
                            MessageBox.Show("Hồ sơ nhân viên đã được xoá!");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin nhân viên không tồn tại");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu lỗi");
                    }
                }
              
            }
            else
            {
                txtMaNhanVien_Leave(sender, e);
            }
        }



        private void btnNewCode_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = dtoNhanVien.getMaNVAuto();
            txtMaNhanVien_Leave(sender.GetType(), e);
        }


        private void txtMaNhanVien_Leave(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text=="")
            {
                errCCCD.SetError(txtMaNhanVien, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errCCCD.Clear();
                isNotNull = true;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                errName.SetError(txtName, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errName.Clear();
                isNotNull = true;
            }
        }

        private void cboGioiTinh_Leave(object sender, EventArgs e)
        {
            if (cboGioiTinh.Text == "")
            {
                errSex.SetError(cboGioiTinh, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errSex.Clear();
                isNotNull = true;
            }
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "")
            {
                errCCCD.SetError(txtCCCD, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errCCCD.Clear();
                isNotNull = true;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                errDiaChi.SetError(txtDiaChi, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errDiaChi.Clear();
                isNotNull = true;
            }
        }

        private void txtLuong_Leave(object sender, EventArgs e)
        {
            if (txtLuong.Text == "")
            {
                errLuong.SetError(txtLuong, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errLuong.Clear();
                isNotNull = true;
            }
        }

        private void cboPhongBan_Leave(object sender, EventArgs e)
        {
            if (cboPhongBan.Text == "")
            {
                errMaPhong.SetError(cboPhongBan, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errMaPhong.Clear();
                isNotNull = true;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                errSDT.SetError(txtSDT, "Value is not null");
                isNotNull = false;
            }
            else
            {
                errSDT.Clear();
                isNotNull = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDonHang.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                DateTime dateTime;
                try
                {
                    dateTime = DateTime.Parse(row.Cells[2].Value.ToString());
                    dtmNgaySinh.Value = dateTime;
                }
                catch (Exception)
                {
                }

                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtCCCD.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                cboGioiTinh.Text = row.Cells[6].Value.ToString();
                txtLuong.Text = row.Cells[7].Value.ToString();
                cboPhongBan.Text = row.Cells[8].Value.ToString();

              ErrLoad(sender, new EventArgs());
            }
        }

    }
}
