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
    public partial class LoaiNguoiDung : Form
    {
        bllLoaiNguoiDung bllLoaiNguoiDung;
        DataTable dt;
        public LoaiNguoiDung()
        {
            InitializeComponent();
            bllLoaiNguoiDung = new bllLoaiNguoiDung();
            dt = new DataTable();
            dinhDangHienThiNut(false);
        }

        private void docDuLieu()
        {
            dt = bllLoaiNguoiDung.docDanhSachLoaiNguoiDung();
        }

        private void hienThiDuLieu()
        {
            dgvLoaiNguoiDung.DataSource = dt;
        }

        private void dinhDangHienThiNut(bool duocPhepSua)
        {
            btSua.Enabled = !duocPhepSua;
            btLuu.Enabled = duocPhepSua;
            btKhongLuu.Enabled = duocPhepSua;
            btThoat.Enabled = true;
        }

        private void LoaiNguoiDung_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
            CommonFunction.dinhDangThaoTacLuoi(dgvLoaiNguoiDung, false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvLoaiNguoiDung, true);
            dinhDangHienThiNut(true);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            bllLoaiNguoiDung.luuDanhSachLoaiNguoiDung(dt);
            CommonFunction.dinhDangThaoTacLuoi(dgvLoaiNguoiDung, false);
            dinhDangHienThiNut(false);
        }

        private void btKhongLuu_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
            CommonFunction.dinhDangThaoTacLuoi(dgvLoaiNguoiDung, false);
            dinhDangHienThiNut(false);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
