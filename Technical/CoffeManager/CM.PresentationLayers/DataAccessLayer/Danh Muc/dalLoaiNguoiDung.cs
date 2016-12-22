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
    public class dalLoaiNguoiDung
    {
        public dalLoaiNguoiDung()
        {
        }
        public DataTable docDanhSachLoaiNguoiDung()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachLoaiNguoiDung");
        }
        public int suaDanhSachLoaiNguoiDung(dtoLoaiNguoiDung dtoLoaiNguoiDung)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_LND",dtoLoaiNguoiDung.MA_LND),
	                new SqlParameter( "@TENLOAINGUOIDUNG",dtoLoaiNguoiDung.TENLOAINGUOIDUNG),
                    new SqlParameter("MOTA", dtoLoaiNguoiDung.MOTA)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachLoaiNguoiDung", parameters));
            }
            catch (SqlException)
            {
                throw new ArgumentException(Constants.MsgExceptionTonTaiMauTin);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }

        public int themDanhSachLoaiNguoiDung(dtoLoaiNguoiDung dtoLoaiNguoiDung)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_LND",dtoLoaiNguoiDung.MA_LND),
	                new SqlParameter( "@TENLOAINGUOIDUNG",dtoLoaiNguoiDung.TENLOAINGUOIDUNG),
                    new SqlParameter("MOTA", dtoLoaiNguoiDung.MOTA)
            };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachLoaiNguoiDung", parameters));
            }
            catch (SqlException)
            {
                throw new ArgumentException(Constants.MsgExceptionTonTaiMauTin);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }

        public void xoaLoaiNguoiDung(string MA_LND)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_LND", MA_LND) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaLoaiNguoiDung", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
