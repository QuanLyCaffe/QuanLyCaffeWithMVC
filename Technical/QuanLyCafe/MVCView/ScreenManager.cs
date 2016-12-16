using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MVCView
{
    public class ScreenManager
    {
        private const string m_statusNotLogin = "Vui lòng đăng nhập để sử dụng hệ thống!";
        private const string m_statusLogin = "Đăng nhập thành công !";
        #region INSTANCE...
        public ScreenManager()
        {
            Init();
        }
        private static ScreenManager m_instance;
        public static ScreenManager GetInstance()
        {
            if (m_instance == null)
            {
                m_instance = new ScreenManager();
            }
            return m_instance;
        }

        public bool m_isLogin = false;
        #endregion.....................
        #region SCREEN AVAIRABLE...
        public frmQuanLyHeThong m_adminView;
        public frmQuanLyBan m_tableView;
        public Login m_login;
        public MainView m_mainView;
        private frmQuanLyNhanVien m_quanLyNV;
        #endregion

        public void Init()
        {
            m_adminView = new frmQuanLyHeThong();
            m_tableView = new frmQuanLyBan();
            m_login = new Login();
            m_mainView = new MainView();
            m_quanLyNV = new frmQuanLyNhanVien();
        }

        public void HideAllScreen()
        {
            m_adminView.Hide();
            m_tableView.Hide();
            m_login.Hide();
            m_mainView.Hide();
        }

        public void ShowMainView()
        {
            if(!m_isLogin)
            {
                m_mainView.Show();
                m_login.ShowDialog();
            }
            else
            {
                m_mainView.Show();
            }
        }

        public void ShowFormAdmin()
        {
            if(!m_isLogin)
            {
                m_adminView.Show();
                m_login.ShowDialog();
            }
            else
            {
                m_adminView.ShowDialog();
            }
        }
        public void ShowQuanLyNV()
        {
            if (!m_isLogin)
            {
                m_quanLyNV.Show();
                m_login.ShowDialog();
            }
            else
            {
                m_quanLyNV.ShowDialog();
            }
        }

        //public void ShowFormQuanLyBan()
        //{
        //    if (!m_isLogin)
        //    {
            
        //        m_login.ShowDialog();
        //    }
        //    else
        //    {
        //        m_adminView.ShowDialog();
        //    }
        //}
    }
}
