namespace MVCView
{
    partial class frmQuanLyHeThong
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
            this.top_parent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.txbAdminID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.bottom_parent = new System.Windows.Forms.Panel();
            this.containParent = new System.Windows.Forms.Panel();
            this.grdAdmin = new System.Windows.Forms.ListView();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.top_parent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            this.grbSex.SuspendLayout();
            this.containParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_parent
            // 
            this.top_parent.Controls.Add(this.panel1);
            this.top_parent.Controls.Add(this.grpAdmin);
            this.top_parent.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_parent.Location = new System.Drawing.Point(0, 0);
            this.top_parent.Name = "top_parent";
            this.top_parent.Size = new System.Drawing.Size(723, 140);
            this.top_parent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnUpdateAdmin);
            this.panel1.Controls.Add(this.btnRemoveAdmin);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(492, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 140);
            this.panel1.TabIndex = 36;
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveAdmin.Location = new System.Drawing.Point(41, 52);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(140, 30);
            this.btnRemoveAdmin.TabIndex = 35;
            this.btnRemoveAdmin.Text = "&Remove User";
            this.btnRemoveAdmin.UseVisualStyleBackColor = false;
            this.btnRemoveAdmin.Click += new System.EventHandler(this.btnRemoveAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddAdmin.Location = new System.Drawing.Point(41, 12);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(140, 30);
            this.btnAddAdmin.TabIndex = 34;
            this.btnAddAdmin.Text = "&Add New User";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(264, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpAdmin
            // 
            this.grpAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpAdmin.Controls.Add(this.txbAdminID);
            this.grpAdmin.Controls.Add(this.label1);
            this.grpAdmin.Controls.Add(this.grbSex);
            this.grpAdmin.Controls.Add(this.btnCancle);
            this.grpAdmin.Controls.Add(this.txtPassword);
            this.grpAdmin.Controls.Add(this.btnSave);
            this.grpAdmin.Controls.Add(this.lblLastName);
            this.grpAdmin.Controls.Add(this.txtUserName);
            this.grpAdmin.Controls.Add(this.lblFirstName);
            this.grpAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmin.Location = new System.Drawing.Point(0, 0);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(492, 140);
            this.grpAdmin.TabIndex = 35;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Register New User :";
            // 
            // txbAdminID
            // 
            this.txbAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdminID.Location = new System.Drawing.Point(96, 24);
            this.txbAdminID.Name = "txbAdminID";
            this.txbAdminID.Size = new System.Drawing.Size(132, 22);
            this.txbAdminID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdNo);
            this.grbSex.Controls.Add(this.rdYes);
            this.grbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbSex.Location = new System.Drawing.Point(264, 19);
            this.grbSex.Name = "grbSex";
            this.grbSex.Size = new System.Drawing.Size(202, 59);
            this.grbSex.TabIndex = 29;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Admin";
            // 
            // rdNo
            // 
            this.rdNo.Location = new System.Drawing.Point(118, 25);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(67, 24);
            this.rdNo.TabIndex = 5;
            this.rdNo.Text = "No";
            // 
            // rdYes
            // 
            this.rdYes.Location = new System.Drawing.Point(37, 25);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(53, 24);
            this.rdYes.TabIndex = 4;
            this.rdYes.Text = "Yes";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(96, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 23);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(96, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 23);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "User Name:";
            // 
            // bottom_parent
            // 
            this.bottom_parent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottom_parent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_parent.Location = new System.Drawing.Point(0, 372);
            this.bottom_parent.Name = "bottom_parent";
            this.bottom_parent.Size = new System.Drawing.Size(723, 25);
            this.bottom_parent.TabIndex = 1;
            // 
            // containParent
            // 
            this.containParent.Controls.Add(this.grdAdmin);
            this.containParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containParent.Location = new System.Drawing.Point(0, 140);
            this.containParent.Name = "containParent";
            this.containParent.Size = new System.Drawing.Size(723, 232);
            this.containParent.TabIndex = 2;
            // 
            // grdAdmin
            // 
            this.grdAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdAdmin.FullRowSelect = true;
            this.grdAdmin.GridLines = true;
            this.grdAdmin.Location = new System.Drawing.Point(0, 0);
            this.grdAdmin.Name = "grdAdmin";
            this.grdAdmin.Size = new System.Drawing.Size(723, 232);
            this.grdAdmin.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdAdmin.TabIndex = 36;
            this.grdAdmin.UseCompatibleStateImageBehavior = false;
            this.grdAdmin.View = System.Windows.Forms.View.Details;
            this.grdAdmin.SelectedIndexChanged += new System.EventHandler(this.grdAdmin_SelectedIndexChanged);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(41, 91);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(140, 30);
            this.btnUpdateAdmin.TabIndex = 35;
            this.btnUpdateAdmin.Text = "&Update User";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancle.Location = new System.Drawing.Point(373, 91);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(93, 30);
            this.btnCancle.TabIndex = 36;
            this.btnCancle.Text = "&Cancel";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmQuanLyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 397);
            this.Controls.Add(this.containParent);
            this.Controls.Add(this.bottom_parent);
            this.Controls.Add(this.top_parent);
            this.Name = "frmQuanLyHeThong";
            this.Text = "Quản Lý Hệ Thống";
            this.top_parent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            this.grbSex.ResumeLayout(false);
            this.containParent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_parent;
        private System.Windows.Forms.Panel bottom_parent;
        private System.Windows.Forms.Panel containParent;
        internal System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.GroupBox grbSex;
        internal System.Windows.Forms.RadioButton rdNo;
        internal System.Windows.Forms.RadioButton rdYes;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.ListView grdAdmin;
        internal System.Windows.Forms.TextBox txbAdminID;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnRemoveAdmin;
        internal System.Windows.Forms.Button btnAddAdmin;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnUpdateAdmin;
        internal System.Windows.Forms.Button btnCancle;
    }
}