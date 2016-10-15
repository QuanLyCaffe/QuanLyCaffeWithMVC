namespace MVCView
{
    partial class frmQuanLyBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.contain = new System.Windows.Forms.Panel();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBan1 = new System.Windows.Forms.Button();
            this.btnBan2 = new System.Windows.Forms.Button();
            this.btnBan3 = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.topContain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bottomContain.SuspendLayout();
            this.contain.SuspendLayout();
            this.flpBan.SuspendLayout();
            this.topContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomContain
            // 
            this.bottomContain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bottomContain.Controls.Add(this.label1);
            this.bottomContain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomContain.Location = new System.Drawing.Point(0, 336);
            this.bottomContain.Name = "bottomContain";
            this.bottomContain.Size = new System.Drawing.Size(584, 25);
            this.bottomContain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(455, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ Thống Quản Lý Coffee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contain
            // 
            this.contain.BackColor = System.Drawing.Color.Transparent;
            this.contain.Controls.Add(this.flpBan);
            this.contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contain.Location = new System.Drawing.Point(0, 48);
            this.contain.Name = "contain";
            this.contain.Size = new System.Drawing.Size(584, 288);
            this.contain.TabIndex = 2;
            // 
            // flpBan
            // 
            this.flpBan.BackColor = System.Drawing.Color.Transparent;
            this.flpBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpBan.Controls.Add(this.btnBan1);
            this.flpBan.Controls.Add(this.btnBan2);
            this.flpBan.Controls.Add(this.btnBan3);
            this.flpBan.Controls.Add(this.btnThemBan);
            this.flpBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBan.Location = new System.Drawing.Point(0, 0);
            this.flpBan.Name = "flpBan";
            this.flpBan.Padding = new System.Windows.Forms.Padding(10);
            this.flpBan.Size = new System.Drawing.Size(584, 288);
            this.flpBan.TabIndex = 0;
            // 
            // btnBan1
            // 
            this.btnBan1.BackgroundImage = global::MVCView.Properties.Resources.table1;
            this.btnBan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBan1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan1.Location = new System.Drawing.Point(13, 13);
            this.btnBan1.Name = "btnBan1";
            this.btnBan1.Size = new System.Drawing.Size(103, 100);
            this.btnBan1.TabIndex = 0;
            this.btnBan1.Text = "Bàn 1";
            this.btnBan1.UseVisualStyleBackColor = true;
            // 
            // btnBan2
            // 
            this.btnBan2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan2.Location = new System.Drawing.Point(122, 13);
            this.btnBan2.Name = "btnBan2";
            this.btnBan2.Size = new System.Drawing.Size(103, 100);
            this.btnBan2.TabIndex = 0;
            this.btnBan2.Text = "Bàn 2";
            this.btnBan2.UseVisualStyleBackColor = true;
            // 
            // btnBan3
            // 
            this.btnBan3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan3.Location = new System.Drawing.Point(231, 13);
            this.btnBan3.Name = "btnBan3";
            this.btnBan3.Size = new System.Drawing.Size(103, 100);
            this.btnBan3.TabIndex = 0;
            this.btnBan3.Text = "Bàn 3";
            this.btnBan3.UseVisualStyleBackColor = true;
            // 
            // btnThemBan
            // 
            this.btnThemBan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBan.Location = new System.Drawing.Point(340, 13);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(103, 100);
            this.btnThemBan.TabIndex = 0;
            this.btnThemBan.Text = "... Thêm bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            // 
            // topContain
            // 
            this.topContain.BackColor = System.Drawing.Color.Transparent;
            this.topContain.Controls.Add(this.lblTitle);
            this.topContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.topContain.Location = new System.Drawing.Point(0, 0);
            this.topContain.Name = "topContain";
            this.topContain.Size = new System.Drawing.Size(584, 48);
            this.topContain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(226, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME";
            // 
            // frmQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVCView.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.contain);
            this.Controls.Add(this.bottomContain);
            this.Controls.Add(this.topContain);
            this.Name = "frmQuanLyBan";
            this.Text = "Quản Lý Bàn";
            this.bottomContain.ResumeLayout(false);
            this.bottomContain.PerformLayout();
            this.contain.ResumeLayout(false);
            this.flpBan.ResumeLayout(false);
            this.topContain.ResumeLayout(false);
            this.topContain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottomContain;
        private System.Windows.Forms.Panel contain;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Button btnBan1;
        private System.Windows.Forms.Button btnBan2;
        private System.Windows.Forms.Button btnBan3;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Panel topContain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}