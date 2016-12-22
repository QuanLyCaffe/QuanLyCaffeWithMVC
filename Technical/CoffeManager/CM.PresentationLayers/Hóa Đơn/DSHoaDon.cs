using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DataTransferObject;
using BusinessLogicLayer;
using CommonLayer;

namespace PresentationLayers
{
    public partial class frmDSHoaDon : Form
    {
        bllHoaDon bllHoaDon;

        DataTable dtHoaDon;
        public frmDSHoaDon()
        {
            InitializeComponent();

            bllHoaDon = new bllHoaDon();
            dtHoaDon = new DataTable();
        }

        private void DSHoaDon_Load(object sender, EventArgs e)
        {
            dtHoaDon = bllHoaDon.docDanhSachHoaDon();
            drgvDSHoaDon.DataSource = dtHoaDon;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = Convert.ToString(drgvDSHoaDon.CurrentRow.Cells["MA_HD"].Value);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa " + maHD, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                bllHoaDon.xoaHoaDon(maHD);
                dtHoaDon = bllHoaDon.docDanhSachHoaDon();
                drgvDSHoaDon.DataSource = dtHoaDon;
            }
            else
                return;
        }
    }
}
