using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using QLTC.DataAccessLayer;
using QLTC.CommonLayer;
using QLTC.DataTransferObject;
namespace QLTC.BusinessLogicLayer
{
    public class bllLapDonDatBan
    {
        dalLapDonDatBan dalLapDonDatBan;
        dtoLapDonDatBan dtoLapDonDatBan;
        public bllLapDonDatBan()
        {
            dalLapDonDatBan = new dalLapDonDatBan();
            dtoLapDonDatBan = new dtoLapDonDatBan();
        }
        public DataTable docDanhSachDonDatBan()
        {
            return (dalLapDonDatBan.docDanhSachDonDatBan());
        }
        public void docDanhSachDonDatBanTheoMa_KH(DataTable dt, string MA_KH)
        {
            dalLapDonDatBan.docDanhSachDonDatBanTheoMa_KH(dt, MA_KH);
        }

        public void docDanhSachHoaDonMonAnTheoMa_HDMA(DataTable dt, string MA_HDMA)
        {
            dalLapDonDatBan.docDanhSachHoaDonMonAnTheoMa_HDMA(dt, MA_HDMA);
        }

        public void docDanhSachHoaDonDichVuTheoMa_HDDV(DataTable dt, string MA_HDDV)
        {
            dalLapDonDatBan.docDanhSachHoaDonDichVuTheoMa_HDDV(dt, MA_HDDV);
        }
        public void luuDanhSachDonDatBan(string MA_DDB, string MA_KH, string MA_SANH, string MA_LOAI_CA, string MA_HDDV, string MA_HDMA, string NGAYDATBAN, string GIABAN, string SLBAN, string SLBANDUTRU, string TIENDATCOC, string SL_MONAN, string TEN_MA_MONAN, string TRIGIA, string TEN_MA_DV, string SOLUONGDV, string GIATRI)
        {
            try
            {
                dtoLapDonDatBan.MA_DDB = MA_DDB;
                dtoLapDonDatBan.MA_KH = MA_KH;
                dtoLapDonDatBan.MA_LOAI_CA = MA_LOAI_CA;
                dtoLapDonDatBan.GIABAN = GIABAN;
                dtoLapDonDatBan.MA_SANH = MA_SANH;
                dtoLapDonDatBan.NGAYDATBAN = NGAYDATBAN;
                dtoLapDonDatBan.GIABAN = GIABAN;
                dtoLapDonDatBan.SLBAN = SLBAN;
                dtoLapDonDatBan.SLBANDUTRU = SLBANDUTRU;
                dtoLapDonDatBan.MA_HDDV = MA_HDDV;
                dtoLapDonDatBan.MA_HDMA = MA_HDMA;
                dtoLapDonDatBan.TIENDATCOC = TIENDATCOC;
                dtoLapDonDatBan.SL_MONAN = SL_MONAN;
                dtoLapDonDatBan.TEN_MA_MONAN = TEN_MA_MONAN;
                dtoLapDonDatBan.TRIGIA = TRIGIA;
                dtoLapDonDatBan.TEN_MA_DV = TEN_MA_DV;
                dtoLapDonDatBan.SOLUONG_DV = SOLUONGDV;
                dtoLapDonDatBan.GIATRI = GIATRI;

                dalLapDonDatBan.themDanhSachDonDatBan(dtoLapDonDatBan);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

    }
}
