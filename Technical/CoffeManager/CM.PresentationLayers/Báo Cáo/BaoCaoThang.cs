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
    public partial class BaoCaoThang : Form
    {
        bllHoaDon bllHoaDon;
        DataTable dtHoaDon;
        DataTable dtBaoCao;

        public BaoCaoThang()
        {
            InitializeComponent();
            bllHoaDon = new bllHoaDon();
            dtHoaDon = new DataTable();
            dtBaoCao = new DataTable();
        }

        private void BaoCaoThang_Load(object sender, EventArgs e)
        {
            cbbThang.DataSource = Constants.DanhMucDonViTinh();
            cbbThang.DisplayMember = "TenDonViTinh";
            cbbThang.ValueMember = "MaDonViTinh";
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            dtHoaDon.Clear();

            bllHoaDon.docDanhSachHoaDonTheoThang(dtHoaDon, cbbThang.Text, "");

            //string tongDT = "";
           // bllHoaDon.docDanhSachHoaDonBaoCao(dtBaoCao, cbbThang.Text, tbNam.Text);

            //dtHoaDon =  bllHoaDon.docDanhSachHoaDon();
            
            dgvBaoCao.DataSource = dtHoaDon;
            
            //tbTongDoanhThu.DataBindings.Clear();
            //tbTongDoanhThu.DataBindings.Add(new Binding("Text", dtHoaDon, "DOANHTHU", true));

            //dgvBaoCao.DataSource = dtBaoCao;

        }
    }
}
