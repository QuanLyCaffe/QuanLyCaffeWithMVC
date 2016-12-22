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
    public class dalKhachHang
    {
        public dalKhachHang()
        {
        }
        public DataTable docDanhSachKhachHang()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachKhachHang");
        }
        public DataTable docDanhSachKhachHang1()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachKhachHang1");
        }

        public void docDanhSachKhachHangTheoMa_KH(DataTable dt, string MA_KH)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_KH", MA_KH) };
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachKhachHangTheoMa_KH", dt, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
        public int suaDanhSachKhachHang(dtoKhachHang dtoKhachHang)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_KH",dtoKhachHang.MA_KH),
                    new SqlParameter("@TEN_CR",dtoKhachHang.TEN_CR),
                    new SqlParameter("@TEN_CD", dtoKhachHang.TEN_CD),
                    new SqlParameter("@DIACHI_CR",dtoKhachHang.DIACHI_CR),
                    new SqlParameter("@DIACHI_CD",dtoKhachHang.DIACHI_CD),
                    new SqlParameter("@SDT_CR",dtoKhachHang.SDT_CR),
                    new SqlParameter("@SDT_CD", dtoKhachHang.SDT_CD),
                    new SqlParameter("@CMND_CR",dtoKhachHang.CMND_CR),
                    new SqlParameter("@CMND_CD", dtoKhachHang.CMND_CD),
                    new SqlParameter("@NGAYSINH_CR",dtoKhachHang.NGAYSINH_CR),
                    new SqlParameter("@NGAYSINH_CD", dtoKhachHang.NGAYSINH_CD)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachKhachHang", parameters));
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

        public int themDanhSachKhachHang(dtoKhachHang dtoKhachHang)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_KH",dtoKhachHang.MA_KH),
                    new SqlParameter("@TEN_CR",dtoKhachHang.TEN_CR),
                    new SqlParameter("@TEN_CD", dtoKhachHang.TEN_CD),
                    new SqlParameter("@DIACHI_CR",dtoKhachHang.DIACHI_CR),
                    new SqlParameter("@DIACHI_CD",dtoKhachHang.DIACHI_CD),
                    new SqlParameter("@SDT_CR",dtoKhachHang.SDT_CR),
                    new SqlParameter("@SDT_CD", dtoKhachHang.SDT_CD),
                    new SqlParameter("@CMND_CR",dtoKhachHang.CMND_CR),
                    new SqlParameter("@CMND_CD", dtoKhachHang.CMND_CD),
                    new SqlParameter("@NGAYSINH_CR",dtoKhachHang.NGAYSINH_CR),
                    new SqlParameter("@NGAYSINH_CD", dtoKhachHang.NGAYSINH_CD)
            };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachKhachHang", parameters));
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

        public void xoaKhachHang(string MA_KH)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_KH", MA_KH) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaKhachHang", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
