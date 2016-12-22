namespace QLTiecCuoi
{
    partial class DSTiecCuoi
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
            this.btThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSTiecCuoi = new System.Windows.Forms.DataGridView();
            this.dgvMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaSanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLoaiCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayDatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSLBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTiecCuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(476, 8);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 28);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 51);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 67);
            this.label1.TabIndex = 21;
            this.label1.Text = "DANH SÁCH TIỆC CƯỚI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSTiecCuoi
            // 
            this.dgvDSTiecCuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTiecCuoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKhachHang,
            this.dgvMaSanh,
            this.dgvMaLoaiCa,
            this.dgvNgayDatBan,
            this.dgvSLBan});
            this.dgvDSTiecCuoi.Location = new System.Drawing.Point(0, 70);
            this.dgvDSTiecCuoi.Name = "dgvDSTiecCuoi";
            this.dgvDSTiecCuoi.Size = new System.Drawing.Size(591, 171);
            this.dgvDSTiecCuoi.TabIndex = 23;
            // 
            // dgvMaKhachHang
            // 
            this.dgvMaKhachHang.DataPropertyName = "MA_KH";
            this.dgvMaKhachHang.HeaderText = "Mã khách hàng";
            this.dgvMaKhachHang.Name = "dgvMaKhachHang";
            this.dgvMaKhachHang.Width = 150;
            // 
            // dgvMaSanh
            // 
            this.dgvMaSanh.DataPropertyName = "MA_SANH";
            this.dgvMaSanh.HeaderText = "Sảnh";
            this.dgvMaSanh.Name = "dgvMaSanh";
            // 
            // dgvMaLoaiCa
            // 
            this.dgvMaLoaiCa.DataPropertyName = "MA_LOAI_CA";
            this.dgvMaLoaiCa.HeaderText = "Ca";
            this.dgvMaLoaiCa.Name = "dgvMaLoaiCa";
            // 
            // dgvNgayDatBan
            // 
            this.dgvNgayDatBan.DataPropertyName = "NGAYDATBAN";
            this.dgvNgayDatBan.HeaderText = "Ngày";
            this.dgvNgayDatBan.Name = "dgvNgayDatBan";
            // 
            // dgvSLBan
            // 
            this.dgvSLBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSLBan.DataPropertyName = "SLBAN";
            this.dgvSLBan.HeaderText = "Số lượng bàn";
            this.dgvSLBan.Name = "dgvSLBan";
            // 
            // DSTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 291);
            this.Controls.Add(this.dgvDSTiecCuoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "DSTiecCuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSTiecCuoi";
            this.Load += new System.EventHandler(this.DSTiecCuoi_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTiecCuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSTiecCuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLoaiCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayDatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSLBan;
    }
}