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
    public class dalDSMonAn
    {
        public dalDSMonAn()
        {
        }
        public DataTable docDanhSachMonAn()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachMonAn");
        }
        public void docDanhSachMonAnTheoMaMonAn(DataTable dtDSMonaAn, string MA_MONAN)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_MONAN", MA_MONAN) };
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachMonAnTheoMaMonAn", dtDSMonaAn, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
        public int suaDanhSachMonAn(dtoDSMonAn dtoDSMonAn)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_MONAN",dtoDSMonAn.MA_MONAN),
	                new SqlParameter("@TENMONAN",dtoDSMonAn.TENMONAN),
                    new SqlParameter("@DONGIA", dtoDSMonAn.DONGIA),
                    new SqlParameter("GHICHU", dtoDSMonAn.GHICHU)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachMonAn", parameters));
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

        public int themDanhSachMonAn(dtoDSMonAn dtoDSMonAn)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_MONAN",dtoDSMonAn.MA_MONAN),
	                new SqlParameter("@TENMONAN",dtoDSMonAn.TENMONAN),
                    new SqlParameter("@DONGIA", dtoDSMonAn.DONGIA),
                    new SqlParameter("GHICHU", dtoDSMonAn.GHICHU)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachMonAn", parameters));
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

        public void xoaMonAn(string MA_MONAN)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_MONAN", MA_MONAN) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaMonAn", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
