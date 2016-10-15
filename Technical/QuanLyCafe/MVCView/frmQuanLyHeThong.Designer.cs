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
            this.bottom_parent = new System.Windows.Forms.Panel();
            this.containParent = new System.Windows.Forms.Panel();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grdUsers = new System.Windows.Forms.ListView();
            this.top_parent.SuspendLayout();
            this.containParent.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grbSex.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_parent
            // 
            this.top_parent.Controls.Add(this.panel1);
            this.top_parent.Controls.Add(this.grpDetails);
            this.top_parent.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_parent.Location = new System.Drawing.Point(0, 0);
            this.top_parent.Name = "top_parent";
            this.top_parent.Size = new System.Drawing.Size(723, 140);
            this.top_parent.TabIndex = 0;
            // 
            // bottom_parent
            // 
            this.bottom_parent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottom_parent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_parent.Location = new System.Drawing.Point(0, 339);
            this.bottom_parent.Name = "bottom_parent";
            this.bottom_parent.Size = new System.Drawing.Size(723, 25);
            this.bottom_parent.TabIndex = 1;
            // 
            // containParent
            // 
            this.containParent.Controls.Add(this.grdUsers);
            this.containParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containParent.Location = new System.Drawing.Point(0, 140);
            this.containParent.Name = "containParent";
            this.containParent.Size = new System.Drawing.Size(723, 199);
            this.containParent.TabIndex = 2;
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpDetails.Controls.Add(this.grbSex);
            this.grpDetails.Controls.Add(this.txtPassword);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtUserName);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(0, 0);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(520, 140);
            this.grpDetails.TabIndex = 35;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Register new user :";
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdNo);
            this.grbSex.Controls.Add(this.rdYes);
            this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbSex.Location = new System.Drawing.Point(21, 79);
            this.grbSex.Name = "grbSex";
            this.grbSex.Size = new System.Drawing.Size(276, 54);
            this.grbSex.TabIndex = 29;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Admin";
            // 
            // rdNo
            // 
            this.rdNo.Location = new System.Drawing.Point(138, 19);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(67, 24);
            this.rdNo.TabIndex = 5;
            this.rdNo.Text = "No";
            // 
            // rdYes
            // 
            this.rdYes.Location = new System.Drawing.Point(57, 19);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(53, 24);
            this.rdYes.TabIndex = 4;
            this.rdYes.Text = "Yes";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(18, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 23);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(128, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(18, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 23);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "User Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnRemoveUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(520, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 140);
            this.panel1.TabIndex = 36;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(41, 46);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(140, 30);
            this.btnRemoveUser.TabIndex = 35;
            this.btnRemoveUser.Text = "&Remove User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(41, 10);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(140, 30);
            this.btnAddUser.TabIndex = 34;
            this.btnAddUser.Text = "&Add New User";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(41, 99);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(140, 30);
            this.btnChangePassword.TabIndex = 36;
            this.btnChangePassword.Text = "&Change Password";
            // 
            // grdUsers
            // 
            this.grdUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUsers.FullRowSelect = true;
            this.grdUsers.GridLines = true;
            this.grdUsers.Location = new System.Drawing.Point(0, 0);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.Size = new System.Drawing.Size(723, 199);
            this.grdUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdUsers.TabIndex = 36;
            this.grdUsers.UseCompatibleStateImageBehavior = false;
            this.grdUsers.View = System.Windows.Forms.View.Details;
            // 
            // frmQuanLyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 364);
            this.Controls.Add(this.containParent);
            this.Controls.Add(this.bottom_parent);
            this.Controls.Add(this.top_parent);
            this.Name = "frmQuanLyHeThong";
            this.Text = "Quản Lý Hệ Thống";
            this.top_parent.ResumeLayout(false);
            this.containParent.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbSex.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_parent;
        private System.Windows.Forms.Panel bottom_parent;
        private System.Windows.Forms.Panel containParent;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grbSex;
        internal System.Windows.Forms.RadioButton rdNo;
        internal System.Windows.Forms.RadioButton rdYes;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Button btnRemoveUser;
        internal System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.Button btnChangePassword;
        internal System.Windows.Forms.ListView grdUsers;
    }
}