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
    public class dalNguoiDung
    {
        public dalNguoiDung()
        {
        }
        public void docDanhSachNguoiDung(DataTable dt)
        {
            SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachNguoiDung", dt, null);
        }
        public int suaDanhSachNguoiDung(dtoNguoiDung dtoNguoiDung)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_ND",dtoNguoiDung.MA_ND),
                    new SqlParameter("@MA_LND",dtoNguoiDung.MA_LND),
                    new SqlParameter("@TEN_ND", dtoNguoiDung.TEN_ND),
                    new SqlParameter("@DIACHI",dtoNguoiDung.DIACHI),
                    new SqlParameter("@SODIENTHOAI",dtoNguoiDung.SODIENTHOAI),
                    new SqlParameter("@CMND",dtoNguoiDung.CMND),
                    new SqlParameter("@NGAYSINH", dtoNguoiDung.NGAYSINH),
                    new SqlParameter("@NGAYVAOLAM",dtoNguoiDung.NGAYVAOLAM),
                    new SqlParameter("@TENDANGNHAP", dtoNguoiDung.TENDANGNHAP),
                    new SqlParameter("@PASS",dtoNguoiDung.PASS),
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachNguoiDung", parameters));
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

        public int themDanhSachNguoiDung(dtoNguoiDung dtoNguoiDung)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_ND",dtoNguoiDung.MA_ND),
                    new SqlParameter("@MA_LND",dtoNguoiDung.MA_LND),
                    new SqlParameter("@TEN_ND", dtoNguoiDung.TEN_ND),
                    new SqlParameter("@DIACHI",dtoNguoiDung.DIACHI),
                    new SqlParameter("@SODIENTHOAI",dtoNguoiDung.SODIENTHOAI),
                    new SqlParameter("@CMND",dtoNguoiDung.CMND),
                    new SqlParameter("@NGAYSINH", dtoNguoiDung.NGAYSINH),
                    new SqlParameter("@NGAYVAOLAM",dtoNguoiDung.NGAYVAOLAM),
                    new SqlParameter("@TENDANGNHAP", dtoNguoiDung.TENDANGNHAP),
                    new SqlParameter("@PASS",dtoNguoiDung.PASS),
            };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachNguoiDung", parameters));
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
        public void xoaNguoiDung(string MA_ND)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_ND", MA_ND) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaNguoiDung", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
