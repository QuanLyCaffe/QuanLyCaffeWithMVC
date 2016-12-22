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
    public partial class KhangHang : Form
    {
        bllKhachHang bllKhachHang;
        DataTable dt;
        public KhangHang()
        {
            InitializeComponent();
            bllKhachHang = new bllKhachHang();
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
            dt = bllKhachHang.docDanhSachKhachHang();
        }
        private void hienThiDuLieu()
        {
            dgvKhachHang.DataSource = dt;
        }

        private void KhangHang_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
            CommonFunction.dinhDangThaoTacLuoi(dgvKhachHang, false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvKhachHang, true);
            dinhDangHienThiNut(true);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            bllKhachHang.luuDanhSachKhachHang(dt);
            CommonFunction.dinhDangThaoTacLuoi(dgvKhachHang, false);
            dinhDangHienThiNut(false);
        }

        private void btKhongLuu_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
            CommonFunction.dinhDangThaoTacLuoi(dgvKhachHang, false);
            dinhDangHienThiNut(false);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
