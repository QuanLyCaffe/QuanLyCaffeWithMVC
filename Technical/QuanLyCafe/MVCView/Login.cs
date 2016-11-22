using System;
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
        
        public Login()
        {
            InitializeComponent();
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

        public void SetController(LoginController _loginController)
        {
            m_loginController = _loginController;
        }

        public bool Checking()
        {
            return m_loginController.Checking();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(Checking())
            {
                ScreenManager.GetInstance().m_login.Hide();
                //ScreenManager.GetInstance().m_mainView.Show();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
