using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormMVC.Controller
{
    public class MainController
    {
        private IMainView m_mainView;
        LoginController m_loginController;
        public MainController(IMainView _mainView, LoginController _loginController)
        {
            m_mainView = _mainView;
            m_loginController = _loginController;
            m_mainView.SetController(this);
        }
        public void SetStatusLoginInMainView()
        {
            if (m_loginController.IsLogin)
            {
                m_mainView.m_welcome = "Welcome,"+m_mainView.m_currentAdmin.AdminName;
                m_mainView.m_statusLogin = "Đăng nhập thành công !";
            }
            else
            {
                m_mainView.m_welcome = "Login";
                m_mainView.m_statusLogin = "Vui lòng đăng nhập để sử dụng hệ thống!";
            }
        }
    }
}
