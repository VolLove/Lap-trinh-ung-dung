namespace App
{
    partial class frmTableNhanSu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dvgDonHang = new System.Windows.Forms.DataGridView();
            this.grpNhanSu = new System.Windows.Forms.GroupBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLương = new System.Windows.Forms.Label();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNameTen = new System.Windows.Forms.TextBox();
            this.lblNameTen = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNameHo = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioi = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCanCuoc = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDonHang)).BeginInit();
            this.grpNhanSu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(489, 177);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(219, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dvgDonHang
            // 
            this.dvgDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDonHang.Location = new System.Drawing.Point(6, 19);
            this.dvgDonHang.Name = "dvgDonHang";
            this.dvgDonHang.ReadOnly = true;
            this.dvgDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDonHang.Size = new System.Drawing.Size(792, 144);
            this.dvgDonHang.TabIndex = 4;
            // 
            // grpNhanSu
            // 
            this.grpNhanSu.Controls.Add(this.dvgDonHang);
            this.grpNhanSu.Location = new System.Drawing.Point(1, 2);
            this.grpNhanSu.Name = "grpNhanSu";
            this.grpNhanSu.Size = new System.Drawing.Size(798, 169);
            this.grpNhanSu.TabIndex = 8;
            this.grpNhanSu.TabStop = false;
            this.grpNhanSu.Text = "Danh sách nhân viên";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(474, 319);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(71, 13);
            this.lblPhong.TabIndex = 56;
            this.lblPhong.Text = "Thuộc phòng";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(561, 271);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(191, 20);
            this.txtLuong.TabIndex = 55;
            // 
            // lblLương
            // 
            this.lblLương.AutoSize = true;
            this.lblLương.Location = new System.Drawing.Point(474, 276);
            this.lblLương.Name = "lblLương";
            this.lblLương.Size = new System.Drawing.Size(37, 13);
            this.lblLương.TabIndex = 54;
            this.lblLương.Text = "Lương";
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.Location = new System.Drawing.Point(130, 340);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(226, 20);
            this.dtmNgaySinh.TabIndex = 53;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(29, 346);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 52;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(130, 244);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(104, 20);
            this.txtMaNhanVien.TabIndex = 51;
            // 
            // txtNameTen
            // 
            this.txtNameTen.Location = new System.Drawing.Point(279, 273);
            this.txtNameTen.Name = "txtNameTen";
            this.txtNameTen.Size = new System.Drawing.Size(103, 20);
            this.txtNameTen.TabIndex = 50;
            // 
            // lblNameTen
            // 
            this.lblNameTen.AutoSize = true;
            this.lblNameTen.Location = new System.Drawing.Point(247, 276);
            this.lblNameTen.Name = "lblNameTen";
            this.lblNameTen.Size = new System.Drawing.Size(26, 13);
            this.lblNameTen.TabIndex = 49;
            this.lblNameTen.Text = "Tên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(29, 250);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(72, 13);
            this.lblMaNhanVien.TabIndex = 48;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(474, 362);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 47;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(561, 359);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 20);
            this.txtSDT.TabIndex = 43;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(130, 306);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(87, 21);
            this.cboGioiTinh.TabIndex = 46;
            // 
            // lblNameHo
            // 
            this.lblNameHo.AutoSize = true;
            this.lblNameHo.Location = new System.Drawing.Point(29, 282);
            this.lblNameHo.Name = "lblNameHo";
            this.lblNameHo.Size = new System.Drawing.Size(21, 13);
            this.lblNameHo.TabIndex = 38;
            this.lblNameHo.Text = "Họ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(130, 409);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(226, 20);
            this.txtDiaChi.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 273);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 20);
            this.txtName.TabIndex = 39;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(29, 410);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 44;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblGioi
            // 
            this.lblGioi.AutoSize = true;
            this.lblGioi.Location = new System.Drawing.Point(29, 314);
            this.lblGioi.Name = "lblGioi";
            this.lblGioi.Size = new System.Drawing.Size(47, 13);
            this.lblGioi.TabIndex = 40;
            this.lblGioi.Text = "Giới tính";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(130, 378);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(226, 20);
            this.txtCCCD.TabIndex = 41;
            // 
            // lblCanCuoc
            // 
            this.lblCanCuoc.AutoSize = true;
            this.lblCanCuoc.Location = new System.Drawing.Point(29, 378);
            this.lblCanCuoc.Name = "lblCanCuoc";
            this.lblCanCuoc.Size = new System.Drawing.Size(73, 13);
            this.lblCanCuoc.TabIndex = 42;
            this.lblCanCuoc.Text = "CCCD/CMND";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(561, 314);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(191, 21);
            this.cboPhongBan.TabIndex = 57;
            // 
            // frmTableNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.lblLương);
            this.Controls.Add(this.dtmNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtNameTen);
            this.Controls.Add(this.lblNameTen);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblNameHo);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCanCuoc);
            this.Controls.Add(this.grpNhanSu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmTableNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDonHang)).EndInit();
            this.grpNhanSu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dvgDonHang;
        private System.Windows.Forms.GroupBox grpNhanSu;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLương;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtNameTen;
        private System.Windows.Forms.Label lblNameTen;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblNameHo;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioi;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCanCuoc;
        private System.Windows.Forms.ComboBox cboPhongBan;
    }
}