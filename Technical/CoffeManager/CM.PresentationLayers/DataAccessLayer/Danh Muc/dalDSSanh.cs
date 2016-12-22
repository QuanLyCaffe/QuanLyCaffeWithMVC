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
    public class dalDSSanh
    {
        public dalDSSanh()
        {
        }
        public void docDanhSachSanh(DataTable dt)
        {
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachSanh", dt, null);
        }

        public void docDanhSachSanhTheoMaSanh(DataTable dt, string MA_SANH)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_SANH", MA_SANH) };
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachSanhTheoMaSanh", dt, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
        public int suaDanhSachSanh(dtoDSSanh dtoDSSanh)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_SANH",dtoDSSanh.MA_SANH),
                    new SqlParameter("@TENSANH", dtoDSSanh.TENSANH),
                    new SqlParameter("@SLBANTOIDA",dtoDSSanh.SLBANTOIDA),
                    new SqlParameter("@DONGIABANTOITHIEU", dtoDSSanh.DONGIABANTOITHIEU),
                    new SqlParameter("@GHICHU", dtoDSSanh.GHICHU)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachSanh", parameters));
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
        public void xoaSanh(string MA_SANH)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_SANH", MA_SANH) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xaoSanh", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }

        public int themDanhSachSanh(dtoDSSanh dtoDSSanh)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_SANH",dtoDSSanh.MA_SANH),
                    new SqlParameter("@TENSANH", dtoDSSanh.TENSANH),
                    new SqlParameter("@SLBANTOIDA",dtoDSSanh.SLBANTOIDA),
                    new SqlParameter("@DONGIABANTOITHIEU", dtoDSSanh.DONGIABANTOITHIEU),
                    new SqlParameter("@GHICHU", dtoDSSanh.GHICHU)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachSanh", parameters));
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
    }
}
