namespace App
{
    partial class frmChanceKhachHang
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
            this.lblSDT = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblCanCuoc = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblGioi = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(19, 180);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(104, 54);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(104, 21);
            this.cbxGioiTinh.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(104, 137);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(226, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(19, 139);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(104, 178);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(226, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // lblCanCuoc
            // 
            this.lblCanCuoc.AutoSize = true;
            this.lblCanCuoc.Location = new System.Drawing.Point(19, 98);
            this.lblCanCuoc.Name = "lblCanCuoc";
            this.lblCanCuoc.Size = new System.Drawing.Size(73, 13);
            this.lblCanCuoc.TabIndex = 7;
            this.lblCanCuoc.Text = "CCCD/CMND";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(104, 96);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(226, 20);
            this.txtCCCD.TabIndex = 6;
            // 
            // lblGioi
            // 
            this.lblGioi.AutoSize = true;
            this.lblGioi.Location = new System.Drawing.Point(19, 57);
            this.lblGioi.Name = "lblGioi";
            this.lblGioi.Size = new System.Drawing.Size(47, 13);
            this.lblGioi.TabIndex = 5;
            this.lblGioi.Text = "Giới tính";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ và tên";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(207, 240);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmChanceKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 295);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCanCuoc);
            this.Name = "frmChanceKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblCanCuoc;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblGioi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHuy;
    }
}