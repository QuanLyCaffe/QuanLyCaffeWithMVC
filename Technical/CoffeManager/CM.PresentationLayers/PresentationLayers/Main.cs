using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTiecCuoi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiDSMonAn_Click(object sender, EventArgs e)
        {
            DSMonAn dsMonAn = new DSMonAn();
            dsMonAn.MdiParent = this;
            dsMonAn.Show();
        }

        private void tsmiCa_Click(object sender, EventArgs e)
        {
            Ca ca = new Ca();
            ca.MdiParent = this;
            ca.Show();
        }

        private void tsmiSanh_Click(object sender, EventArgs e)
        {
            dSSanh dsSanh = new dSSanh();
            dsSanh.MdiParent = this;
            dsSanh.Show();
        }


        private void tsmiNguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.MdiParent = this.MdiParent;
            nguoiDung.Show();
        }

        private void tsmiLoaiNguoiDung_Click(object sender, EventArgs e)
        {
            LoaiNguoiDung loaiNguoiDung = new LoaiNguoiDung();
            loaiNguoiDung.MdiParent = this;
            loaiNguoiDung.Show();
        }

        private void tsmiKhachHang_Click(object sender, EventArgs e)
        {
            KhangHang khachHang = new KhangHang();
            khachHang.MdiParent = this;
            khachHang.Show();
        }

        private void tsmiDichVu_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            dichVu.MdiParent = this;
            dichVu.Show();
        }

        private void tsmiLapDonDatBan_Click(object sender, EventArgs e)
        {
            LapDonDatBan lapDonDatBan = new LapDonDatBan();
            lapDonDatBan.MdiParent = this;
            lapDonDatBan.Show();
        }

        private void tsmiDSTiecCuoi_Click(object sender, EventArgs e)
        {
            DSTiecCuoi dsTiecCuoi = new DSTiecCuoi();
            dsTiecCuoi.MdiParent = this;
            dsTiecCuoi.Show();
        }

        private void tsmiLapHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MdiParent = this;
            hoaDon.Show();
        }

        private void tsmiDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.MdiParent = this;
            dangNhap.Show();
        }

        private void tsmiLapBaoCaoThang_Click(object sender, EventArgs e)
        {
            BaoCaoThang BaoCaoThang = new BaoCaoThang();
            BaoCaoThang.MdiParent = this;
            BaoCaoThang.Show();
        }


    }
}
