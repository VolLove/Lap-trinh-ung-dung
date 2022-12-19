namespace GUI_App
{
    partial class frmSearchDonHang
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
            this.dONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTDataSet = new GUI_App.PROJECTDataSet();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dONHANGTableAdapter = new GUI_App.PROJECTDataSetTableAdapters.DONHANGTableAdapter();
            this.rdoGui = new System.Windows.Forms.RadioButton();
            this.rdoNhan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).BeginInit();
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
            this.dgvDonHang.Location = new System.Drawing.Point(12, 135);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(776, 303);
            this.dgvDonHang.TabIndex = 0;
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
            // dONHANGBindingSource
            // 
            this.dONHANGBindingSource.DataMember = "DONHANG";
            this.dONHANGBindingSource.DataSource = this.pROJECTDataSet;
            // 
            // pROJECTDataSet
            // 
            this.pROJECTDataSet.DataSetName = "PROJECTDataSet";
            this.pROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 106);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dONHANGTableAdapter
            // 
            this.dONHANGTableAdapter.ClearBeforeFill = true;
            // 
            // rdoGui
            // 
            this.rdoGui.AutoSize = true;
            this.rdoGui.Checked = true;
            this.rdoGui.Location = new System.Drawing.Point(72, 66);
            this.rdoGui.Name = "rdoGui";
            this.rdoGui.Size = new System.Drawing.Size(70, 17);
            this.rdoGui.TabIndex = 4;
            this.rdoGui.TabStop = true;
            this.rdoGui.Text = "Người gửi";
            this.rdoGui.UseVisualStyleBackColor = true;
            // 
            // rdoNhan
            // 
            this.rdoNhan.AutoSize = true;
            this.rdoNhan.Location = new System.Drawing.Point(240, 66);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new System.Drawing.Size(80, 17);
            this.rdoNhan.TabIndex = 4;
            this.rdoNhan.Text = "Người nhận";
            this.rdoNhan.UseVisualStyleBackColor = true;
            // 
            // frmSearchDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoNhan);
            this.Controls.Add(this.rdoGui);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDonHang);
            this.Name = "frmSearchDonHang";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private PROJECTDataSet pROJECTDataSet;
        private System.Windows.Forms.BindingSource dONHANGBindingSource;
        private PROJECTDataSetTableAdapters.DONHANGTableAdapter dONHANGTableAdapter;
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
        private System.Windows.Forms.RadioButton rdoGui;
        private System.Windows.Forms.RadioButton rdoNhan;
    }
}