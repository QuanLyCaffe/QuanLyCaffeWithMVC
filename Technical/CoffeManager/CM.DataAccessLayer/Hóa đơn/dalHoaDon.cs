using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using DataTransferObject;
using CommonLayer;

namespace DataAccessLayer
{
    public class dalHoaDon
    {
        public dalHoaDon()
        {

        }
        public DataTable docDanhSachHoaDon()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachHoaDon");
        }

        public void docDanhSachHoaDonTheoThang(DataTable dt, string THANG , string NAM)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@THANG", THANG) };
                                        
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

        public void xoaHoaDon(string MA_HD)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_HD", MA_HD) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaHoaDon", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
