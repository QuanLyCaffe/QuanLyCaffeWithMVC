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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parent = new System.Windows.Forms.Panel();
            this.containButton = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.parent.SuspendLayout();
            this.containButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // parent
            // 
            this.parent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.parent.Controls.Add(this.containButton);
            this.parent.Controls.Add(this.menuStrip1);
            this.parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent.Location = new System.Drawing.Point(0, 0);
            this.parent.Name = "parent";
            this.parent.Size = new System.Drawing.Size(633, 398);
            this.parent.TabIndex = 0;
            // 
            // containButton
            // 
            this.containButton.AutoSize = true;
            this.containButton.BackColor = System.Drawing.SystemColors.Control;
            this.containButton.BackgroundImage = global::MVCView.Properties.Resources.bg1;
            this.containButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.containButton.Controls.Add(this.button4);
            this.containButton.Controls.Add(this.button1);
            this.containButton.Controls.Add(this.button2);
            this.containButton.Controls.Add(this.button3);
            this.containButton.Controls.Add(this.button5);
            this.containButton.Controls.Add(this.button6);
            this.containButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containButton.Location = new System.Drawing.Point(0, 24);
            this.containButton.Name = "containButton";
            this.containButton.Size = new System.Drawing.Size(633, 374);
            this.containButton.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::MVCView.Properties.Resources.system;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 150);
            this.button4.TabIndex = 0;
            this.button4.Text = "Quản lý hệ thống";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MVCView.Properties.Resources.table;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 150);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản Lý Bàn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(415, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 150);
            this.button2.TabIndex = 0;
            this.button2.Text = "Quản lý nguyên, vật liệu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 150);
            this.button3.TabIndex = 0;
            this.button3.Text = "Quản lý nhân viên ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(209, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 150);
            this.button5.TabIndex = 0;
            this.button5.Text = "Báo cáo, thống kê";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::MVCView.Properties.Resources.shutdown;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(415, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 150);
            this.button6.TabIndex = 0;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 398);
            this.Controls.Add(this.parent);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Hệ Thống Quản Lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.parent.ResumeLayout(false);
            this.parent.PerformLayout();
            this.containButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel parent;
        private System.Windows.Forms.FlowLayoutPanel containButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;


    }
}