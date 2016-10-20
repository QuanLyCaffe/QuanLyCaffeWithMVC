using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormMVC.Model;

namespace MVCController
{
    public interface IAdminView
    {
        void SetController(AdminController _adminController);
        void ClearGrid();
        void AddUserToGrid(mAdmin _admin);
        void UpdateGridWithChangedUser(mAdmin _admin);
        void RemoveUserFromGrid(mAdmin _admin);
        string GetIdOfSelectedUserInGrid();
        void SetSelectedUserInGrid(mAdmin _admin);

        string m_adminName { get; set; }
        string m_password { get; set; }
        mAdmin.isAdmin m_isAdmin { get; set; }
        bool CanModifyID { set; }
    }
}
