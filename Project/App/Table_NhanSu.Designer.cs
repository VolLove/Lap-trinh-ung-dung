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
            this.components = new System.ComponentModel.Container();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.grpNhanSu = new System.Windows.Forms.GroupBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLương = new System.Windows.Forms.Label();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioi = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCanCuoc = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.errMaNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNgaySinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCCCD = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNewCode = new System.Windows.Forms.Button();
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.grpNhanSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCCCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(359, 177);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(224, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(89, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.Location = new System.Drawing.Point(3, 16);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(792, 150);
            this.dgvDonHang.TabIndex = 4;
            this.dgvDonHang.TabStop = false;
            this.dgvDonHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellDoubleClick);
            // 
            // grpNhanSu
            // 
            this.grpNhanSu.Controls.Add(this.dgvDonHang);
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
            this.lblPhong.Location = new System.Drawing.Point(463, 286);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(71, 13);
            this.lblPhong.TabIndex = 56;
            this.lblPhong.Text = "Thuộc phòng";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(550, 238);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(191, 20);
            this.txtLuong.TabIndex = 55;
            this.txtLuong.Leave += new System.EventHandler(this.txtLuong_Leave);
            // 
            // lblLương
            // 
            this.lblLương.AutoSize = true;
            this.lblLương.Location = new System.Drawing.Point(463, 243);
            this.lblLương.Name = "lblLương";
            this.lblLương.Size = new System.Drawing.Size(37, 13);
            this.lblLương.TabIndex = 54;
            this.lblLương.Text = "Lương";
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgaySinh.Location = new System.Drawing.Point(130, 340);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(209, 20);
            this.dtmNgaySinh.TabIndex = 53;
            this.dtmNgaySinh.UseWaitCursor = true;
            this.dtmNgaySinh.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
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
            this.txtMaNhanVien.TabIndex = 0;
            this.txtMaNhanVien.Leave += new System.EventHandler(this.txtMaNhanVien_Leave);
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
            this.lblSDT.Location = new System.Drawing.Point(463, 329);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 47;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(550, 326);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 20);
            this.txtSDT.TabIndex = 43;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
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
            this.cboGioiTinh.Leave += new System.EventHandler(this.cboGioiTinh_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 282);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Họ và tên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(130, 409);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(226, 20);
            this.txtDiaChi.TabIndex = 45;
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 273);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 39;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
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
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
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
            this.cboPhongBan.Location = new System.Drawing.Point(550, 281);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(191, 21);
            this.cboPhongBan.TabIndex = 57;
            this.cboPhongBan.Leave += new System.EventHandler(this.cboPhongBan_Leave);
            // 
            // errMaNV
            // 
            this.errMaNV.ContainerControl = this;
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // errSex
            // 
            this.errSex.ContainerControl = this;
            // 
            // errNgaySinh
            // 
            this.errNgaySinh.ContainerControl = this;
            // 
            // errCCCD
            // 
            this.errCCCD.ContainerControl = this;
            // 
            // errDiaChi
            // 
            this.errDiaChi.ContainerControl = this;
            // 
            // errLuong
            // 
            this.errLuong.ContainerControl = this;
            // 
            // errMaPhong
            // 
            this.errMaPhong.ContainerControl = this;
            // 
            // btnNewCode
            // 
            this.btnNewCode.Location = new System.Drawing.Point(252, 241);
            this.btnNewCode.Name = "btnNewCode";
            this.btnNewCode.Size = new System.Drawing.Size(75, 23);
            this.btnNewCode.TabIndex = 58;
            this.btnNewCode.Text = "New code";
            this.btnNewCode.UseVisualStyleBackColor = true;
            this.btnNewCode.Click += new System.EventHandler(this.btnNewCode_Click);
            // 
            // errSDT
            // 
            this.errSDT.ContainerControl = this;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(484, 177);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTableNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnNewCode);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.lblLương);
            this.Controls.Add(this.dtmNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCanCuoc);
            this.Controls.Add(this.grpNhanSu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmTableNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.grpNhanSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCCCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.GroupBox grpNhanSu;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLương;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioi;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCanCuoc;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.ErrorProvider errMaNV;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errSex;
        private System.Windows.Forms.ErrorProvider errNgaySinh;
        private System.Windows.Forms.ErrorProvider errCCCD;
        private System.Windows.Forms.ErrorProvider errDiaChi;
        private System.Windows.Forms.ErrorProvider errLuong;
        private System.Windows.Forms.ErrorProvider errMaPhong;
        private System.Windows.Forms.Button btnNewCode;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
    }
}