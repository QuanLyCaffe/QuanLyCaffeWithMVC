namespace PresentationLayers
{
    partial class frmDSHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.drgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.MA_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_DDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_ND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATRIHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hóa Đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 52);
            this.panel2.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(681, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 39);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(811, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 39);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // drgvDSHoaDon
            // 
            this.drgvDSHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_HD,
            this.MA_KH,
            this.MA_DDB,
            this.MA_ND,
            this.GIATRIHD,
            this.NGAY_HD,
            this.NGAYTHANHTOAN});
            this.drgvDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgvDSHoaDon.Location = new System.Drawing.Point(0, 39);
            this.drgvDSHoaDon.Name = "drgvDSHoaDon";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drgvDSHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.drgvDSHoaDon.Size = new System.Drawing.Size(933, 343);
            this.drgvDSHoaDon.TabIndex = 3;
            // 
            // MA_HD
            // 
            this.MA_HD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MA_HD.DataPropertyName = "MA_HD";
            this.MA_HD.HeaderText = "Mã Hóa Đơn";
            this.MA_HD.Name = "MA_HD";
            this.MA_HD.ReadOnly = true;
            // 
            // MA_KH
            // 
            this.MA_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MA_KH.DataPropertyName = "MA_KH";
            this.MA_KH.HeaderText = "Mã Khách Hàng";
            this.MA_KH.Name = "MA_KH";
            this.MA_KH.ReadOnly = true;
            // 
            // MA_DDB
            // 
            this.MA_DDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MA_DDB.DataPropertyName = "MA_DDB";
            this.MA_DDB.HeaderText = "Mã Đơn Đặt Bàn";
            this.MA_DDB.Name = "MA_DDB";
            this.MA_DDB.ReadOnly = true;
            // 
            // MA_ND
            // 
            this.MA_ND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MA_ND.DataPropertyName = "MA_ND";
            this.MA_ND.HeaderText = "Mã Người Dùng";
            this.MA_ND.Name = "MA_ND";
            this.MA_ND.ReadOnly = true;
            // 
            // GIATRIHD
            // 
            this.GIATRIHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GIATRIHD.DataPropertyName = "GIATRIHD";
            this.GIATRIHD.HeaderText = "Gía Trị Hóa Đơn";
            this.GIATRIHD.Name = "GIATRIHD";
            this.GIATRIHD.ReadOnly = true;
            // 
            // NGAY_HD
            // 
            this.NGAY_HD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NGAY_HD.DataPropertyName = "NGAY_HD";
            this.NGAY_HD.HeaderText = "Ngày Hóa Đơn";
            this.NGAY_HD.Name = "NGAY_HD";
            this.NGAY_HD.ReadOnly = true;
            this.NGAY_HD.Width = 130;
            // 
            // NGAYTHANHTOAN
            // 
            this.NGAYTHANHTOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTHANHTOAN.DataPropertyName = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.HeaderText = "Ngày Thanh Toán";
            this.NGAYTHANHTOAN.Name = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.ReadOnly = true;
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 434);
            this.Controls.Add(this.drgvDSHoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.DSHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView drgvDSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_DDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_ND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATRIHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHANHTOAN;
        private System.Windows.Forms.Button btnXoa;
    }
}