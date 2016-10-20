namespace MVCView
{
    partial class frmChooseItem
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.bottomContain = new System.Windows.Forms.Panel();
            this.contain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCafe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topContain.SuspendLayout();
            this.contain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topContain
            // 
            this.topContain.BackColor = System.Drawing.Color.Transparent;
            this.topContain.Controls.Add(this.lblTitle);
            this.topContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.topContain.Location = new System.Drawing.Point(0, 0);
            this.topContain.Name = "topContain";
            this.topContain.Size = new System.Drawing.Size(632, 44);
            this.topContain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(258, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chọn Món";
            // 
            // bottomContain
            // 
            this.bottomContain.BackColor = System.Drawing.Color.Transparent;
            this.bottomContain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomContain.Location = new System.Drawing.Point(0, 327);
            this.bottomContain.Name = "bottomContain";
            this.bottomContain.Size = new System.Drawing.Size(632, 36);
            this.bottomContain.TabIndex = 1;
            // 
            // contain
            // 
            this.contain.BackColor = System.Drawing.Color.Transparent;
            this.contain.Controls.Add(this.flowLayoutPanel1);
            this.contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contain.Location = new System.Drawing.Point(0, 44);
            this.contain.Name = "contain";
            this.contain.Size = new System.Drawing.Size(632, 283);
            this.contain.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCafe);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(632, 283);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCafe
            // 
            this.btnCafe.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafe.Location = new System.Drawing.Point(13, 13);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(137, 95);
            this.btnCafe.TabIndex = 0;
            this.btnCafe.Text = "Coffee";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(156, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 95);
            this.button2.TabIndex = 0;
            this.button2.Text = "Trà đào";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(299, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 95);
            this.button3.TabIndex = 0;
            this.button3.Text = "Trà sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "...Thêm món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmChooseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVCView.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 363);
            this.Controls.Add(this.contain);
            this.Controls.Add(this.bottomContain);
            this.Controls.Add(this.topContain);
            this.Name = "frmChooseItem";
            this.Text = "Chọn Món";
            this.topContain.ResumeLayout(false);
            this.topContain.PerformLayout();
            this.contain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topContain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel bottomContain;
        private System.Windows.Forms.Panel contain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}