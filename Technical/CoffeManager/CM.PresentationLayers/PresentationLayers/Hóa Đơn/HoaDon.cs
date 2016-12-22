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
    public partial class HoaDon : Form
    {
        bllLapDonDatBan bllLapDonDatBan;
        bllNguoiDung bllNguoiDung;
        bllKhachHang bllKhachHang;
        bllHoaDon bllHoaDon;
        DataTable dtDSKhachHang;
        DataTable dtTTKhachHang;
        DataTable dtNguoiDung;
        DataTable dtDonDatBan;
        DataTable dtTTDonDatBan;
        DataTable dtTTHDMonAn;
        DataTable dtTTHDDV;
        public HoaDon()
        {
            InitializeComponent();
            bllLapDonDatBan = new bllLapDonDatBan();
            bllNguoiDung = new bllNguoiDung();
            bllKhachHang = new bllKhachHang();
            bllHoaDon = new bllHoaDon();
            dtDSKhachHang = new DataTable();
            dtNguoiDung = new DataTable();
            dtDonDatBan = new DataTable();
            dtTTKhachHang = new DataTable();
            dtTTDonDatBan = new DataTable();
            dtTTHDMonAn = new DataTable();
            dtTTHDDV = new DataTable();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void docDuLieu()
        {
            dtDSKhachHang = bllLapDonDatBan.docDanhSachDonDatBan();
            bllNguoiDung.docDanhSachNguoiDung(dtNguoiDung);
        }

        private void hienThiDuLieu()
        {
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
        }

        private void cbbMa_KH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtDonDatBan.Clear();
                dtTTKhachHang.Clear();
                dtTTDonDatBan.Clear();
                dtTTHDMonAn.Clear();
                dtTTHDDV.Clear();
                tbTongTienPhaiTra.Clear();


                bllLapDonDatBan.docDanhSachDonDatBanTheoMa_KH(dtDonDatBan, cbbMa_KH.Text);
                bllKhachHang.docDanhSachKhachHangTheoMa_KH(dtTTKhachHang, cbbMa_KH.Text);
                bllLapDonDatBan.docDanhSachHoaDonMonAnTheoMa_HDMA(dtTTHDMonAn, tbMa_HDMA.Text);
                bllLapDonDatBan.docDanhSachHoaDonDichVuTheoMa_HDDV(dtTTHDDV, tbMa_HDDV.Text);

                dgvThongTin_KH.DataSource = dtTTKhachHang;
                dgvThongTin_DDB.DataSource = dtDonDatBan;
                dgvThongTin_MA.DataSource = dtTTHDMonAn;
                dgvThongTin_DV.DataSource = dtTTHDDV;

                tbMa_DDB.DataBindings.Add(new Binding("Text", dtDonDatBan, "MA_DDB", true));
                tbMa_HDMA.DataBindings.Add(new Binding("Text", dtDonDatBan, "MA_HDMA", true));
                tbMa_HDDV.DataBindings.Add(new Binding("Text", dtDonDatBan, "MA_HDDV", true));
                tbTienDatBan.DataBindings.Add(new Binding("Text", dtDonDatBan, "GIABAN", true));
                tbTienDatCoc.DataBindings.Add(new Binding("Text", dtDonDatBan, "TIENDATCOC", true));
                tbTien_MA.DataBindings.Add(new Binding("Text", dtTTHDMonAn, "TRIGIA", true));
                tbTien_DV.DataBindings.Add(new Binding("Text", dtTTHDDV, "GIATRI", true));
                dtpNgayDatBan.DataBindings.Add(new Binding("Text", dtDonDatBan, "NGAYDATBAN", true));
            }
            catch(Exception)
            { }
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            int Tongtien = 0;
            string tienban = tbTienDatBan.Text;
            string tienta = tbTien_MA.Text;
            string tiendv = tbTien_DV.Text;
            if (tiendv == "")
            {
                tiendv = "0";
            }
            string tiendc = tbTienDatCoc.Text;
            Tongtien = int.Parse(tienban) + int.Parse(tienta) + int.Parse(tiendv) - int.Parse(tiendc);
            if (Phat.Checked == true)
            {
                DateTime dt1 = dtpNgayDatBan.Value;
                DateTime dt2 = dtpNgayThanhToan.Value;
                TimeSpan diff = dt1.Subtract(dt2);
                int day = diff.Days;
                Tongtien += (day * Tongtien) / 100;
            }
            tbTongTienPhaiTra.Text = Tongtien.ToString();
        }

        private void btLuuHD_Click(object sender, EventArgs e)
        {
            bllHoaDon.luuDanhSachHoaDon(tbMa_HD.Text, cbbMa_KH.Text, tbMa_DDB.Text, cbbMa_NguoiDung.Text, dtpNgayDatBan.Text, dtpNgayThanhToan.Text, tbTongTienPhaiTra.Text);
            btLuuHD.Enabled = false;
        }

        private void btHoanTac_Click(object sender, EventArgs e)
        {
            btLuuHD.Enabled = true;
        }

        private void cbbMa_KH_Click(object sender, EventArgs e)

        {
            cbbMa_KH.DataSource = dtDSKhachHang;
        }

        private void cbbMa_NguoiDung_Click(object sender, EventArgs e)
        {
            cbbMa_NguoiDung.DataSource = dtNguoiDung;
        }

    }
}
