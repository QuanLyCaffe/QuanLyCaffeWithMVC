namespace QLTiecCuoi
{
    partial class KhangHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.lbLoaiSanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhongLuu = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDateTimePickerColumn1 = new QLTC.CommonLayer.DataGridViewDateTimePickerColumn();
            this.dataGridViewDateTimePickerColumn2 = new QLTC.CommonLayer.DataGridViewDateTimePickerColumn();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiaChiCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiaChiCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDTChuRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDTCoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCMNRChuRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCMNDCoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinhChuRe = new QLTC.CommonLayer.DataGridViewDateTimePickerColumn();
            this.dgvNgaySinhCoDau = new QLTC.CommonLayer.DataGridViewDateTimePickerColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKH,
            this.dgvTenCR,
            this.dgvTenCD,
            this.dgvDiaChiCR,
            this.dgvDiaChiCD,
            this.dgvSDTChuRe,
            this.dgvSDTCoDau,
            this.dgvCMNRChuRe,
            this.dgvCMNDCoDau,
            this.dgvNgaySinhChuRe,
            this.dgvNgaySinhCoDau});
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 70);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(1143, 204);
            this.dgvKhachHang.TabIndex = 17;
            // 
            // lbLoaiSanh
            // 
            this.lbLoaiSanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSanh.Location = new System.Drawing.Point(0, 0);
            this.lbLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiSanh.Name = "lbLoaiSanh";
            this.lbLoaiSanh.Size = new System.Drawing.Size(1143, 67);
            this.lbLoaiSanh.TabIndex = 20;
            this.lbLoaiSanh.Text = "DANH SÁCH KHÁCH HÀNG";
            this.lbLoaiSanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btKhongLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 51);
            this.panel2.TabIndex = 21;
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(703, 8);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLuu.Location = new System.Drawing.Point(811, 8);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 28);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(1027, 8);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 28);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btKhongLuu
            // 
            this.btKhongLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btKhongLuu.Location = new System.Drawing.Point(919, 8);
            this.btKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btKhongLuu.Name = "btKhongLuu";
            this.btKhongLuu.Size = new System.Drawing.Size(100, 28);
            this.btKhongLuu.TabIndex = 0;
            this.btKhongLuu.Text = "Không Lưu";
            this.btKhongLuu.UseVisualStyleBackColor = true;
            this.btKhongLuu.Click += new System.EventHandler(this.btKhongLuu_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MA_KH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_CR";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Chú Rể";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN_CD";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Cô Dâu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI_CR";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa Chỉ Chú Rể";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI_CD";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa Chỉ Cô Dâu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SDT_CR";
            this.dataGridViewTextBoxColumn6.HeaderText = "SĐT Chú Rể";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SDT_CD";
            this.dataGridViewTextBoxColumn7.HeaderText = "SĐT Cô Dâu";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CMND_CR";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số CMND Chú Rể";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CMND_CD";
            this.dataGridViewTextBoxColumn9.HeaderText = "Số CMND Cô Dâu";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewDateTimePickerColumn1
            // 
            this.dataGridViewDateTimePickerColumn1.DataPropertyName = "NGAYSINH_CR";
            this.dataGridViewDateTimePickerColumn1.HeaderText = " Ngày Sinh Chú Rể";
            this.dataGridViewDateTimePickerColumn1.Name = "dataGridViewDateTimePickerColumn1";
            this.dataGridViewDateTimePickerColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDateTimePickerColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewDateTimePickerColumn2
            // 
            this.dataGridViewDateTimePickerColumn2.DataPropertyName = "NGAYSINH_CD";
            this.dataGridViewDateTimePickerColumn2.HeaderText = "Ngày Sinh Cô Dâu";
            this.dataGridViewDateTimePickerColumn2.Name = "dataGridViewDateTimePickerColumn2";
            this.dataGridViewDateTimePickerColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDateTimePickerColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.DataPropertyName = "MA_KH";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvMaKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaKH.HeaderText = "Mã Khách Hàng";
            this.dgvMaKH.Name = "dgvMaKH";
            // 
            // dgvTenCR
            // 
            this.dgvTenCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTenCR.DataPropertyName = "TEN_CR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvTenCR.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTenCR.HeaderText = "Tên Chú Rể";
            this.dgvTenCR.Name = "dgvTenCR";
            // 
            // dgvTenCD
            // 
            this.dgvTenCD.DataPropertyName = "TEN_CD";
            this.dgvTenCD.HeaderText = "Tên Cô Dâu";
            this.dgvTenCD.Name = "dgvTenCD";
            // 
            // dgvDiaChiCR
            // 
            this.dgvDiaChiCR.DataPropertyName = "DIACHI_CR";
            this.dgvDiaChiCR.HeaderText = "Địa Chỉ Chú Rể";
            this.dgvDiaChiCR.Name = "dgvDiaChiCR";
            // 
            // dgvDiaChiCD
            // 
            this.dgvDiaChiCD.DataPropertyName = "DIACHI_CD";
            this.dgvDiaChiCD.HeaderText = "Địa Chỉ Cô Dâu";
            this.dgvDiaChiCD.Name = "dgvDiaChiCD";
            // 
            // dgvSDTChuRe
            // 
            this.dgvSDTChuRe.DataPropertyName = "SDT_CR";
            this.dgvSDTChuRe.HeaderText = "SĐT Chú Rể";
            this.dgvSDTChuRe.Name = "dgvSDTChuRe";
            // 
            // dgvSDTCoDau
            // 
            this.dgvSDTCoDau.DataPropertyName = "SDT_CD";
            this.dgvSDTCoDau.HeaderText = "SĐT Cô Dâu";
            this.dgvSDTCoDau.Name = "dgvSDTCoDau";
            // 
            // dgvCMNRChuRe
            // 
            this.dgvCMNRChuRe.DataPropertyName = "CMND_CR";
            this.dgvCMNRChuRe.HeaderText = "Số CMND Chú Rể";
            this.dgvCMNRChuRe.Name = "dgvCMNRChuRe";
            // 
            // dgvCMNDCoDau
            // 
            this.dgvCMNDCoDau.DataPropertyName = "CMND_CD";
            this.dgvCMNDCoDau.HeaderText = "Số CMND Cô Dâu";
            this.dgvCMNDCoDau.Name = "dgvCMNDCoDau";
            // 
            // dgvNgaySinhChuRe
            // 
            this.dgvNgaySinhChuRe.DataPropertyName = "NGAYSINH_CR";
            this.dgvNgaySinhChuRe.HeaderText = " Ngày Sinh Chú Rể";
            this.dgvNgaySinhChuRe.Name = "dgvNgaySinhChuRe";
            this.dgvNgaySinhChuRe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgaySinhChuRe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvNgaySinhCoDau
            // 
            this.dgvNgaySinhCoDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNgaySinhCoDau.DataPropertyName = "NGAYSINH_CD";
            this.dgvNgaySinhCoDau.HeaderText = "Ngày Sinh Cô Dâu";
            this.dgvNgaySinhCoDau.Name = "dgvNgaySinhCoDau";
            this.dgvNgaySinhCoDau.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgaySinhCoDau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KhangHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbLoaiSanh);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "KhangHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhangHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label lbLoaiSanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhongLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private QLTC.CommonLayer.DataGridViewDateTimePickerColumn dataGridViewDateTimePickerColumn1;
        private QLTC.CommonLayer.DataGridViewDateTimePickerColumn dataGridViewDateTimePickerColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiaChiCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiaChiCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDTChuRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDTCoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCMNRChuRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCMNDCoDau;
        private QLTC.CommonLayer.DataGridViewDateTimePickerColumn dgvNgaySinhChuRe;
        private QLTC.CommonLayer.DataGridViewDateTimePickerColumn dgvNgaySinhCoDau;
    }
}