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

namespace GUI_App
{
    public partial class frmTablePhongBan : Form
    {
        bus_NhanVien busNhanVien = new bus_NhanVien();
        bus_PhongBan busPhongBan = new bus_PhongBan();
        dto_PhongBan dtoPhongBan = new dto_PhongBan();
        bool isNotNull = false;
        public frmTablePhongBan()
        {
            InitializeComponent();
            Load();
        }

        private new void Load()
        {
            dgvPhongBan.DataSource = busPhongBan.selectPhongBan();
            DataTable dataTableNhanVien = busNhanVien.selectNhanVien();
            cboMaQL.DataSource = dataTableNhanVien;
            cboMaQL.DisplayMember= "MaNV";
            cboMaQL.ValueMember= "MaNV";
            FrmClear();
        }
        private void ErrLoad(object sender, EventArgs e)
        {
            txtMaPhong_Leave(sender, e);
            txtTenPhong_Leave(sender, e);
        }
        private void FrmClear()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
        }

        private void txtMaPhong_Leave(object sender, EventArgs e)
        {
            if (txtMaPhong.Text=="")
            {
                errMaPhong.SetError(txtMaPhong, "Value is not null!");
                isNotNull=false;
            }
            else
            {
                errMaPhong.Clear();
                isNotNull=true;
            }
        }

        private void txtTenPhong_Leave(object sender, EventArgs e)
        {
            if (txtTenPhong.Text =="")
            {
                errNamePhong.SetError(txtTenPhong, "Value is not null!");
                isNotNull=false;
            }
            else
            {
                errNamePhong.Clear();
                isNotNull=true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isNotNull==true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thêm phòng ban mới ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        dto_PhongBan dtoPhongBan = new dto_PhongBan(txtMaPhong.Text, cboMaQL.Text, txtTenPhong.Text);
                        if (busPhongBan.insertPhongBan(dtoPhongBan) == true)
                        {
                            MessageBox.Show("Phòng ban mới được lập!");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi nhập dữ liệu!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi dữ liệu!");
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
                DialogResult r = MessageBox.Show("Bạn có muốn lưu thay đổi ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        dto_PhongBan dtoPhongBan = new dto_PhongBan(txtMaPhong.Text, cboMaQL.Text, txtTenPhong.Text);
                        if (busPhongBan.updatePhongBan(dtoPhongBan) == true)
                        {
                            MessageBox.Show("Thay đổi đã được cập nhật!");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Phòng không tồn tại!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi dữ liệu!");
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
            if (txtMaPhong.Text!="")
            {
                DialogResult r = MessageBox.Show("Bạn có muốn giải tán phòng?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        if (busPhongBan.deletKhachHang(txtMaPhong.Text) == true)
                        {
                            MessageBox.Show("Đã xoá phòng!");
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Mã phòng không tồn tại");
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Lỗi dự liệu!");
                    }
                }
            }
            else
            {
                txtMaPhong_Leave(sender, e);
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

        private void btnNewCode_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = dtoPhongBan.GetMaPhongAuto();
            txtMaPhong_Leave(sender,e);
        }

     

        private void dgvPhongBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row  = this.dgvPhongBan.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                cboMaQL.Text = row.Cells[1].Value.ToString();
                txtTenPhong.Text = row.Cells[2].Value.ToString();

                ErrLoad(sender, e);
            }
        }

    }
}
