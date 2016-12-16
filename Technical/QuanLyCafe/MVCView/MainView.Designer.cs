namespace MVCView
{
    partial class MainView
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
            this.bottomContain = new System.Windows.Forms.Panel();
            this.lblStatusLogin = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lgpContainButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnQLBan = new System.Windows.Forms.Button();
            this.btnQLNguyenVatLieu = new System.Windows.Forms.Button();
            this.btnQuanLyNV = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_Item = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNguyênVậtLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậnViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.bottomContain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lgpContainButton.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomContain
            // 
            this.bottomContain.BackColor = System.Drawing.Color.DimGray;
            this.bottomContain.Controls.Add(this.lblStatusLogin);
            this.bottomContain.Controls.Add(this.lblTitle);
            this.bottomContain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomContain.Location = new System.Drawing.Point(0, 670);
            this.bottomContain.Margin = new System.Windows.Forms.Padding(4);
            this.bottomContain.Name = "bottomContain";
            this.bottomContain.Size = new System.Drawing.Size(968, 31);
            this.bottomContain.TabIndex = 1;
            // 
            // lblStatusLogin
            // 
            this.lblStatusLogin.AutoSize = true;
            this.lblStatusLogin.Location = new System.Drawing.Point(4, 9);
            this.lblStatusLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusLogin.Name = "lblStatusLogin";
            this.lblStatusLogin.Size = new System.Drawing.Size(269, 17);
            this.lblStatusLogin.TabIndex = 1;
            this.lblStatusLogin.Text = "Vui lòng đăng nhập để sử dụng hệ thống!";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(790, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hệ Thống Quản Lý Coffee";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lgpContainButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 642);
            this.panel2.TabIndex = 2;
            // 
            // lgpContainButton
            // 
            this.lgpContainButton.AutoSize = true;
            this.lgpContainButton.BackColor = System.Drawing.Color.Transparent;
            this.lgpContainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lgpContainButton.Controls.Add(this.btnAdmin);
            this.lgpContainButton.Controls.Add(this.btnQLBan);
            this.lgpContainButton.Controls.Add(this.btnQLNguyenVatLieu);
            this.lgpContainButton.Controls.Add(this.btnQuanLyNV);
            this.lgpContainButton.Controls.Add(this.btnBaoCao);
            this.lgpContainButton.Controls.Add(this.btnExit);
            this.lgpContainButton.Controls.Add(this.btn_Item);
            this.lgpContainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lgpContainButton.Location = new System.Drawing.Point(0, 0);
            this.lgpContainButton.Margin = new System.Windows.Forms.Padding(4);
            this.lgpContainButton.Name = "lgpContainButton";
            this.lgpContainButton.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lgpContainButton.Size = new System.Drawing.Size(968, 642);
            this.lgpContainButton.TabIndex = 2;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.BackgroundImage = global::MVCView.Properties.Resources.system;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.Location = new System.Drawing.Point(17, 16);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(267, 185);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Quản lý hệ thống";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnQLBan
            // 
            this.btnQLBan.BackColor = System.Drawing.Color.White;
            this.btnQLBan.BackgroundImage = global::MVCView.Properties.Resources.table;
            this.btnQLBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLBan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQLBan.Location = new System.Drawing.Point(292, 16);
            this.btnQLBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLBan.Name = "btnQLBan";
            this.btnQLBan.Size = new System.Drawing.Size(267, 185);
            this.btnQLBan.TabIndex = 0;
            this.btnQLBan.Text = "Quản Lý Bàn";
            this.btnQLBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLBan.UseVisualStyleBackColor = false;
            this.btnQLBan.Click += new System.EventHandler(this.btnQLBan_Click);
            // 
            // btnQLNguyenVatLieu
            // 
            this.btnQLNguyenVatLieu.BackColor = System.Drawing.Color.White;
            this.btnQLNguyenVatLieu.BackgroundImage = global::MVCView.Properties.Resources.Matiral;
            this.btnQLNguyenVatLieu.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNguyenVatLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQLNguyenVatLieu.Location = new System.Drawing.Point(567, 16);
            this.btnQLNguyenVatLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLNguyenVatLieu.Name = "btnQLNguyenVatLieu";
            this.btnQLNguyenVatLieu.Size = new System.Drawing.Size(267, 185);
            this.btnQLNguyenVatLieu.TabIndex = 0;
            this.btnQLNguyenVatLieu.Text = "Quản lý nguyên, vật liệu";
            this.btnQLNguyenVatLieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLNguyenVatLieu.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyNV
            // 
            this.btnQuanLyNV.BackColor = System.Drawing.Color.White;
            this.btnQuanLyNV.BackgroundImage = global::MVCView.Properties.Resources.user;
            this.btnQuanLyNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNV.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuanLyNV.Location = new System.Drawing.Point(17, 209);
            this.btnQuanLyNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyNV.Name = "btnQuanLyNV";
            this.btnQuanLyNV.Size = new System.Drawing.Size(267, 185);
            this.btnQuanLyNV.TabIndex = 0;
            this.btnQuanLyNV.Text = "Quản lý nhân viên ";
            this.btnQuanLyNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyNV.UseVisualStyleBackColor = false;
            this.btnQuanLyNV.Click += new System.EventHandler(this.btnQuanLyNV_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.White;
            this.btnBaoCao.BackgroundImage = global::MVCView.Properties.Resources.report;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBaoCao.Location = new System.Drawing.Point(292, 209);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(267, 185);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo, thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::MVCView.Properties.Resources.shutdown;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(567, 209);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(267, 185);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.BackColor = System.Drawing.Color.White;
            this.btn_Item.BackgroundImage = global::MVCView.Properties.Resources.shutdown;
            this.btn_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Item.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Item.Location = new System.Drawing.Point(17, 402);
            this.btn_Item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(267, 185);
            this.btn_Item.TabIndex = 1;
            this.btn_Item.Text = "Mặt hàng";
            this.btn_Item.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Item.UseVisualStyleBackColor = false;
            this.btn_Item.Click += new System.EventHandler(this.btn_Items_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(968, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýBànToolStripMenuItem,
            this.quảnLýNguyênVậtLiệuToolStripMenuItem,
            this.quảnLýNhậnViênToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýBànToolStripMenuItem
            // 
            this.quảnLýBànToolStripMenuItem.Name = "quảnLýBànToolStripMenuItem";
            this.quảnLýBànToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýBànToolStripMenuItem.Text = "Quản Lý Bàn";
            // 
            // quảnLýNguyênVậtLiệuToolStripMenuItem
            // 
            this.quảnLýNguyênVậtLiệuToolStripMenuItem.Name = "quảnLýNguyênVậtLiệuToolStripMenuItem";
            this.quảnLýNguyênVậtLiệuToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýNguyênVậtLiệuToolStripMenuItem.Text = "Quản Lý Nguyên,Vật Liệu";
            // 
            // quảnLýNhậnViênToolStripMenuItem
            // 
            this.quảnLýNhậnViênToolStripMenuItem.Name = "quảnLýNhậnViênToolStripMenuItem";
            this.quảnLýNhậnViênToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.quảnLýNhậnViênToolStripMenuItem.Text = "Quản Lý Nhận Viên";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo,Thống Kê";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(635, 6);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(117, 20);
            this.lbWelcome.TabIndex = 3;
            this.lbWelcome.Text = "Welcome,Viet ";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVCView.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 701);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bottomContain);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "Hệ Thống Quản Lý";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.bottomContain.ResumeLayout(false);
            this.bottomContain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.lgpContainButton.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel bottomContain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel lgpContainButton;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnQLBan;
        private System.Windows.Forms.Button btnQLNguyenVatLieu;
        private System.Windows.Forms.Button btnQuanLyNV;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblStatusLogin;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNguyênVậtLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậnViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btn_Item;
    }
}