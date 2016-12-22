using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class bllHoaDon
    {
        dalHoaDon dalHoaDon;
        dtoHoaDon dtoHoaDon;

        public bllHoaDon()
        {
            dalHoaDon = new dalHoaDon();
            dtoHoaDon = new dtoHoaDon();
        }

        public DataTable docDanhSachHoaDon()
        {
            return (dalHoaDon.docDanhSachHoaDon());
        }

        public void docDanhSachHoaDonTheoThang(DataTable dt, string THANG, string NAM)
        {
            dalHoaDon.docDanhSachHoaDonTheoThang(dt, THANG, NAM);
        }
        public void docDanhSachHoaDonBaoCao(DataTable dt, string THANG, string NAM)
        {
            dalHoaDon.docDanhSachHoaDonBaoCao(dt, THANG, NAM);
        }
        public void luuDanhSachHoaDon(string MA_HD, string MA_KH, string MA_DDB, string MA_ND, string NGAY_HD, string NGAYTHANHTOAN, string GIATRIHD)
        {
            try
            {
                dtoHoaDon.MA_HD = MA_HD;
                dtoHoaDon.MA_KH = MA_KH;
                dtoHoaDon.MA_DDB = MA_DDB;
                dtoHoaDon.MA_ND = MA_ND;
                dtoHoaDon.GIATRIHD = GIATRIHD;
                dtoHoaDon.NGAY_HD = NGAY_HD;
                dtoHoaDon.NGAYTHANHTOAN = NGAYTHANHTOAN;

                dalHoaDon.themDanhSachHoaDon(dtoHoaDon);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        public void xoaHoaDon(string maHD)
        {
            try
            {
                dalHoaDon.xoaHoaDon(maHD);
            }
            catch
            {

            }
        }
    }
}
