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
            this.m_isAdmin = mAdmin.isAdmin.Male;

        }
        #region Event_Handler...

        #endregion

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

        public void AddUserToGrid(mAdmin _admin)
        {
            ListViewItem parent;
            parent = this.grdAdmin.Items.Add(_admin.Id);
            parent.SubItems.Add(_admin.Id);
            parent.SubItems.Add(_admin.AdminName);
            parent.SubItems.Add(_admin.Password);
            parent.SubItems.Add(Enum.GetName(typeof(mAdmin.isAdmin), _admin.Admin));
        }

        //when click save
        public void UpdateGridWithChangedUser(mAdmin _admin)
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
                rowToUpdate.SubItems[4].Text = Enum.GetName(typeof(mAdmin.isAdmin), _admin.Admin);
            }
        }

        public void RemoveUserFromGrid(mAdmin _admin)
        {
            throw new NotImplementedException();
        }

        public string GetIdOfSelectedUserInGrid()
        {
            throw new NotImplementedException();
        }

        public void SetSelectedUserInGrid(mAdmin _admin)
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
                value = txtUserName.Text;
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
                value = txtPassword.Text;
            }
        }

        public mAdmin.isAdmin m_isAdmin
        {
            get
            {
                if(rdNo.Checked)
                {
                    return mAdmin.isAdmin.Female;
                }
                else
                {
                    return mAdmin.isAdmin.Male;
                }
            }
            set
            {
                if(value == mAdmin.isAdmin.Male)
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
            set { }
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
    }
}
