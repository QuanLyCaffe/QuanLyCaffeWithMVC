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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomContain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lgpContainButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnQLBan = new System.Windows.Forms.Button();
            this.btnQLNguyenVatLieu = new System.Windows.Forms.Button();
            this.btnQuanLyNV = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.bottomContain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lgpContainButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bottomContain
            // 
            this.bottomContain.BackColor = System.Drawing.Color.Transparent;
            this.bottomContain.Controls.Add(this.lblTitle);
            this.bottomContain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomContain.Location = new System.Drawing.Point(0, 373);
            this.bottomContain.Name = "bottomContain";
            this.bottomContain.Size = new System.Drawing.Size(653, 25);
            this.bottomContain.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(524, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hệ Thống Quản Lý Coffee";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lgpContainButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 349);
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
            this.lgpContainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lgpContainButton.Location = new System.Drawing.Point(0, 0);
            this.lgpContainButton.Name = "lgpContainButton";
            this.lgpContainButton.Padding = new System.Windows.Forms.Padding(10);
            this.lgpContainButton.Size = new System.Drawing.Size(653, 349);
            this.lgpContainButton.TabIndex = 2;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = global::MVCView.Properties.Resources.system;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.Location = new System.Drawing.Point(13, 13);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 150);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Quản lý hệ thống";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnQLBan
            // 
            this.btnQLBan.BackgroundImage = global::MVCView.Properties.Resources.table;
            this.btnQLBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLBan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQLBan.Location = new System.Drawing.Point(219, 13);
            this.btnQLBan.Name = "btnQLBan";
            this.btnQLBan.Size = new System.Drawing.Size(200, 150);
            this.btnQLBan.TabIndex = 0;
            this.btnQLBan.Text = "Quản Lý Bàn";
            this.btnQLBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLBan.UseVisualStyleBackColor = true;
            // 
            // btnQLNguyenVatLieu
            // 
            this.btnQLNguyenVatLieu.BackgroundImage = global::MVCView.Properties.Resources.Matiral;
            this.btnQLNguyenVatLieu.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNguyenVatLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQLNguyenVatLieu.Location = new System.Drawing.Point(425, 13);
            this.btnQLNguyenVatLieu.Name = "btnQLNguyenVatLieu";
            this.btnQLNguyenVatLieu.Size = new System.Drawing.Size(200, 150);
            this.btnQLNguyenVatLieu.TabIndex = 0;
            this.btnQLNguyenVatLieu.Text = "Quản lý nguyên, vật liệu";
            this.btnQLNguyenVatLieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLNguyenVatLieu.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNV
            // 
            this.btnQuanLyNV.BackgroundImage = global::MVCView.Properties.Resources.user;
            this.btnQuanLyNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNV.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuanLyNV.Location = new System.Drawing.Point(13, 169);
            this.btnQuanLyNV.Name = "btnQuanLyNV";
            this.btnQuanLyNV.Size = new System.Drawing.Size(200, 150);
            this.btnQuanLyNV.TabIndex = 0;
            this.btnQuanLyNV.Text = "Quản lý nhân viên ";
            this.btnQuanLyNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyNV.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackgroundImage = global::MVCView.Properties.Resources.report;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBaoCao.Location = new System.Drawing.Point(219, 169);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(200, 150);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo, thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::MVCView.Properties.Resources.shutdown;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(425, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 150);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVCView.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bottomContain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainView";
            this.Text = "Hệ Thống Quản Lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bottomContain.ResumeLayout(false);
            this.bottomContain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.lgpContainButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
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
    }
}