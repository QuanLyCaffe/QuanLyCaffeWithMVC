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
    public partial class Ca : Form
    {
        bllCa bllCa;
        DataTable dt;
        public Ca()
        {
            InitializeComponent();
            bllCa = new bllCa();
            dt = new DataTable();
            dinhDangHienThiNut(false);
        }
        private void dinhDangHienThiNut(bool duocPhepSua)
        {
            btSua.Enabled = !duocPhepSua;
            btLuu.Enabled = duocPhepSua;
            btKhongLuu.Enabled = duocPhepSua;
            btThoat.Enabled = true;
        }
        private void docDuLieu()
        {
            dt = bllCa.docDanhSachCa();
        }
        private void hienThiDuLieu()
        {
            dgvCa.DataSource = dt;
        }

        private void Ca_Load(object sender, System.EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
            CommonFunction.dinhDangThaoTacLuoi(dgvCa, false);
        }

        private void btSua_Click(object sender, System.EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvCa, true);
            dinhDangHienThiNut(true);
        }

        private void btLuu_Click(object sender, System.EventArgs e)
        {
            bllCa.luuDanhSachca(dt);
            CommonFunction.dinhDangThaoTacLuoi(dgvCa, false);
            dinhDangHienThiNut(false);
        }

        private void btKhongLuu_Click(object sender, System.EventArgs e)
        {
            dt.RejectChanges();
            CommonFunction.dinhDangThaoTacLuoi(dgvCa, false);
            dinhDangHienThiNut(false);
        }

        private void btThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}

