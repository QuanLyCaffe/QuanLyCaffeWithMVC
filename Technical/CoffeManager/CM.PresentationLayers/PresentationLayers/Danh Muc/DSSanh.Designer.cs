namespace QLTiecCuoi
{
    partial class dSSanh
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
            this.dgvDSSanh = new System.Windows.Forms.DataGridView();
            this.lbLoaiSanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhongLuu = new System.Windows.Forms.Button();
            this.dgvMaSanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLuongBanToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGiaBanToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSanh
            // 
            this.dgvDSSanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSanh,
            this.dgvTenSanh,
            this.dgvSoLuongBanToiDa,
            this.dgvDonGiaBanToiThieu,
            this.dgvGhiChu});
            this.dgvDSSanh.Location = new System.Drawing.Point(-3, 70);
            this.dgvDSSanh.Name = "dgvDSSanh";
            this.dgvDSSanh.Size = new System.Drawing.Size(641, 146);
            this.dgvDSSanh.TabIndex = 17;
            // 
            // lbLoaiSanh
            // 
            this.lbLoaiSanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSanh.Location = new System.Drawing.Point(0, 0);
            this.lbLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiSanh.Name = "lbLoaiSanh";
            this.lbLoaiSanh.Size = new System.Drawing.Size(638, 67);
            this.lbLoaiSanh.TabIndex = 19;
            this.lbLoaiSanh.Text = "DANH SÁCH SẢNH";
            this.lbLoaiSanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btKhongLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 51);
            this.panel2.TabIndex = 20;
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(198, 8);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btLuu
            // 
            this.btLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLuu.Location = new System.Drawing.Point(306, 8);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 28);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click_1);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(522, 8);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 28);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btKhongLuu
            // 
            this.btKhongLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btKhongLuu.Location = new System.Drawing.Point(414, 8);
            this.btKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btKhongLuu.Name = "btKhongLuu";
            this.btKhongLuu.Size = new System.Drawing.Size(100, 28);
            this.btKhongLuu.TabIndex = 0;
            this.btKhongLuu.Text = "Không Lưu";
            this.btKhongLuu.UseVisualStyleBackColor = true;
            this.btKhongLuu.Click += new System.EventHandler(this.btKhongLuu_Click_1);
            // 
            // dgvMaSanh
            // 
            this.dgvMaSanh.DataPropertyName = "MA_SANH";
            this.dgvMaSanh.HeaderText = "Mã Sảnh";
            this.dgvMaSanh.Name = "dgvMaSanh";
            // 
            // dgvTenSanh
            // 
            this.dgvTenSanh.DataPropertyName = "TENSANH";
            this.dgvTenSanh.HeaderText = "Tên Sảnh";
            this.dgvTenSanh.Name = "dgvTenSanh";
            this.dgvTenSanh.Width = 200;
            // 
            // dgvSoLuongBanToiDa
            // 
            this.dgvSoLuongBanToiDa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSoLuongBanToiDa.DataPropertyName = "SLBANTOIDA";
            this.dgvSoLuongBanToiDa.HeaderText = "Số Lượng Bàn Tối Đa";
            this.dgvSoLuongBanToiDa.Name = "dgvSoLuongBanToiDa";
            // 
            // dgvDonGiaBanToiThieu
            // 
            this.dgvDonGiaBanToiThieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDonGiaBanToiThieu.DataPropertyName = "DONGIABANTOITHIEU";
            this.dgvDonGiaBanToiThieu.HeaderText = "Đơn giá bàn tối thiểu";
            this.dgvDonGiaBanToiThieu.Name = "dgvDonGiaBanToiThieu";
            // 
            // dgvGhiChu
            // 
            this.dgvGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGhiChu.DataPropertyName = "GHICHU";
            this.dgvGhiChu.HeaderText = "Ghi Chú";
            this.dgvGhiChu.Name = "dgvGhiChu";
            // 
            // dSSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 266);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbLoaiSanh);
            this.Controls.Add(this.dgvDSSanh);
            this.Name = "dSSanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sảnh";
            this.Load += new System.EventHandler(this.dSSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSanh;
        private System.Windows.Forms.Label lbLoaiSanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhongLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuongBanToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonGiaBanToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGhiChu;

    }
}