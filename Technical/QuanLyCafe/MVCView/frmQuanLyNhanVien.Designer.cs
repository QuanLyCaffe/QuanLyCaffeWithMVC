namespace MVCView
{
    partial class frmQuanLyNhanVien
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
            this.topContain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.grbgioitinh = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txbLuong = new System.Windows.Forms.TextBox();
            this.lbLuong = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.bottomContain = new System.Windows.Forms.Panel();
            this.contain = new System.Windows.Forms.Panel();
            this.grdNhanVien = new System.Windows.Forms.ListView();
            this.topContain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grbgioitinh.SuspendLayout();
            this.contain.SuspendLayout();
            this.SuspendLayout();
            // 
            // topContain
            // 
            this.topContain.Controls.Add(this.panel4);
            this.topContain.Controls.Add(this.grpDetails);
            this.topContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.topContain.Location = new System.Drawing.Point(0, 0);
            this.topContain.Name = "topContain";
            this.topContain.Size = new System.Drawing.Size(717, 159);
            this.topContain.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.btnXoaNV);
            this.panel4.Controls.Add(this.btnThemNV);
            this.panel4.Controls.Add(this.btnUpdateNV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(533, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 159);
            this.panel4.TabIndex = 37;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(29, 49);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(140, 30);
            this.btnXoaNV.TabIndex = 35;
            this.btnXoaNV.Text = "&Xóa Nhân Viên";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(29, 13);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(140, 30);
            this.btnThemNV.TabIndex = 34;
            this.btnThemNV.Text = "&Thêm Nhân Viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNV.Location = new System.Drawing.Point(29, 102);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(140, 30);
            this.btnUpdateNV.TabIndex = 36;
            this.btnUpdateNV.Text = "&Sửa Thông Tin NV";
            this.btnUpdateNV.UseVisualStyleBackColor = false;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.dtpNgayBatDau);
            this.grpDetails.Controls.Add(this.dtpNgaySinh);
            this.grpDetails.Controls.Add(this.grbgioitinh);
            this.grpDetails.Controls.Add(this.lblNgayBatDau);
            this.grpDetails.Controls.Add(this.lblNgaySinh);
            this.grpDetails.Controls.Add(this.txbLuong);
            this.grpDetails.Controls.Add(this.lbLuong);
            this.grpDetails.Controls.Add(this.txtHoTen);
            this.grpDetails.Controls.Add(this.lblHoTen);
            this.grpDetails.Controls.Add(this.txtCMND);
            this.grpDetails.Controls.Add(this.lblCMND);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(0, 0);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(533, 159);
            this.grpDetails.TabIndex = 35;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Register new user :";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(368, 54);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(140, 20);
            this.dtpNgayBatDau.TabIndex = 30;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(368, 28);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(140, 20);
            this.dtpNgaySinh.TabIndex = 30;
            // 
            // grbgioitinh
            // 
            this.grbgioitinh.Controls.Add(this.rdNu);
            this.grbgioitinh.Controls.Add(this.rdNam);
            this.grbgioitinh.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbgioitinh.Location = new System.Drawing.Point(21, 87);
            this.grbgioitinh.Name = "grbgioitinh";
            this.grbgioitinh.Size = new System.Drawing.Size(227, 56);
            this.grbgioitinh.TabIndex = 29;
            this.grbgioitinh.TabStop = false;
            this.grbgioitinh.Text = "Giới tính";
            // 
            // rdNu
            // 
            this.rdNu.Location = new System.Drawing.Point(122, 16);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(67, 24);
            this.rdNu.TabIndex = 5;
            this.rdNu.Text = "Nữ";
            // 
            // rdNam
            // 
            this.rdNam.Location = new System.Drawing.Point(41, 16);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(53, 24);
            this.rdNam.TabIndex = 4;
            this.rdNam.Text = "Nam";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Location = new System.Drawing.Point(282, 54);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(80, 23);
            this.lblNgayBatDau.TabIndex = 28;
            this.lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(282, 28);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(80, 23);
            this.lblNgaySinh.TabIndex = 25;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // txbLuong
            // 
            this.txbLuong.Location = new System.Drawing.Point(368, 80);
            this.txbLuong.Name = "txbLuong";
            this.txbLuong.Size = new System.Drawing.Size(140, 20);
            this.txbLuong.TabIndex = 4;
            // 
            // lbLuong
            // 
            this.lbLuong.Location = new System.Drawing.Point(282, 80);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(63, 23);
            this.lbLuong.TabIndex = 23;
            this.lbLuong.Text = "Mức lương:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(78, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(18, 57);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 23);
            this.lblHoTen.TabIndex = 23;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(78, 28);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(170, 20);
            this.txtCMND.TabIndex = 1;
            // 
            // lblCMND
            // 
            this.lblCMND.Location = new System.Drawing.Point(18, 31);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(63, 23);
            this.lblCMND.TabIndex = 19;
            this.lblCMND.Text = "CMND:";
            // 
            // bottomContain
            // 
            this.bottomContain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottomContain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomContain.Location = new System.Drawing.Point(0, 375);
            this.bottomContain.Name = "bottomContain";
            this.bottomContain.Size = new System.Drawing.Size(717, 25);
            this.bottomContain.TabIndex = 1;
            // 
            // contain
            // 
            this.contain.Controls.Add(this.grdNhanVien);
            this.contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contain.Location = new System.Drawing.Point(0, 159);
            this.contain.Name = "contain";
            this.contain.Size = new System.Drawing.Size(717, 216);
            this.contain.TabIndex = 2;
            // 
            // grdNhanVien
            // 
            this.grdNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhanVien.FullRowSelect = true;
            this.grdNhanVien.GridLines = true;
            this.grdNhanVien.Location = new System.Drawing.Point(0, 0);
            this.grdNhanVien.Name = "grdNhanVien";
            this.grdNhanVien.Size = new System.Drawing.Size(717, 216);
            this.grdNhanVien.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdNhanVien.TabIndex = 36;
            this.grdNhanVien.UseCompatibleStateImageBehavior = false;
            this.grdNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 400);
            this.Controls.Add(this.contain);
            this.Controls.Add(this.bottomContain);
            this.Controls.Add(this.topContain);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.topContain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbgioitinh.ResumeLayout(false);
            this.contain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topContain;
        private System.Windows.Forms.Panel bottomContain;
        private System.Windows.Forms.Panel contain;
        internal System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grbgioitinh;
        internal System.Windows.Forms.RadioButton rdNu;
        internal System.Windows.Forms.RadioButton rdNam;
        internal System.Windows.Forms.Label lblNgayBatDau;
        internal System.Windows.Forms.Label lblNgaySinh;
        internal System.Windows.Forms.TextBox txtHoTen;
        internal System.Windows.Forms.Label lblHoTen;
        internal System.Windows.Forms.TextBox txtCMND;
        internal System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Button btnXoaNV;
        internal System.Windows.Forms.Button btnThemNV;
        internal System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        internal System.Windows.Forms.TextBox txbLuong;
        internal System.Windows.Forms.Label lbLuong;
        internal System.Windows.Forms.ListView grdNhanVien;
    }
}