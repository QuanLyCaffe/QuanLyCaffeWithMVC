using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WinFormMVC.Model;
using MVCController;

namespace MVCView
{
    public partial class frmQuanLyHeThong : Form,IAdminView
    {
        public frmQuanLyHeThong()
        {
            InitializeComponent();
            ResetView();
        }

        private AdminController m_adminController;

        private void ResetView()
        {
            this.m_adminName = "";
            this.m_password = "";
            this.m_isAdmin = Admin.isAdmin.Male;

        }


        #region Implemention...
        public void SetController(AdminController _adminController)
        {
            this.m_adminController = _adminController;
        }

        public void ClearGrid()
        {
            this.grdAdmin.Columns.Clear();

            this.grdAdmin.Columns.Add("Id", 150, HorizontalAlignment.Left);
            this.grdAdmin.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.grdAdmin.Columns.Add("Password", 150, HorizontalAlignment.Left);
            this.grdAdmin.Columns.Add("Is Admin", 150, HorizontalAlignment.Left);

            // Add rows to grid
            this.grdAdmin.Items.Clear();
        }

        public void AddUserToGrid(Admin _admin)
        {
            ListViewItem parent;
            parent = this.grdAdmin.Items.Add(_admin.Id);
            parent.SubItems.Add(_admin.AdminName);
            parent.SubItems.Add(_admin.Password);
            parent.SubItems.Add(Enum.GetName(typeof(Admin.isAdmin), _admin.IsAdmin));
        }

        //when click save
        public void UpdateGridWithChangedUser(Admin _admin)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdAdmin.Items)
            {
                if (row.Text == _admin.Id)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = _admin.Id;
                rowToUpdate.SubItems[1].Text = _admin.Id;
                rowToUpdate.SubItems[2].Text = _admin.AdminName;
                rowToUpdate.SubItems[3].Text = _admin.Password;
                rowToUpdate.SubItems[4].Text = Enum.GetName(typeof(Admin.isAdmin), _admin.IsAdmin);
            }
        }

        public void RemoveUserFromGrid(Admin _admin)
        {
            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdAdmin.Items)
            {
                if (row.Text == _admin.Id)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdAdmin.Items.Remove(rowToRemove);
                this.grdAdmin.Focus();
            }
        }

        public string GetIdOfSelectedUserInGrid()
        {
            if (this.grdAdmin.SelectedItems.Count > 0)
                return this.grdAdmin.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedUserInGrid(Admin _admin)
        {
            foreach (ListViewItem row in this.grdAdmin.Items)
            {
                if (row.Text == _admin.Id)
                {
                    row.Selected = true;
                }
            }
        }

        public string m_adminName
        {
            get
            {
                return txtUserName.Text;
            }
            set
            {
                txtUserName.Text = value;
            }
        }

        public string m_password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
               txtPassword.Text = value;
            }
        }

        public Admin.isAdmin m_isAdmin
        {
            get
            {
                if(rdNo.Checked)
                {
                    return Admin.isAdmin.Female;
                }
                else
                {
                    return Admin.isAdmin.Male;
                }
            }
            set
            {
                if(value == Admin.isAdmin.Male)
                {
                    rdYes.Checked = true;
                }else
                {
                    rdNo.Checked = true;
                }
            }
        }

        public bool CanModifyID
        {
            set { this.txbAdminID.Enabled = value; }
        }

        public string m_adminID
        {
            get
            {
                return txbAdminID.Text;
            }
            set
            {
                txbAdminID.Text = value;
            }
        }

        #endregion

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            m_adminController.AddNewUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_adminController.Save();
        }

        private void grdAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdAdmin.SelectedItems.Count > 0)
            {
                this.m_adminController.SelectedUserChanged(this.grdAdmin.SelectedItems[0].Text);
            }
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            m_adminController.RemoveUser();
        }
    }
}
