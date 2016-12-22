namespace QLTiecCuoi
{
    partial class NguoiDung
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
            this.lbLoaiSanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhongLuu = new System.Windows.Forms.Button();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.dgvMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1MaLoaiNguoiDung = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvTenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinh = new QLTC.CommonLayer.DataGridViewDateTimePickerColumn();
            this.dgvNgayVaoLam = new QLTC.CommonLayer.DataGridViewDateTimePickerColumn();
            this.dgvTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLoaiSanh
            // 
            this.lbLoaiSanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSanh.Location = new System.Drawing.Point(0, 0);
            this.lbLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiSanh.Name = "lbLoaiSanh";
            this.lbLoaiSanh.Size = new System.Drawing.Size(1065, 67);
            this.lbLoaiSanh.TabIndex = 20;
            this.lbLoaiSanh.Text = "DANH SÁCH NGƯỜI DÙNG";
            this.lbLoaiSanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btKhongLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 51);
            this.panel2.TabIndex = 21;
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(625, 8);
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
            this.btLuu.Location = new System.Drawing.Point(733, 8);
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
            this.btThoat.Location = new System.Drawing.Point(949, 8);
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
            this.btKhongLuu.Location = new System.Drawing.Point(841, 8);
            this.btKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btKhongLuu.Name = "btKhongLuu";
            this.btKhongLuu.Size = new System.Drawing.Size(100, 28);
            this.btKhongLuu.TabIndex = 0;
            this.btKhongLuu.Text = "Không Lưu";
            this.btKhongLuu.UseVisualStyleBackColor = true;
            this.btKhongLuu.Click += new System.EventHandler(this.btKhongLuu_Click);
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToOrderColumns = true;
            this.dgvNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaNguoiDung,
            this.dgv1MaLoaiNguoiDung,
            this.dgvTenNguoiDung,
            this.dgvDiaChi,
            this.dgvSoDienThoai,
            this.dgvSoCMND,
            this.dgvNgaySinh,
            this.dgvNgayVaoLam,
            this.dgvTenDangNhap,
            this.dgvMatKhau});
            this.dgvNguoiDung.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNguoiDung.Location = new System.Drawing.Point(0, 67);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.Size = new System.Drawing.Size(1065, 196);
            this.dgvNguoiDung.TabIndex = 22;
            // 
            // dgvMaNguoiDung
            // 
            this.dgvMaNguoiDung.DataPropertyName = "MA_ND";
            this.dgvMaNguoiDung.HeaderText = "Mã Người Dùng";
            this.dgvMaNguoiDung.Name = "dgvMaNguoiDung";
            // 
            // dgv1MaLoaiNguoiDung
            // 
            this.dgv1MaLoaiNguoiDung.HeaderText = "Mã Loại Người Dùng";
            this.dgv1MaLoaiNguoiDung.Name = "dgv1MaLoaiNguoiDung";
            this.dgv1MaLoaiNguoiDung.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvTenNguoiDung
            // 
            this.dgvTenNguoiDung.DataPropertyName = "TEN_ND";
            this.dgvTenNguoiDung.HeaderText = "Tên Người Dùng";
            this.dgvTenNguoiDung.Name = "dgvTenNguoiDung";
            this.dgvTenNguoiDung.Width = 150;
            // 
            // dgvDiaChi
            // 
            this.dgvDiaChi.DataPropertyName = "DIACHI";
            this.dgvDiaChi.HeaderText = "Địa Chỉ";
            this.dgvDiaChi.Name = "dgvDiaChi";
            this.dgvDiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvSoDienThoai
            // 
            this.dgvSoDienThoai.DataPropertyName = "SODIENTHOAI";
            this.dgvSoDienThoai.HeaderText = "Số Điện Thoại";
            this.dgvSoDienThoai.Name = "dgvSoDienThoai";
            // 
            // dgvSoCMND
            // 
            this.dgvSoCMND.DataPropertyName = "CMND";
            this.dgvSoCMND.HeaderText = "Số CMND";
            this.dgvSoCMND.Name = "dgvSoCMND";
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.DataPropertyName = "NGAYSINH";
            this.dgvNgaySinh.HeaderText = "Ngày Sinh";
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            this.dgvNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvNgayVaoLam
            // 
            this.dgvNgayVaoLam.DataPropertyName = "NGAYVAOLAM";
            this.dgvNgayVaoLam.HeaderText = "Ngày Vào Làm";
            this.dgvNgayVaoLam.Name = "dgvNgayVaoLam";
            this.dgvNgayVaoLam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgayVaoLam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvTenDangNhap
            // 
            this.dgvTenDangNhap.DataPropertyName = "TENDANGNHAP";
            this.dgvTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.dgvTenDangNhap.Name = "dgvTenDangNhap";
            // 
            // dgvMatKhau
            // 
            this.dgvMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMatKhau.DataPropertyName = "PASS";
            this.dgvMatKhau.HeaderText = "Mật Khẩu";
            this.dgvMatKhau.Name = "dgvMatKhau";
            // 
            // NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 314);
            this.Controls.Add(this.dgvNguoiDung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbLoaiSanh);
            this.Name = "NguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.NguoiDung_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiSanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhongLuu;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNguoiDung;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv1MaLoaiNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoCMND;
        private QLTC.CommonLayer.DataGridViewDateTimePickerColumn dgvNgaySinh;
        private QLTC.CommonLayer.DataGridViewDateTimePickerColumn dgvNgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMatKhau;

    }
}