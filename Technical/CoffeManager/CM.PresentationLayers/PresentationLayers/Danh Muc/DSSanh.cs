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
    public partial class dSSanh : Form
    {
        bllDSSanh bllDSSanh;
        DataTable dtDSSanh;
        public dSSanh()
        {
            InitializeComponent();
            bllDSSanh = new bllDSSanh();
            dinhDangHienThiNut(false);
            dtDSSanh = new DataTable();
        }

        private void dSSanh_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
            CommonFunction.dinhDangThaoTacLuoi(dgvDSSanh, false);
        }
        private void docDuLieu()
        {
            bllDSSanh.docDanhSachSanh(dtDSSanh);
        }

        private void hienThiDuLieu()
        {
            dgvDSSanh.DataSource = dtDSSanh;        
        }
        private void dinhDangHienThiNut(bool duocPhepSua)
        {
            btSua.Enabled = !duocPhepSua;
            btLuu.Enabled = duocPhepSua;
            btKhongLuu.Enabled = duocPhepSua;
            btThoat.Enabled = true;
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvDSSanh, true);
            dinhDangHienThiNut(true);        
        }

        private void btLuu_Click_1(object sender, EventArgs e)
        {
            bllDSSanh.luuDanhSachSanh(dtDSSanh);
            CommonFunction.dinhDangThaoTacLuoi(dgvDSSanh, false);
            dinhDangHienThiNut(false);        
        }

        private void btKhongLuu_Click_1(object sender, EventArgs e)
        {
            CommonFunction.dinhDangThaoTacLuoi(dgvDSSanh, false);
            dinhDangHienThiNut(false);        
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();        
        }
    }
}
