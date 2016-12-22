namespace PresentationLayers
{
    partial class Main
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsmiBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLapBaoCaoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.formParent = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pltitle = new System.Windows.Forms.Panel();
            this.lbHethong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pltitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.Color.White;
            this.mnsMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBaoCao,
            this.admin});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnsMain.Size = new System.Drawing.Size(807, 25);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tsmiBaoCao
            // 
            this.tsmiBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLapBaoCaoThang});
            this.tsmiBaoCao.Name = "tsmiBaoCao";
            this.tsmiBaoCao.Size = new System.Drawing.Size(69, 21);
            this.tsmiBaoCao.Text = "Báo Cáo";
            // 
            // tsmiLapBaoCaoThang
            // 
            this.tsmiLapBaoCaoThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLapBaoCaoThang.Name = "tsmiLapBaoCaoThang";
            this.tsmiLapBaoCaoThang.Size = new System.Drawing.Size(186, 22);
            this.tsmiLapBaoCaoThang.Text = "Lập báo cáo tháng";
            this.tsmiLapBaoCaoThang.Click += new System.EventHandler(this.tsmiLapBaoCaoThang_Click);
            // 
            // formParent
            // 
            this.formParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formParent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formParent.Location = new System.Drawing.Point(180, 25);
            this.formParent.Name = "formParent";
            this.formParent.Size = new System.Drawing.Size(627, 419);
            this.formParent.TabIndex = 4;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(0, 25);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(176, 30);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Đăng Nhập";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.pltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 419);
            this.panel1.TabIndex = 3;
            // 
            // pltitle
            // 
            this.pltitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pltitle.Controls.Add(this.lbHethong);
            this.pltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pltitle.Location = new System.Drawing.Point(0, 0);
            this.pltitle.Name = "pltitle";
            this.pltitle.Size = new System.Drawing.Size(176, 25);
            this.pltitle.TabIndex = 1;
            // 
            // lbHethong
            // 
            this.lbHethong.AutoSize = true;
            this.lbHethong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHethong.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbHethong.Location = new System.Drawing.Point(43, 4);
            this.lbHethong.Name = "lbHethong";
            this.lbHethong.Size = new System.Drawing.Size(75, 19);
            this.lbHethong.TabIndex = 0;
            this.lbHethong.Text = "Hệ Thống";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 25);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(47, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Quản Lý Bàn";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Quản Lý Mặt Hàng";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Quản Lý Nhân Viên";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 30);
            this.button6.TabIndex = 10;
            this.button6.Text = "Quản Lý Kho";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 25);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(22, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Báo Cáo,Thống Kê";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 285);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "Báo Cáo";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 315);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(176, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "Hóa Đơn";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 385);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(176, 30);
            this.button9.TabIndex = 14;
            this.button9.Text = "Thoát";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.admin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(94, 21);
            this.admin.Text = "welcome,viet";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 444);
            this.Controls.Add(this.formParent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffe Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pltitle.ResumeLayout(false);
            this.pltitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tsmiLapBaoCaoThang;
        private System.Windows.Forms.Panel formParent;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pltitle;
        private System.Windows.Forms.Label lbHethong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem admin;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}