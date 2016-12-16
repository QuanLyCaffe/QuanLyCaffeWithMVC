using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormMVC.Controller;
using WinFormMVC.Model;

namespace MVCView
{
    public partial class Login : Form,ILogin
    {
        LoginController m_loginController;
        IList m_listData;

        public Login()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            m_listData = new ArrayList();
            m_listData.Add(new Admin("id01", "", "", Admin.isAdmin.Male));
            m_loginController = new LoginController(this,m_listData);
        }
      
        public string m_userName
        {
            get
            {
                return tbUserName.Text;
            }
            set
            {
                tbUserName.Text = value;
            }
        }

        public string m_passWord
        {
            get
            {
                return tbPassword.Text;
            }
            set
            {
                tbPassword.Text = value;
            }
        }

        public bool Checking()
        {
            return m_loginController.Checking();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(Checking())
            {
                ScreenManager.GetInstance().m_isLogin = true;
                ScreenManager.GetInstance().m_login.Hide();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
