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
    public class dalCa
    {
        public dalCa()
        { 
        }

        //đọc danh sách ca
        //return : DataTable
        public DataTable docDanhSachCa()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachCa");
        }
        public int suaDanhSachCa(dtoCa dtoCa)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_LOAI_CA",dtoCa.MA_LOAI_CA),
	                new SqlParameter( "@TENCA",dtoCa.TENCA)
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "suaDanhSachCa", parameters));
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

        //thêm danh sách ca
        public int themDanhSachCa(dtoCa dtoCa)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_LOAI_CA",dtoCa.MA_LOAI_CA),
	                new SqlParameter( "@TENCA",dtoCa.TENCA)
            
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachCa", parameters));
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

        // xóa ca
        public void xoaCa(string MA_LOAI_CA)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MA_LOAI_CA", MA_LOAI_CA) };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "xoaCa", parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
            }
        }
    }
}
