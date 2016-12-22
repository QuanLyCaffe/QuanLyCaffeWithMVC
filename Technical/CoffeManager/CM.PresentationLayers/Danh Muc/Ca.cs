using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataTransferObject;
using BusinessLogicLayer;
using CommonLayer;

namespace PresentationLayers
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
            btnXoa.Enabled = !duocPhepSua;
            btLuu.Enabled = duocPhepSua;
            btKhongLuu.Enabled = duocPhepSua;
            btThoat.Enabled = !duocPhepSua;
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
            if (KiemTraTruocLuu(dgvCa))
            {
                bllCa.luuDanhSachca(dt);
                CommonFunction.dinhDangThaoTacLuoi(dgvCa, false);
                dinhDangHienThiNut(false);
            }
            else
                return;
           
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

        int rowIndex;
        public bool KiemTraTruocLuu(DataGridView dgrv)
        {
            rowIndex = dgrv.CurrentRow.Index;
            string maLoaiCa = Convert.ToString(dgrv.CurrentRow.Cells["dgvTEN_LOAI_CA"].Value);
            string tenCa = Convert.ToString(dgrv.CurrentRow.Cells["dgvTenCa"].Value);

            if (maLoaiCa == "" || tenCa == "" )
            {
                MessageBox.Show("Bạn nhập thiếu thông tin ! vui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maLoaiCa = Convert.ToString(dgvCa.CurrentRow.Cells["dgvTEN_LOAI_CA"].Value);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa "+maLoaiCa , "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                bllCa.xoaDanhSachCa(maLoaiCa);
                docDuLieu();
                hienThiDuLieu();
            }
            else
                return;
        }
    }
}

