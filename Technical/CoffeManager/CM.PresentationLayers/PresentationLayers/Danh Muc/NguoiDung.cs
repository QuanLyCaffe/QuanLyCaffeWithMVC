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
    public partial class NguoiDung : Form
    {
        bllNguoiDung bllNguoiDung;
        bllLoaiNguoiDung bllLoaiNguoiDung;
        DataTable dtNguoiDung;
        DataTable dtLoaiNguoiDung;
        public NguoiDung()
        {
            InitializeComponent();
            bllLoaiNguoiDung = new bllLoaiNguoiDung();
            dtNguoiDung = new DataTable();
            dtLoaiNguoiDung = new DataTable();
            bllNguoiDung = new bllNguoiDung();
            dinhDangHienThiNut(false);
        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
            CommonFunction.dinhDangThaoTacLuoi(dgvNguoiDung, false);
        }
        private void docDuLieu()
        {
            bllNguoiDung.docDanhSachNguoiDung(dtNguoiDung);
            dtLoaiNguoiDung = bllLoaiNguoiDung.docDanhSachLoaiNguoiDung();
        }

        private void hienThiDuLieu()
        {
            dgv1MaLoaiNguoiDung.DataSource = dtLoaiNguoiDung;
            dgv1MaLoaiNguoiDung.DisplayMember = "MA_LND";
            dgv1MaLoaiNguoiDung.ValueMember = "MA_LND";
            dgv1MaLoaiNguoiDung.DataPropertyName = "MA_LND";

            dgvNguoiDung.DataSource = dtNguoiDung;
        }
        private void dinhDangHienThiNut(bool duocPhepSua)
        {
            btSua.Enabled = !duocPhepSua;
            btLuu.Enabled = duocPhepSua;
            btKhongLuu.Enabled = duocPhepSua;
            btThoat.Enabled = true;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvNguoiDung, true);
            dinhDangHienThiNut(true);     
        }

        private void btKhongLuu_Click(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvNguoiDung, false);
            dinhDangHienThiNut(false);  
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            bllNguoiDung.luuDanhSachNguoiDung(dtNguoiDung);
            CommonFunction.dinhDangThaoTacLuoi(dgvNguoiDung, false);
            dinhDangHienThiNut(false);  
        }

    }
}
