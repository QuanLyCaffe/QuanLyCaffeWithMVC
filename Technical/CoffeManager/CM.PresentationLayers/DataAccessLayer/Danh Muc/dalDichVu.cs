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
    public class dalDichVu
    {
        public dalDichVu()
        {
        }
        public DataTable docDanhSachDichVu()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachDichVu");
        }

        public void docDanhSachDichVuTheoMaDichVu(DataTable dt, string MA_DV)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_DV", MA_DV) };
                SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachDichVuTheoMaDichVu", dt, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
        public int suaDanhSachDichVu(dtoDichVu dtoDichVu)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_DV",dtoDichVu.MA_DV),
	                new SqlParameter( "@TENCA",dtoDichVu.TENDV),
                    new SqlParameter("@GIADV", dtoDichVu.GIADV)
            
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachDichVu", parameters));
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

        public int themDanhSachDichVu(dtoDichVu dtoDichVu)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_DV",dtoDichVu.MA_DV),
	                new SqlParameter( "@TENCA",dtoDichVu.TENDV),
                    new SqlParameter("@GIADV", dtoDichVu.GIADV)
            
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachDichVu", parameters));
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

        public void xoaDichVu(string MA_DV)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_DV", MA_DV) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaDichVu", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
