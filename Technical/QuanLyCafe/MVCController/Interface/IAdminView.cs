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
        void AddUserToGrid(Admin _admin);
        void UpdateGridWithChangedUser(Admin _admin);
        void RemoveUserFromGrid(Admin _admin);
        string GetIdOfSelectedUserInGrid();
        void SetSelectedUserInGrid(Admin _admin);

        string m_adminName { get; set; }
        string m_password { get; set; }
        Admin.isAdmin m_isAdmin { get; set; }
        bool CanModifyID { set; }
    }
}
