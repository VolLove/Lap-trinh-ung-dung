namespace GUI_App
{
    partial class frmTablePhongBan
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
            this.dvgPhongBan = new System.Windows.Forms.DataGridView();
            this.grpPhongBan = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboTenQL = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPhongBan)).BeginInit();
            this.grpPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgPhongBan
            // 
            this.dvgPhongBan.AllowUserToDeleteRows = false;
            this.dvgPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPhongBan.Location = new System.Drawing.Point(6, 19);
            this.dvgPhongBan.MultiSelect = false;
            this.dvgPhongBan.Name = "dvgPhongBan";
            this.dvgPhongBan.ReadOnly = true;
            this.dvgPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPhongBan.Size = new System.Drawing.Size(458, 401);
            this.dvgPhongBan.TabIndex = 9;
            // 
            // grpPhongBan
            // 
            this.grpPhongBan.Controls.Add(this.dvgPhongBan);
            this.grpPhongBan.Location = new System.Drawing.Point(12, 12);
            this.grpPhongBan.Name = "grpPhongBan";
            this.grpPhongBan.Size = new System.Drawing.Size(470, 426);
            this.grpPhongBan.TabIndex = 1;
            this.grpPhongBan.TabStop = false;
            this.grpPhongBan.Text = "Danh sách phòng ban";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(697, 276);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(597, 276);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(497, 276);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(509, 43);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(55, 13);
            this.lblMaPhong.TabIndex = 11;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(509, 85);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(59, 13);
            this.lblTenPhong.TabIndex = 11;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.Location = new System.Drawing.Point(513, 127);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(43, 13);
            this.lblQuanLy.TabIndex = 11;
            this.lblQuanLy.Text = "Quản lý";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(588, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 12;
            // 
            // cboTenQL
            // 
            this.cboTenQL.FormattingEnabled = true;
            this.cboTenQL.Location = new System.Drawing.Point(588, 123);
            this.cboTenQL.Name = "cboTenQL";
            this.cboTenQL.Size = new System.Drawing.Size(162, 21);
            this.cboTenQL.TabIndex = 13;
            // 
            // frmTablePhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTenQL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuanLy);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpPhongBan);
            this.Name = "frmTablePhongBan";
            this.Text = "Quản lý phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPhongBan)).EndInit();
            this.grpPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPhongBan;
        private System.Windows.Forms.GroupBox grpPhongBan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboTenQL;
    }
}