using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormMVC.Model;

namespace WinFormMVC.Controller
{
    public class LoginController
    {
        private ILogin m_loginView;

        public ILogin LoginView
        {
            get { return m_loginView; }
            set { m_loginView = value; }
        }
        private IList m_listAdmin;
        public IList ListAdmin
        {
            get { return m_listAdmin; }
            set { m_listAdmin = value; }
        }
        private Admin m_currAdmin;

        public Admin CurrAdmin
        {
            get { return m_currAdmin; }
            set { m_currAdmin = value; }
        }

        private bool m_isLogin;

        public bool IsLogin
        {
            get { return m_isLogin; }
            set { m_isLogin = value; }
        }
        public LoginController(ILogin _loginView, IList _listAdmin)
        {
            m_loginView = _loginView;
            m_listAdmin = _listAdmin;
            m_loginView.SetController(this);
            CurrAdmin = new Admin();
        }
        public bool Checking()
        {
            GetValuesFromView();
            IsLogin = false;
            foreach (Admin var in m_listAdmin)
            {
                if (Compare(CurrAdmin, var))
                {
                    IsLogin = true;
                }
            }
            return IsLogin;
        }
        private bool Compare(Admin a, Admin b)
        {
            if (a.AdminName.Equals(b.AdminName) && a.Password.Equals(b.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void GetValuesFromView()
        {
            CurrAdmin.AdminName = this.m_loginView.m_userName;
            CurrAdmin.Password = this.m_loginView.m_passWord;
        }
    }
}
