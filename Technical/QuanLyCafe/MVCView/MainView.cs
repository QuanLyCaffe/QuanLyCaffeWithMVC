using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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

            //TEST..............
            //TestDocDanhSach();

            //TestSuaDanhSach();

            //TestThemDanhSach();

            //TestXoaDanhSach();
        }

        private void Init()
        {
            ScreenManager.GetInstance();
        }

        public void TestDocDanhSach()
        {
            DataTable dt = SqlController.ExecuteDatatable(Constant.m_conectionString, "DocDanhSachUer");
            MessageBox.Show(dt.Rows.Count.ToString());
        }
        public void TestSuaDanhSach()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@ID",1),
                                      new SqlParameter("@NAME","SANG")
                                  };
            SqlController.ExecuteNonQuery(Constant.m_conectionString, "SuaTest",para);
        }

        public void TestThemDanhSach()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@ID",100),
                                      new SqlParameter("@NAME","vien")
                                  };
            SqlController.ExecuteNonQuery(Constant.m_conectionString, "ThemTest", para);
        }

        public void TestXoaDanhSach()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@ID",1),
                                  };
            SqlController.ExecuteNonQuery(Constant.m_conectionString, "XoaTest", para);
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

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            ScreenManager.GetInstance().ShowQuanLyNV();
        }
    }
}
