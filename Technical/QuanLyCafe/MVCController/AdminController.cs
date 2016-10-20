﻿using System;
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

        // show view = model selected
        private void updateAdminViewDetailValues(Admin _admin)
        {
            this.m_adminView.m_adminID = _admin.Id;
            this.m_adminView.m_adminName = _admin.AdminName;
            this.m_adminView.m_password =_admin.Password;
            this.m_adminView.m_isAdmin = _admin.IsAdmin;
        }

        // set model = view
        private void updateAdminWithViewValues(Admin _admin)
        {
            _admin.Id = m_adminView.m_adminID; ;
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

        public void ResetView()
        {
            m_selectedAdmin = new Admin("", "", "", Admin.isAdmin.Male);

            this.updateAdminViewDetailValues(m_selectedAdmin);
            this.m_adminView.CanModifyID = false;
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
            string id = this.m_adminView.GetIdOfSelectedUserInGrid();
            Admin userToRemove = null;

            if (id != "")
            {
                foreach (Admin var in this.m_listAdmin)
                {
                    if (var.Id == id)
                    {
                        userToRemove = var;
                        break;
                    }
                }

                if (userToRemove != null)
                {
                    int newSelectedIndex = this.m_listAdmin.IndexOf(userToRemove);
                    this.m_listAdmin.Remove(userToRemove);
                    this.m_adminView.RemoveUserFromGrid(userToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < m_listAdmin.Count)
                    {
                        this.m_adminView.SetSelectedUserInGrid((Admin)m_listAdmin[newSelectedIndex]);
                    }
                }
            }
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
            //ResetView();
        }
    }
}
