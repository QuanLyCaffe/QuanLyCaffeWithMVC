using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTC.DataTransferObject;
using QLTC.BusinessLogicLayer;
using System.Data.SqlClient;
using QLTC.CommonLayer;

namespace QLTiecCuoi
{
    public partial class DangNhap : Form
    {
        bllNguoiDung bllNguoiDung;
        DataTable dt;
        public DangNhap()
        {
            InitializeComponent();
            bllNguoiDung = new bllNguoiDung();
            dt = new DataTable();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            //foreach (DataRow drow in dt.Rows)
            //{
            //    if ((drow["TENDANGNHAP"].ToString() == tbTenND.Text) && (drow["PASS"].ToString() == tbMK.Text))
            //    {
            //        //this.Visible = false;
            //        main.Show();
            //        break;
            //    }
            //}
            main.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            bllNguoiDung.docDanhSachNguoiDung(dt);
        }
    }
}
