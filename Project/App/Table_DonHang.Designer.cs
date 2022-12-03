namespace App
{
    partial class frmTableDonHang
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
            this.dvgDonHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtMieuTa = new System.Windows.Forms.TextBox();
            this.lblMieuTa = new System.Windows.Forms.Label();
            this.txtCuoc = new System.Windows.Forms.TextBox();
            this.lblCuoc = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.txtKhoiLuong = new System.Windows.Forms.TextBox();
            this.lblKhoiLuong = new System.Windows.Forms.Label();
            this.lblMNV = new System.Windows.Forms.Label();
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboCCCDNhan = new System.Windows.Forms.ComboBox();
            this.cboCCCDGui = new System.Windows.Forms.ComboBox();
            this.lblCanCuoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDonHang)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgDonHang
            // 
            this.dvgDonHang.AllowUserToDeleteRows = false;
            this.dvgDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDonHang.Location = new System.Drawing.Point(6, 19);
            this.dvgDonHang.Name = "dvgDonHang";
            this.dvgDonHang.ReadOnly = true;
            this.dvgDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDonHang.Size = new System.Drawing.Size(779, 184);
            this.dvgDonHang.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(221, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(491, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dvgDonHang);
            this.grpDanhSach.Location = new System.Drawing.Point(3, 9);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(791, 209);
            this.grpDanhSach.TabIndex = 4;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách đơn hàng";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(162, 253);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(121, 20);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // txtMieuTa
            // 
            this.txtMieuTa.Location = new System.Drawing.Point(517, 346);
            this.txtMieuTa.Multiline = true;
            this.txtMieuTa.Name = "txtMieuTa";
            this.txtMieuTa.Size = new System.Drawing.Size(243, 89);
            this.txtMieuTa.TabIndex = 6;
            // 
            // lblMieuTa
            // 
            this.lblMieuTa.AutoSize = true;
            this.lblMieuTa.Location = new System.Drawing.Point(404, 346);
            this.lblMieuTa.Name = "lblMieuTa";
            this.lblMieuTa.Size = new System.Drawing.Size(42, 13);
            this.lblMieuTa.TabIndex = 11;
            this.lblMieuTa.Text = "Miêu tả";
            // 
            // txtCuoc
            // 
            this.txtCuoc.Location = new System.Drawing.Point(517, 313);
            this.txtCuoc.Name = "txtCuoc";
            this.txtCuoc.Size = new System.Drawing.Size(165, 20);
            this.txtCuoc.TabIndex = 5;
            // 
            // lblCuoc
            // 
            this.lblCuoc.AutoSize = true;
            this.lblCuoc.Location = new System.Drawing.Point(404, 316);
            this.lblCuoc.Name = "lblCuoc";
            this.lblCuoc.Size = new System.Drawing.Size(91, 13);
            this.lblCuoc.TabIndex = 9;
            this.lblCuoc.Text = "Cước vận chuyển";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(517, 283);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(165, 20);
            this.txtKichThuoc.TabIndex = 4;
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.Location = new System.Drawing.Point(404, 286);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(80, 13);
            this.lblKichThuoc.TabIndex = 6;
            this.lblKichThuoc.Text = "Kích thước(m3)";
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.Location = new System.Drawing.Point(517, 253);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Size = new System.Drawing.Size(165, 20);
            this.txtKhoiLuong.TabIndex = 3;
            // 
            // lblKhoiLuong
            // 
            this.lblKhoiLuong.AutoSize = true;
            this.lblKhoiLuong.Location = new System.Drawing.Point(404, 256);
            this.lblKhoiLuong.Name = "lblKhoiLuong";
            this.lblKhoiLuong.Size = new System.Drawing.Size(78, 13);
            this.lblKhoiLuong.TabIndex = 3;
            this.lblKhoiLuong.Text = "Khối lượng(KG)";
            // 
            // lblMNV
            // 
            this.lblMNV.AutoSize = true;
            this.lblMNV.Location = new System.Drawing.Point(37, 295);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(95, 13);
            this.lblMNV.TabIndex = 0;
            this.lblMNV.Text = "Người lập hoá đơn";
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Location = new System.Drawing.Point(37, 256);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(71, 13);
            this.lblMaDonHang.TabIndex = 1;
            this.lblMaDonHang.Text = "Mã đơn hàng";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(162, 292);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 21);
            this.cboMaNV.TabIndex = 12;
            // 
            // cboCCCDNhan
            // 
            this.cboCCCDNhan.FormattingEnabled = true;
            this.cboCCCDNhan.Location = new System.Drawing.Point(162, 372);
            this.cboCCCDNhan.Name = "cboCCCDNhan";
            this.cboCCCDNhan.Size = new System.Drawing.Size(121, 21);
            this.cboCCCDNhan.TabIndex = 13;
            // 
            // cboCCCDGui
            // 
            this.cboCCCDGui.FormattingEnabled = true;
            this.cboCCCDGui.Location = new System.Drawing.Point(162, 332);
            this.cboCCCDGui.Name = "cboCCCDGui";
            this.cboCCCDGui.Size = new System.Drawing.Size(121, 21);
            this.cboCCCDGui.TabIndex = 14;
            // 
            // lblCanCuoc
            // 
            this.lblCanCuoc.AutoSize = true;
            this.lblCanCuoc.Location = new System.Drawing.Point(37, 334);
            this.lblCanCuoc.Name = "lblCanCuoc";
            this.lblCanCuoc.Size = new System.Drawing.Size(95, 13);
            this.lblCanCuoc.TabIndex = 15;
            this.lblCanCuoc.Text = "CCCD/CMND(Gửi)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CCCD/CMND(Nhận)";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(619, 224);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmTableDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCanCuoc);
            this.Controls.Add(this.cboCCCDGui);
            this.Controls.Add(this.cboCCCDNhan);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.txtMieuTa);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.lblMieuTa);
            this.Controls.Add(this.txtCuoc);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.lblCuoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblKichThuoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKhoiLuong);
            this.Controls.Add(this.lblKhoiLuong);
            this.Controls.Add(this.lblMaDonHang);
            this.Controls.Add(this.lblMNV);
            this.Name = "frmTableDonHang";
            this.Text = "Danh sách đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDonHang)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDonHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtMieuTa;
        private System.Windows.Forms.Label lblMieuTa;
        private System.Windows.Forms.TextBox txtCuoc;
        private System.Windows.Forms.Label lblCuoc;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.TextBox txtKhoiLuong;
        private System.Windows.Forms.Label lblKhoiLuong;
        private System.Windows.Forms.Label lblMNV;
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboCCCDNhan;
        private System.Windows.Forms.ComboBox cboCCCDGui;
        private System.Windows.Forms.Label lblCanCuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
    }
}