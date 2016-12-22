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
    public partial class DSMonAn : Form
    {
        bllDSMonAn bllDSMonAn;
        DataTable dt;
        public DSMonAn()
        {
            InitializeComponent();
            bllDSMonAn = new bllDSMonAn();
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
            dt = bllDSMonAn.docDanhSachMonAn();
        }
        private void hienThiDuLieu()
        {
            dgvDSMonAn.DataSource = dt;
        }
        private void DSMonAn_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
            CommonFunction.dinhDangThaoTacLuoi(dgvDSMonAn, false);
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvDSMonAn, true);
            dinhDangHienThiNut(true);
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            bllDSMonAn.luuDanhSachMonAn(dt);
            CommonFunction.dinhDangThaoTacLuoi(dgvDSMonAn, false);
            dinhDangHienThiNut(false);
        }

        private void btKhongLuu_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
            CommonFunction.dinhDangThaoTacLuoi(dgvDSMonAn, false);
            dinhDangHienThiNut(false);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
