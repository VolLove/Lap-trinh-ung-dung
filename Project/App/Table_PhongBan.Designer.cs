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
            this.components = new System.ComponentModel.Container();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.grpPhongBan = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.cboMaQL = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.errMaPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNamePhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNewCode = new System.Windows.Forms.Button();
            this.pROJECTDataSet = new GUI_App.PROJECTDataSet();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANTableAdapter = new GUI_App.PROJECTDataSetTableAdapters.PHONGBANTableAdapter();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.grpPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNamePhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToOrderColumns = true;
            this.dgvPhongBan.AutoGenerateColumns = false;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.maQLDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn});
            this.dgvPhongBan.DataSource = this.pHONGBANBindingSource;
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.Location = new System.Drawing.Point(3, 16);
            this.dgvPhongBan.MultiSelect = false;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(343, 407);
            this.dgvPhongBan.TabIndex = 9;
            this.dgvPhongBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellDoubleClick);
            // 
            // grpPhongBan
            // 
            this.grpPhongBan.Controls.Add(this.dgvPhongBan);
            this.grpPhongBan.Location = new System.Drawing.Point(12, 12);
            this.grpPhongBan.Name = "grpPhongBan";
            this.grpPhongBan.Size = new System.Drawing.Size(349, 426);
            this.grpPhongBan.TabIndex = 1;
            this.grpPhongBan.TabStop = false;
            this.grpPhongBan.Text = "Danh sách phòng ban";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(637, 210);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(537, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(437, 210);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(433, 56);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(55, 13);
            this.lblMaPhong.TabIndex = 11;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(433, 98);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(59, 13);
            this.lblTenPhong.TabIndex = 11;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.Location = new System.Drawing.Point(437, 140);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(43, 13);
            this.lblQuanLy.TabIndex = 11;
            this.lblQuanLy.Text = "Quản lý";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(512, 56);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 12;
            this.txtMaPhong.Leave += new System.EventHandler(this.txtMaPhong_Leave);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(512, 96);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(162, 20);
            this.txtTenPhong.TabIndex = 12;
            this.txtTenPhong.Leave += new System.EventHandler(this.txtTenPhong_Leave);
            // 
            // cboMaQL
            // 
            this.cboMaQL.FormattingEnabled = true;
            this.cboMaQL.Location = new System.Drawing.Point(512, 136);
            this.cboMaQL.Name = "cboMaQL";
            this.cboMaQL.Size = new System.Drawing.Size(162, 21);
            this.cboMaQL.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(589, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(466, 259);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // errMaPhong
            // 
            this.errMaPhong.ContainerControl = this;
            // 
            // errNamePhong
            // 
            this.errNamePhong.ContainerControl = this;
            // 
            // btnNewCode
            // 
            this.btnNewCode.Location = new System.Drawing.Point(637, 54);
            this.btnNewCode.Name = "btnNewCode";
            this.btnNewCode.Size = new System.Drawing.Size(75, 23);
            this.btnNewCode.TabIndex = 10;
            this.btnNewCode.Text = "New code";
            this.btnNewCode.UseVisualStyleBackColor = true;
            this.btnNewCode.Click += new System.EventHandler(this.btnNewCode_Click);
            // 
            // pROJECTDataSet
            // 
            this.pROJECTDataSet.DataSetName = "PROJECTDataSet";
            this.pROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.pROJECTDataSet;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            // 
            // maQLDataGridViewTextBoxColumn
            // 
            this.maQLDataGridViewTextBoxColumn.DataPropertyName = "MaQL";
            this.maQLDataGridViewTextBoxColumn.HeaderText = "MaQL";
            this.maQLDataGridViewTextBoxColumn.Name = "maQLDataGridViewTextBoxColumn";
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            // 
            // frmTablePhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboMaQL);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblQuanLy);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.btnNewCode);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpPhongBan);
            this.Name = "frmTablePhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.grpPhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNamePhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.GroupBox grpPhongBan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.ComboBox cboMaQL;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ErrorProvider errMaPhong;
        private System.Windows.Forms.Button btnNewCode;
        private System.Windows.Forms.ErrorProvider errNamePhong;
        private PROJECTDataSet pROJECTDataSet;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private PROJECTDataSetTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
    }
}