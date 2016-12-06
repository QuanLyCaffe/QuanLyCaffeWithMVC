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
    public partial class MainView : Form,IMainView
    {
        MainController m_mainController;
        public MainView()
        {
            InitializeComponent();
        }

        private void Init()
        {
            ScreenManager.GetInstance();
        }
        private void btnQLBan_Click(object sender, EventArgs e)
        {
            ScreenManager.GetInstance().m_tableView.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ScreenManager.GetInstance().m_adminView.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //m_mainController.SetStatusLoginInMainView();
        }

        public string m_statusLogin
        {
            get
            {
                return lblStatusLogin.Text;
            }
            set
            {
                lblStatusLogin.Text = value;
            }
        }

        public string m_welcome
        {
            get
            {
                return lbWelcome.Text;
            }
            set
            {
                lbWelcome.Text = value;
            }
        }

        public Admin m_currentAdmin
        {
            get
            {
                return null;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void SetController(MainController _mainController)
        {
            m_mainController = _mainController;
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            ScreenManager.GetInstance().m_ItemView.ShowDialog();
        }
    }
}
