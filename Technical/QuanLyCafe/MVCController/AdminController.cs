using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormMVC.Model;

namespace MVCController
{
    public class AdminController
    {
        private Admin m_selectedAdmin;
        private IAdminView m_adminView;
        private IList m_listAdmin;
        public AdminController()
        {
        }
        public AdminController(IAdminView _adminView, IList _listaAdmin)
        {
            m_adminView = _adminView;
            m_listAdmin = _listaAdmin;
            m_adminView.SetController(this);
        }
        private void updateAdminViewDetailValues(Admin _admin)
        {
            this.m_adminView.m_adminName = _admin.AdminName;
            this.m_adminView.m_password =_admin.Password;
            this.m_adminView.m_isAdmin = _admin.IsAdmin;
        }
        private void updateAdminWithViewValues(Admin _admin)
        {
            _admin.Id = "10";
            _admin.AdminName = this.m_adminView.m_adminName;
            _admin.Password = this.m_adminView.m_password;
            _admin.IsAdmin = this.m_adminView.m_isAdmin;    
        }
        public void LoadView()
        {
            m_adminView.ClearGrid();
            foreach (Admin var in m_listAdmin)
                m_adminView.AddUserToGrid(var);

            m_adminView.SetSelectedUserInGrid((Admin)m_listAdmin[0]);
        }

        public void SelectedUserChanged(string selectedUserId)
        {
            foreach (Admin var in m_listAdmin)
            {
                if (var.Id == selectedUserId)
                {
                    m_selectedAdmin = var;
                    updateAdminViewDetailValues(var);
                    m_adminView.SetSelectedUserInGrid(var);
                    this.m_adminView.CanModifyID = false;
                    break;
                }
            }
        }

        public void AddNewUser()
        {
            m_selectedAdmin = new Admin("","","",Admin.isAdmin.Male);

            this.updateAdminViewDetailValues(m_selectedAdmin);
            this.m_adminView.CanModifyID = true;
        }

        public void RemoveUser()
        {
            
        }

        public void Save()
        {
            updateAdminWithViewValues(m_selectedAdmin);
            if (!this.m_listAdmin.Contains(m_selectedAdmin))
            {
                // Add new user
                this.m_listAdmin.Add(m_selectedAdmin);
                this.m_adminView.AddUserToGrid(m_selectedAdmin);
            }
            else
            {
                // Update existing
                this.m_adminView.UpdateGridWithChangedUser(m_selectedAdmin);
            }
            m_adminView.SetSelectedUserInGrid(m_selectedAdmin);
            this.m_adminView.CanModifyID = false;
        }
    }
}
