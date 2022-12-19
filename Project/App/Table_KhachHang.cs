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
        bus_KhachHang BUSKhachHang = new bus_KhachHang();
        bool isNotNull = false;
        public frmTableKhachHang()
        {
            InitializeComponent();
            load();
        }
        private void FrmClear()
        {
            txtCCCD.Clear();
            txtDiaChi.Clear();  
            txtName.Clear();
            txtSDT.Clear();
           
        }
        private void load()
        {
            dgvKhachHang.DataSource = BUSKhachHang.selectKhachHang();
            
            FrmClear();
        }

        private void ErrLoad(object sender, EventArgs e)
        {
            txtCCCD_Leave(sender, e);
            txtDiaChi_Leave(sender, e);
            txtName_Leave(sender, e);
            txtSDT_Leave(sender, e);
            cbxGioiTinh_Leave(sender, e);
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                errName.SetError(txtName, "Value is not null");
                isNotNull = false;
            }
            else { 
            errName.Clear();
                isNotNull= true;
            }
        }

        private void cbxGioiTinh_Leave(object sender, EventArgs e)
        {
            if (cbxGioiTinh.Text=="")
            {
                errSex.SetError(cbxGioiTinh, "Value is not null");
                isNotNull = false;
            }
            else { 
            errSex.Clear(); 
                isNotNull= true;
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
        private void btnLoadDGV_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isNotNull==true)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thêm khách hàng mới", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r==DialogResult.Yes)
                {
                    try
                    {
                        dto_KhachHang khachHang = new dto_KhachHang(txtCCCD.Text, cbxGioiTinh.Text, txtName.Text, txtDiaChi.Text, txtSDT.Text);
                        if (BUSKhachHang.insertKhachHang(khachHang) == true)
                        {
                            MessageBox.Show("Thông tin khách hàng đã được nhập!");
                            txtCCCD.Clear();
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu trùng!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu lỗi!");
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
            if (txtCCCD.Text!="")
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xoá thông tin khách hàng này?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        if (BUSKhachHang.deletKhachHang(txtCCCD.Text) == true)
                        {
                            MessageBox.Show("Thông tin khách hàng đã được xoá!");
                            load();

                        }
                        else
                        {
                            MessageBox.Show("Thông tin không tồn tại!");
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
                txtCCCD_Leave(sender,e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isNotNull == true)
            {
                DialogResult r = MessageBox.Show("Cập nhật dữ liệu khách hàng?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r==DialogResult.Yes)
                {
                    try
                    {
                        dto_KhachHang khachHang = new dto_KhachHang(txtCCCD.Text, cbxGioiTinh.Text, txtName.Text, txtDiaChi.Text, txtSDT.Text);
                        if (BUSKhachHang.updateKhachHang(khachHang) == true)
                        {
                            MessageBox.Show("Thông  tin khách hàng đã cập nhật!");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin không tồn tại!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Dữ liệu lỗi!");
                    }
                }
           

            }
            else
            {
               ErrLoad(sender,e);
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells[0].Value.ToString();
                cbxGioiTinh.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
               
                ErrLoad(sender,e);
            }
        }

    }
}
