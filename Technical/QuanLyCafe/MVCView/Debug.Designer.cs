namespace MVCView
{
    partial class Debug
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
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lb1 = new System.Windows.Forms.Label();
            this.flpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.Controls.Add(this.lb1);
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(498, 353);
            this.flpContainer.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(3, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(24, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "test";
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 353);
            this.Controls.Add(this.flpContainer);
            this.Name = "Debug";
            this.Text = "Debug";
            this.flpContainer.ResumeLayout(false);
            this.flpContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Label lb1;
    }
}