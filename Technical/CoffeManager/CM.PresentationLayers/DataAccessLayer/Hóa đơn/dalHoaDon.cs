using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using QLTC.DataTransferObject;
using QLTC.CommonLayer;

namespace QLTC.DataAccessLayer
{
    public class dalHoaDon
    {
        public dalHoaDon()
        {

        }
        public void docDanhSachHoaDonTheoThang(DataTable dt, string THANG, string NAM)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@THANG", THANG),
                                              new SqlParameter("@NAM", NAM)};
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachHoaDonTheoThang", dt, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }

        public void docDanhSachHoaDonBaoCao(DataTable dt, string THANG, string NAM)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@THANG", THANG),
                                              new SqlParameter("@NAM", NAM)};
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachHoaDonBaoCao", dt, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
        public int themDanhSachHoaDon(dtoHoaDon dtoHoaDon)
        {
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_HD",dtoHoaDon.MA_HD),
	                new SqlParameter( "@MA_KH",dtoHoaDon.MA_KH),
	                new SqlParameter( "@MA_DDB",dtoHoaDon.MA_DDB),
                    new SqlParameter("@MA_ND", dtoHoaDon.MA_ND),
                    new SqlParameter( "@NGAY_HD",dtoHoaDon.NGAY_HD),
                    new SqlParameter("@NGAYTHANHTOAN", dtoHoaDon.NGAYTHANHTOAN),
                    new SqlParameter( "@GIATRIHD",dtoHoaDon.GIATRIHD)
            };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachHoaDon", parameters));
            }

        }
    }
}
