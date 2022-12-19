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
            this.components = new System.ComponentModel.Container();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.errMaDonHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errKhoiLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errKichThuoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCuocVanChuyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMieuTa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCCCDGui = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCCCDNhan = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDiachiGui = new System.Windows.Forms.Label();
            this.llblDiaChiNhan = new System.Windows.Forms.Label();
            this.txtDiaChiNhan = new System.Windows.Forms.TextBox();
            this.txtDiaChiGui = new System.Windows.Forms.TextBox();
            this.btnNewCode = new System.Windows.Forms.Button();
            this.errDiaChiGui = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDiaChiNhan = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoadDGV = new System.Windows.Forms.Button();
            this.pROJECTDataSet = new GUI_App.PROJECTDataSet();
            this.dONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONHANGTableAdapter = new GUI_App.PROJECTDataSetTableAdapters.DONHANGTableAdapter();
            this.maDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDGuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiGuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mieuTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoiLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kichThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKhoiLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKichThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCuocVanChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMieuTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCCCDGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCCCDNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChiGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChiNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToOrderColumns = true;
            this.dgvDonHang.AutoGenerateColumns = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDHDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.cCCDGuiDataGridViewTextBoxColumn,
            this.cCCDNhanDataGridViewTextBoxColumn,
            this.diaChiGuiDataGridViewTextBoxColumn,
            this.diaChiNhanDataGridViewTextBoxColumn,
            this.mieuTaDataGridViewTextBoxColumn,
            this.khoiLuongDataGridViewTextBoxColumn,
            this.kichThuocDataGridViewTextBoxColumn,
            this.cuocDataGridViewTextBoxColumn});
            this.dgvDonHang.DataSource = this.dONHANGBindingSource;
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.Location = new System.Drawing.Point(3, 16);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(785, 187);
            this.dgvDonHang.TabIndex = 99;
            this.dgvDonHang.TabStop = false;
            this.dgvDonHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellDoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(91, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(299, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(199, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.grpDanhSach.Controls.Add(this.dgvDonHang);
            this.grpDanhSach.Location = new System.Drawing.Point(3, 12);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(791, 206);
            this.grpDanhSach.TabIndex = 4;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách đơn hàng";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(162, 253);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(127, 20);
            this.txtMaDonHang.TabIndex = 0;
            this.txtMaDonHang.Leave += new System.EventHandler(this.txtMaDonHang_Leave);
            // 
            // txtMieuTa
            // 
            this.txtMieuTa.Location = new System.Drawing.Point(517, 346);
            this.txtMieuTa.Multiline = true;
            this.txtMieuTa.Name = "txtMieuTa";
            this.txtMieuTa.Size = new System.Drawing.Size(243, 89);
            this.txtMieuTa.TabIndex = 9;
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
            this.txtCuoc.TabIndex = 8;
            this.txtCuoc.Leave += new System.EventHandler(this.txtCuoc_Leave);
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
            this.txtKichThuoc.TabIndex = 7;
            this.txtKichThuoc.Leave += new System.EventHandler(this.txtKichThuoc_Leave);
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
            this.txtKhoiLuong.TabIndex = 6;
            this.txtKhoiLuong.Leave += new System.EventHandler(this.txtKhoiLuong_Leave);
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
            this.lblMNV.Location = new System.Drawing.Point(50, 288);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(95, 13);
            this.lblMNV.TabIndex = 0;
            this.lblMNV.Text = "Người lập hoá đơn";
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Location = new System.Drawing.Point(50, 260);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(71, 13);
            this.lblMaDonHang.TabIndex = 1;
            this.lblMaDonHang.Text = "Mã đơn hàng";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(162, 281);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(143, 21);
            this.cboMaNV.TabIndex = 1;
            this.cboMaNV.Leave += new System.EventHandler(this.cboMaNV_Leave);
            // 
            // cboCCCDNhan
            // 
            this.cboCCCDNhan.FormattingEnabled = true;
            this.cboCCCDNhan.Location = new System.Drawing.Point(162, 339);
            this.cboCCCDNhan.Name = "cboCCCDNhan";
            this.cboCCCDNhan.Size = new System.Drawing.Size(143, 21);
            this.cboCCCDNhan.TabIndex = 3;
            this.cboCCCDNhan.Leave += new System.EventHandler(this.cboCCCDNhan_Leave);
            // 
            // cboCCCDGui
            // 
            this.cboCCCDGui.FormattingEnabled = true;
            this.cboCCCDGui.Location = new System.Drawing.Point(162, 310);
            this.cboCCCDGui.Name = "cboCCCDGui";
            this.cboCCCDGui.Size = new System.Drawing.Size(143, 21);
            this.cboCCCDGui.TabIndex = 2;
            this.cboCCCDGui.Leave += new System.EventHandler(this.cboCCCDGui_Leave);
            // 
            // lblCanCuoc
            // 
            this.lblCanCuoc.AutoSize = true;
            this.lblCanCuoc.Location = new System.Drawing.Point(50, 316);
            this.lblCanCuoc.Name = "lblCanCuoc";
            this.lblCanCuoc.Size = new System.Drawing.Size(95, 13);
            this.lblCanCuoc.TabIndex = 15;
            this.lblCanCuoc.Text = "CCCD/CMND(Gửi)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CCCD/CMND(Nhận)";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(431, 224);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(664, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errMaDonHang
            // 
            this.errMaDonHang.ContainerControl = this;
            // 
            // errKhoiLuong
            // 
            this.errKhoiLuong.ContainerControl = this;
            // 
            // errKichThuoc
            // 
            this.errKichThuoc.ContainerControl = this;
            // 
            // errCuocVanChuyen
            // 
            this.errCuocVanChuyen.ContainerControl = this;
            // 
            // errMieuTa
            // 
            this.errMieuTa.ContainerControl = this;
            // 
            // errMaNV
            // 
            this.errMaNV.ContainerControl = this;
            // 
            // errCCCDGui
            // 
            this.errCCCDGui.ContainerControl = this;
            // 
            // errCCCDNhan
            // 
            this.errCCCDNhan.ContainerControl = this;
            // 
            // lblDiachiGui
            // 
            this.lblDiachiGui.AutoSize = true;
            this.lblDiachiGui.Location = new System.Drawing.Point(50, 372);
            this.lblDiachiGui.Name = "lblDiachiGui";
            this.lblDiachiGui.Size = new System.Drawing.Size(57, 13);
            this.lblDiachiGui.TabIndex = 1;
            this.lblDiachiGui.Text = "Địa chỉ gửi";
            // 
            // llblDiaChiNhan
            // 
            this.llblDiaChiNhan.AutoSize = true;
            this.llblDiaChiNhan.Location = new System.Drawing.Point(50, 400);
            this.llblDiaChiNhan.Name = "llblDiaChiNhan";
            this.llblDiaChiNhan.Size = new System.Drawing.Size(67, 13);
            this.llblDiaChiNhan.TabIndex = 16;
            this.llblDiaChiNhan.Text = "Địa chỉ nhận";
            // 
            // txtDiaChiNhan
            // 
            this.txtDiaChiNhan.Location = new System.Drawing.Point(162, 396);
            this.txtDiaChiNhan.Name = "txtDiaChiNhan";
            this.txtDiaChiNhan.Size = new System.Drawing.Size(212, 20);
            this.txtDiaChiNhan.TabIndex = 5;
            this.txtDiaChiNhan.Leave += new System.EventHandler(this.txtDiaChiNhan_Leave);
            // 
            // txtDiaChiGui
            // 
            this.txtDiaChiGui.Location = new System.Drawing.Point(162, 368);
            this.txtDiaChiGui.Name = "txtDiaChiGui";
            this.txtDiaChiGui.Size = new System.Drawing.Size(212, 20);
            this.txtDiaChiGui.TabIndex = 4;
            this.txtDiaChiGui.Leave += new System.EventHandler(this.txtDiaChiGui_Leave);
            // 
            // btnNewCode
            // 
            this.btnNewCode.Location = new System.Drawing.Point(299, 253);
            this.btnNewCode.Name = "btnNewCode";
            this.btnNewCode.Size = new System.Drawing.Size(75, 23);
            this.btnNewCode.TabIndex = 19;
            this.btnNewCode.TabStop = false;
            this.btnNewCode.Text = "New";
            this.btnNewCode.UseVisualStyleBackColor = true;
            this.btnNewCode.Click += new System.EventHandler(this.btnNewCode_Click);
            // 
            // errDiaChiGui
            // 
            this.errDiaChiGui.ContainerControl = this;
            // 
            // errDiaChiNhan
            // 
            this.errDiaChiNhan.ContainerControl = this;
            // 
            // btnLoadDGV
            // 
            this.btnLoadDGV.Location = new System.Drawing.Point(559, 224);
            this.btnLoadDGV.Name = "btnLoadDGV";
            this.btnLoadDGV.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDGV.TabIndex = 14;
            this.btnLoadDGV.Text = "Refresh";
            this.btnLoadDGV.UseVisualStyleBackColor = true;
            this.btnLoadDGV.Click += new System.EventHandler(this.btnLoadDGV_Click);
            // 
            // pROJECTDataSet
            // 
            this.pROJECTDataSet.DataSetName = "PROJECTDataSet";
            this.pROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dONHANGBindingSource
            // 
            this.dONHANGBindingSource.DataMember = "DONHANG";
            this.dONHANGBindingSource.DataSource = this.pROJECTDataSet;
            // 
            // dONHANGTableAdapter
            // 
            this.dONHANGTableAdapter.ClearBeforeFill = true;
            // 
            // maDHDataGridViewTextBoxColumn
            // 
            this.maDHDataGridViewTextBoxColumn.DataPropertyName = "MaDH";
            this.maDHDataGridViewTextBoxColumn.HeaderText = "MaDH";
            this.maDHDataGridViewTextBoxColumn.Name = "maDHDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // cCCDGuiDataGridViewTextBoxColumn
            // 
            this.cCCDGuiDataGridViewTextBoxColumn.DataPropertyName = "CCCDGui";
            this.cCCDGuiDataGridViewTextBoxColumn.HeaderText = "CCCDGui";
            this.cCCDGuiDataGridViewTextBoxColumn.Name = "cCCDGuiDataGridViewTextBoxColumn";
            // 
            // cCCDNhanDataGridViewTextBoxColumn
            // 
            this.cCCDNhanDataGridViewTextBoxColumn.DataPropertyName = "CCCDNhan";
            this.cCCDNhanDataGridViewTextBoxColumn.HeaderText = "CCCDNhan";
            this.cCCDNhanDataGridViewTextBoxColumn.Name = "cCCDNhanDataGridViewTextBoxColumn";
            // 
            // diaChiGuiDataGridViewTextBoxColumn
            // 
            this.diaChiGuiDataGridViewTextBoxColumn.DataPropertyName = "DiaChiGui";
            this.diaChiGuiDataGridViewTextBoxColumn.HeaderText = "DiaChiGui";
            this.diaChiGuiDataGridViewTextBoxColumn.Name = "diaChiGuiDataGridViewTextBoxColumn";
            // 
            // diaChiNhanDataGridViewTextBoxColumn
            // 
            this.diaChiNhanDataGridViewTextBoxColumn.DataPropertyName = "DiaChiNhan";
            this.diaChiNhanDataGridViewTextBoxColumn.HeaderText = "DiaChiNhan";
            this.diaChiNhanDataGridViewTextBoxColumn.Name = "diaChiNhanDataGridViewTextBoxColumn";
            // 
            // mieuTaDataGridViewTextBoxColumn
            // 
            this.mieuTaDataGridViewTextBoxColumn.DataPropertyName = "MieuTa";
            this.mieuTaDataGridViewTextBoxColumn.HeaderText = "MieuTa";
            this.mieuTaDataGridViewTextBoxColumn.Name = "mieuTaDataGridViewTextBoxColumn";
            // 
            // khoiLuongDataGridViewTextBoxColumn
            // 
            this.khoiLuongDataGridViewTextBoxColumn.DataPropertyName = "KhoiLuong";
            this.khoiLuongDataGridViewTextBoxColumn.HeaderText = "KhoiLuong";
            this.khoiLuongDataGridViewTextBoxColumn.Name = "khoiLuongDataGridViewTextBoxColumn";
            // 
            // kichThuocDataGridViewTextBoxColumn
            // 
            this.kichThuocDataGridViewTextBoxColumn.DataPropertyName = "KichThuoc";
            this.kichThuocDataGridViewTextBoxColumn.HeaderText = "KichThuoc";
            this.kichThuocDataGridViewTextBoxColumn.Name = "kichThuocDataGridViewTextBoxColumn";
            // 
            // cuocDataGridViewTextBoxColumn
            // 
            this.cuocDataGridViewTextBoxColumn.DataPropertyName = "Cuoc";
            this.cuocDataGridViewTextBoxColumn.HeaderText = "Cuoc";
            this.cuocDataGridViewTextBoxColumn.Name = "cuocDataGridViewTextBoxColumn";
            // 
            // frmTableDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.btnNewCode);
            this.Controls.Add(this.txtDiaChiGui);
            this.Controls.Add(this.txtDiaChiNhan);
            this.Controls.Add(this.llblDiaChiNhan);
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
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadDGV);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKhoiLuong);
            this.Controls.Add(this.lblKhoiLuong);
            this.Controls.Add(this.lblDiachiGui);
            this.Controls.Add(this.lblMaDonHang);
            this.Controls.Add(this.lblMNV);
            this.Name = "frmTableDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMaDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKhoiLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errKichThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCuocVanChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMieuTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCCCDGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCCCDNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChiGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChiNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errMaDonHang;
        private System.Windows.Forms.ErrorProvider errKhoiLuong;
        private System.Windows.Forms.ErrorProvider errKichThuoc;
        private System.Windows.Forms.ErrorProvider errCuocVanChuyen;
        private System.Windows.Forms.ErrorProvider errMieuTa;
        private System.Windows.Forms.ErrorProvider errMaNV;
        private System.Windows.Forms.ErrorProvider errCCCDGui;
        private System.Windows.Forms.ErrorProvider errCCCDNhan;
        private System.Windows.Forms.TextBox txtDiaChiGui;
        private System.Windows.Forms.TextBox txtDiaChiNhan;
        private System.Windows.Forms.Label llblDiaChiNhan;
        private System.Windows.Forms.Label lblDiachiGui;
        private System.Windows.Forms.Button btnNewCode;
        private System.Windows.Forms.ErrorProvider errDiaChiGui;
        private System.Windows.Forms.ErrorProvider errDiaChiNhan;
        private System.Windows.Forms.Button btnLoadDGV;
        private GUI_App.PROJECTDataSet pROJECTDataSet;
        private System.Windows.Forms.BindingSource dONHANGBindingSource;
        private GUI_App.PROJECTDataSetTableAdapters.DONHANGTableAdapter dONHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDGuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiGuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mieuTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoiLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kichThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuocDataGridViewTextBoxColumn;
    }
}