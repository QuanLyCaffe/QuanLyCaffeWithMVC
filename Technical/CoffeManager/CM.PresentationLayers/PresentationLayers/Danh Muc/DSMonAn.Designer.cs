namespace QLTiecCuoi
{
    partial class DSMonAn
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
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhongLuu = new System.Windows.Forms.Button();
            this.dgvMa_MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMa_MonAn,
            this.dgvTenMonAn,
            this.dgvDonGia,
            this.dgvGhiChu});
            this.dgvDSMonAn.Location = new System.Drawing.Point(0, 70);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.Size = new System.Drawing.Size(644, 195);
            this.dgvDSMonAn.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 67);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANH SÁCH MÓN ĂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btKhongLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 51);
            this.panel2.TabIndex = 19;
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(204, 8);
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
            this.btLuu.Location = new System.Drawing.Point(312, 8);
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
            this.btThoat.Location = new System.Drawing.Point(528, 8);
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
            this.btKhongLuu.Location = new System.Drawing.Point(420, 8);
            this.btKhongLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btKhongLuu.Name = "btKhongLuu";
            this.btKhongLuu.Size = new System.Drawing.Size(100, 28);
            this.btKhongLuu.TabIndex = 0;
            this.btKhongLuu.Text = "Không Lưu";
            this.btKhongLuu.UseVisualStyleBackColor = true;
            this.btKhongLuu.Click += new System.EventHandler(this.btKhongLuu_Click);
            // 
            // dgvMa_MonAn
            // 
            this.dgvMa_MonAn.DataPropertyName = "MA_MONAN";
            this.dgvMa_MonAn.HeaderText = "Mã Món Ăn";
            this.dgvMa_MonAn.Name = "dgvMa_MonAn";
            // 
            // dgvTenMonAn
            // 
            this.dgvTenMonAn.DataPropertyName = "TENMONAN";
            this.dgvTenMonAn.HeaderText = "Tên Món Ăn";
            this.dgvTenMonAn.Name = "dgvTenMonAn";
            this.dgvTenMonAn.Width = 200;
            // 
            // dgvDonGia
            // 
            this.dgvDonGia.DataPropertyName = "DONGIA";
            this.dgvDonGia.HeaderText = "Đơn Giá";
            this.dgvDonGia.Name = "dgvDonGia";
            // 
            // dgvGhiChu
            // 
            this.dgvGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGhiChu.DataPropertyName = "GHICHU";
            this.dgvGhiChu.HeaderText = "Ghi Chú";
            this.dgvGhiChu.Name = "dgvGhiChu";
            // 
            // DSMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSMonAn);
            this.Name = "DSMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách món ăn";
            this.Load += new System.EventHandler(this.DSMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhongLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMa_MonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGhiChu;
    }
}