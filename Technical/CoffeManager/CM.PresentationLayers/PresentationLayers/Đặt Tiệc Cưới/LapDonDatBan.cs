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
    public partial class LapDonDatBan : Form
    {
        bllLapDonDatBan bllLapDonDatBan;
        bllKhachHang bllKhachHang;
        bllCa bllCa;
        bllDSSanh bllDSSanh;
        bllDSMonAn bllDSMonAn;
        bllDichVu bllDichVu;
        bllDSTiecCuoi bllDSTiecCuoi;

        DataTable dtDSTiecCuoi;
        DataTable dtCa;
        DataTable dtDSSanh;
        DataTable dtKhachHang;
        DataTable dtDSMonAn;
        DataTable dtDSDichVu;
        DataTable dtMonAn;
        DataTable dtDichVu;
        DataTable dtDSSanh1;
        DataTable dtKH;

        int TongSLMA;
        int TongGTMA;
        int TongSLDV;
        int TongGTDV;
        List<string> DS_MA;
        List<string> DS_DV;
        public LapDonDatBan()
        {
            InitializeComponent();
            bllLapDonDatBan = new bllLapDonDatBan();
            bllKhachHang = new bllKhachHang();
            bllCa = new bllCa();
            bllDSMonAn = new bllDSMonAn();
            bllDichVu = new bllDichVu();
            bllDSSanh = new bllDSSanh();
            bllDSTiecCuoi = new bllDSTiecCuoi();

            dtCa = new DataTable();
            dtDSDichVu = new DataTable();
            dtDSMonAn = new DataTable();
            dtDSSanh = new DataTable();
            dtKhachHang = new DataTable();
            dtDichVu = new DataTable();
            dtMonAn = new DataTable();
            dtDSSanh1 = new DataTable();
            dtDSTiecCuoi = new DataTable();
            dtKH = new DataTable();

            TongSLMA = 0;
            TongGTMA = 0;
            TongSLDV = 0;
            TongSLDV = 0;
            DS_MA = new List<string>();
            DS_DV = new List<string>();
        }
        private void docDuLieu()
        {
            dtKhachHang = bllKhachHang.docDanhSachKhachHang();
            dtCa = bllCa.docDanhSachCa();
            dtDSMonAn = bllDSMonAn.docDanhSachMonAn();
            dtDSDichVu = bllDichVu.docDanhSachDichVu();
            bllDSSanh.docDanhSachSanh(dtDSSanh);

        }

        private void hienThiDuLieu()
        {
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            TongSLMA = dgvDSMonAn.RowCount;
            for (int i = 0; i < TongSLMA - 1; i++)
            {
                string TG = dgvDSMonAn.Rows[i].Cells[1].Value.ToString();
                string MA = dgvDSMonAn.Rows[i].Cells[0].Value.ToString();
                DS_MA.Add(MA);
                TongGTMA += int.Parse(TG);
            }
            string DS = "";
            for (int j = 0; j < DS_MA.Count; j++)
            {
                DS += DS_MA[j] + ',';
            }
            int sd = dgvDSDichVu.RowCount;
            for (int i = 0; i < sd - 1; i++)
            {
                string GT = dgvDSDichVu.Rows[i].Cells[2].Value.ToString();
                string DV = dgvDSDichVu.Rows[i].Cells[1].Value.ToString();
                string sl = dgvDSDichVu.Rows[i].Cells[0].Value.ToString();
                DS_DV.Add(DV);
                TongSLDV += int.Parse(sl);
                TongGTDV += (int.Parse(GT) * int.Parse(sl));

            }
            string DSDV = "";
            for (int j = 0; j < DS_DV.Count; j++)
            {
                DSDV += DS_DV[j] + ',';
            }
            bllLapDonDatBan.luuDanhSachDonDatBan(tbMa_DDB.Text, cbbMa_KH.Text, cbbMa_Sanh.Text, cbbMa_Ca.Text, tbMa_HDDV.Text, tbMa_HDMA.Text, dtpkNgay_DB.Text, tbGiaBan.Text, tbSL_Ban.Text, tbSL_BanDuTru.Text, tbTien_DC.Text, TongSLMA.ToString(), DS, TongGTMA.ToString(), TongSLDV.ToString(), TongGTDV.ToString(), DSDV);
            btLuu.Enabled = false;
        }

        private void LapDonDatBan_Load(object sender, EventArgs e)
        {
            docDuLieu();
            hienThiDuLieu();
        }

        int tien = 0;   
        private void btThem_MA_Click(object sender, EventArgs e)
        {
            int row = dgvDSMonAn.RowCount - 1;
            bllDSMonAn.docDanhSachMonAnTheoMaMonAn(dtMonAn, cbbDS_MA.Text);
            dgvDSMonAn.DataSource = dtMonAn;
            string gia = dgvDSMonAn.Rows[row].Cells[1].Value.ToString();
            tien += int.Parse(gia);
            tbTriGiaHDMA.Text = tien.ToString();
        }
        int tiendv = 0;
        private void btThem_DV_Click(object sender, EventArgs e)
        {
            int row = dgvDSDichVu.RowCount - 1;
            bllDichVu.docDanhSachDichVuTheoMaDichVu(dtDichVu, cbbDS_DV.Text);
            dgvDSDichVu.DataSource = dtDichVu;
            dgvDSDichVu.Rows[row].Cells[0].Value = nmudSoLuong.Value;
            string sl = dgvDSDichVu.Rows[row].Cells[0].Value.ToString();
            string gia = dgvDSDichVu.Rows[row].Cells[2].Value.ToString();
            tiendv += (int.Parse(sl) * int.Parse(gia));
            tbGiaTriHDDV.Text = tiendv.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMa_Sanh_SelectedValueChanged(object sender, EventArgs e)
        {
            dtDSSanh1.Clear();
            dtDSTiecCuoi = bllDSTiecCuoi.docDanhSachTiecCuoi();
            tbGiaBan.DataBindings.Clear();
            bllDSSanh.docDanhSachSanhTheoMaSanh(dtDSSanh1, cbbMa_Sanh.Text);
            tbGiaBan.DataBindings.Add(new Binding("Text", dtDSSanh1, "DONGIABANTOITHIEU", true));
            foreach (DataRow drow in dtDSTiecCuoi.Rows)
            {
                if (drow["NGAYDATBAN"].ToString() == dtpkNgay_DB.Value.ToString())
                {
                    if (drow["MA_LOAI_CA"].ToString() == cbbMa_Ca.Text)
                    {
                        if (drow["MA_SANH"].ToString() == cbbMa_Sanh.Text)
                        {
                            MessageBox.Show("Sảnh đã được đặt, vui lòng chọn sảnh khác");
                            break;
                        }
                    }
                }
            }
        }

        private void btHoanTac_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
        }

        private void cbbMa_KH_Click(object sender, EventArgs e)
        {
            cbbMa_KH.DataSource = dtKhachHang;
            cbbMa_KH.DisplayMember = "MA_KH";
            cbbMa_KH.ValueMember = "MA_KH";
        }

        private void cbbMa_Ca_Click(object sender, EventArgs e)
        {
            cbbMa_Ca.DataSource = dtCa;
            cbbMa_Ca.DisplayMember = "MA_LOAI_CA";
            cbbMa_Ca.ValueMember = "MA_LOAI_CA";
        }

        private void cbbMa_Sanh_Click(object sender, EventArgs e)
        {
            cbbMa_Sanh.DataSource = dtDSSanh;
            cbbMa_Sanh.DisplayMember = "MA_SANH";
            cbbMa_Sanh.ValueMember = "MA_SANH";
        }

        private void cbbDS_MA_Click(object sender, EventArgs e)
        {
            cbbDS_MA.DataSource = dtDSMonAn; 
        }

        private void cbbDS_DV_Click(object sender, EventArgs e)
        {
            cbbDS_DV.DataSource = dtDSDichVu;
            cbbDS_DV.DisplayMember = "MA_DV";
            cbbDS_DV.ValueMember = "MA_DV";
        }

        private void cbbMa_KH_SelectedValueChanged(object sender, EventArgs e)
        {
            dtKH.Clear();
            dtKH = bllKhachHang.docDanhSachKhachHang1();
            foreach (DataRow drow in dtKH.Rows)
            {
                if (drow["MA_KH"].ToString() == cbbMa_KH.Text)
                {
                    MessageBox.Show("Khách hàng đã đặt bàn");
                    break;
                }
            }
        }

    }
}
