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
        private mAdmin m_admin;
        private IAdminView m_adminView;
        private IList m_listAdmin;
        public AdminController()
        {
        }
        public AdminController(IAdminView _adminView, IList _listaAdmin)
        {
            m_adminView = _adminView;
        }
        private void updateAdminViewDetailValues(mAdmin _admin)
        {
            
        }
        private void updateAdminWithViewValues(mAdmin _admin)
        {
            
        }
        public void LoadView()
        {
            m_adminView.ClearGrid();
            foreach (mAdmin var in m_listAdmin)
                m_adminView.AddUserToGrid(var);

            m_adminView.SetSelectedUserInGrid((mAdmin)m_listAdmin[0]);
        }

        public void SelectedUserChanged(string selectedUserId)
        {
            //foreach (User usr in this._users)
            //{
            //    if (usr.ID == selectedUserId)
            //    {
            //        _selectedUser = usr;
            //        updateViewDetailValues(usr);
            //        _view.SetSelectedUserInGrid(usr);
            //        this._view.CanModifyID = false;
            //        break;
            //    }
            //}
        }
    }
}
