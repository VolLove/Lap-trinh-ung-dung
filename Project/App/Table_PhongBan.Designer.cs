namespace App
{
    partial class frmTable_PhongBan
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgPhongBan)).BeginInit();
            this.grpPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgPhongBan
            // 
            this.dvgPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPhongBan.Location = new System.Drawing.Point(6, 19);
            this.dvgPhongBan.Name = "dvgPhongBan";
            this.dvgPhongBan.ReadOnly = true;
            this.dvgPhongBan.Size = new System.Drawing.Size(781, 348);
            this.dvgPhongBan.TabIndex = 4;
            // 
            // grpPhongBan
            // 
            this.grpPhongBan.Controls.Add(this.dvgPhongBan);
            this.grpPhongBan.Location = new System.Drawing.Point(3, 0);
            this.grpPhongBan.Name = "grpPhongBan";
            this.grpPhongBan.Size = new System.Drawing.Size(793, 373);
            this.grpPhongBan.TabIndex = 12;
            this.grpPhongBan.TabStop = false;
            this.grpPhongBan.Text = "Danh Sách Phòng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(463, 391);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(328, 391);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(193, 391);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmTable_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPhongBan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmTable_PhongBan";
            this.Text = "Phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPhongBan)).EndInit();
            this.grpPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPhongBan;
        private System.Windows.Forms.GroupBox grpPhongBan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}