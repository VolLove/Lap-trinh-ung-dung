namespace App
{
    partial class frmHome
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDonHang,
            this.mnuQuanLy,
            this.mnuTaiKhoan});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(735, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "Menu";
            // 
            // mnuDonHang
            // 
            this.mnuDonHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhsachDonHang,
            this.mnuNewDonHang});
            this.mnuDonHang.Name = "mnuDonHang";
            this.mnuDonHang.Size = new System.Drawing.Size(71, 20);
            this.mnuDonHang.Text = "Đơn hàng";
            // 
            // mnuDanhsachDonHang
            // 
            this.mnuDanhsachDonHang.Name = "mnuDanhsachDonHang";
            this.mnuDanhsachDonHang.Size = new System.Drawing.Size(183, 22);
            this.mnuDanhsachDonHang.Text = "Danh sách đơn hàng";
            this.mnuDanhsachDonHang.Click += new System.EventHandler(this.mnuDanhsachDonHang_Click);
            // 
            // mnuNewDonHang
            // 
            this.mnuNewDonHang.Name = "mnuNewDonHang";
            this.mnuNewDonHang.Size = new System.Drawing.Size(183, 22);
            this.mnuNewDonHang.Text = "New đơn hàng";
            this.mnuNewDonHang.Click += new System.EventHandler(this.mnuNewDonHang_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuPhongBan});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuNhanVien.Text = "Nhân sự\'";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(128, 22);
            this.mnuLogOut.Text = "Đăng xuất";
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // mnuPhongBan
            // 
            this.mnuPhongBan.Name = "mnuPhongBan";
            this.mnuPhongBan.Size = new System.Drawing.Size(180, 22);
            this.mnuPhongBan.Text = "Phòng ban";
            this.mnuPhongBan.Click += new System.EventHandler(this.mnuPhongBan_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 533);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmHome";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNewDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongBan;
    }
}