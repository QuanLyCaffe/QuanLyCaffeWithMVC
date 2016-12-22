namespace QLTiecCuoi
{
    partial class LoaiNguoiDung
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
            this.dgvLoaiNguoiDung = new System.Windows.Forms.DataGridView();
            this.lbLoaiSanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhongLuu = new System.Windows.Forms.Button();
            this.dgvMa_LND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenLoaiNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNguoiDung)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiNguoiDung
            // 
            this.dgvLoaiNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMa_LND,
            this.dgvTenLoaiNguoiDung,
            this.dgvMoTa});
            this.dgvLoaiNguoiDung.Location = new System.Drawing.Point(0, 70);
            this.dgvLoaiNguoiDung.Name = "dgvLoaiNguoiDung";
            this.dgvLoaiNguoiDung.Size = new System.Drawing.Size(570, 174);
            this.dgvLoaiNguoiDung.TabIndex = 17;
            // 
            // lbLoaiSanh
            // 
            this.lbLoaiSanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSanh.Location = new System.Drawing.Point(0, 0);
            this.lbLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiSanh.Name = "lbLoaiSanh";
            this.lbLoaiSanh.Size = new System.Drawing.Size(570, 67);
            this.lbLoaiSanh.TabIndex = 19;
            this.lbLoaiSanh.Text = "LOẠI SẢNH";
            this.lbLoaiSanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btKhongLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 243);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 51);
            this.panel2.TabIndex = 20;
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(130, 8);
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
            this.btLuu.Location = new System.Drawing.Point(238, 8);
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
            this.btThoat.Location = new System.Drawing.Point(454, 8);
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
            this.btKhongLuu.Location = new System.Drawing.Point(346, 8);
            this.btKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btKhongLuu.Name = "btKhongLuu";
            this.btKhongLuu.Size = new System.Drawing.Size(100, 28);
            this.btKhongLuu.TabIndex = 0;
            this.btKhongLuu.Text = "Không Lưu";
            this.btKhongLuu.UseVisualStyleBackColor = true;
            this.btKhongLuu.Click += new System.EventHandler(this.btKhongLuu_Click);
            // 
            // dgvMa_LND
            // 
            this.dgvMa_LND.DataPropertyName = "MA_LND";
            this.dgvMa_LND.HeaderText = "Mã Loại Người Dùng";
            this.dgvMa_LND.Name = "dgvMa_LND";
            this.dgvMa_LND.Width = 130;
            // 
            // dgvTenLoaiNguoiDung
            // 
            this.dgvTenLoaiNguoiDung.DataPropertyName = "TENLOAINGUOIDUNG";
            this.dgvTenLoaiNguoiDung.HeaderText = "Tên Loại Người Dùng";
            this.dgvTenLoaiNguoiDung.Name = "dgvTenLoaiNguoiDung";
            this.dgvTenLoaiNguoiDung.Width = 200;
            // 
            // dgvMoTa
            // 
            this.dgvMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMoTa.DataPropertyName = "MOTA";
            this.dgvMoTa.HeaderText = "Mô Tả";
            this.dgvMoTa.Name = "dgvMoTa";
            // 
            // LoaiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 294);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbLoaiSanh);
            this.Controls.Add(this.dgvLoaiNguoiDung);
            this.MaximizeBox = false;
            this.Name = "LoaiNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Người Dùng";
            this.Load += new System.EventHandler(this.LoaiNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNguoiDung)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiNguoiDung;
        private System.Windows.Forms.Label lbLoaiSanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhongLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMa_LND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenLoaiNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMoTa;
    }
}