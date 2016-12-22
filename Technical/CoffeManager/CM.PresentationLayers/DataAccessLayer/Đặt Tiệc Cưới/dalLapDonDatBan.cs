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
    public class dalLapDonDatBan
    {
         public dalLapDonDatBan()
        {
        }
         public DataTable docDanhSachDonDatBan()
         {
             return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachDonDatBan");
         }
         public void docDanhSachDonDatBanTheoMa_KH(DataTable dt, string MA_KH)
         {
             try
             {
                 SqlParameter[] parameters = { new SqlParameter("@MA_KH", MA_KH) };
                 SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachDonDatBanTheoMa_KH", dt, parameters);
             }
             catch (Exception)
             {
                 throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
             }
         }


         public void docDanhSachHoaDonMonAnTheoMa_HDMA(DataTable dt, string MA_HDMA)
         {
             try
             {
                 SqlParameter[] parameters = { new SqlParameter("@MA_HDMA", MA_HDMA) };
                 SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachHoaDonMonAnTheoMa_HDMA", dt, parameters);
             }
             catch (Exception)
             {
                 throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
             }
         }
         public void docDanhSachHoaDonDichVuTheoMa_HDDV(DataTable dt, string MA_HDDV)
         {
             try
             {
                 SqlParameter[] parameters = { new SqlParameter("@MA_HDDV", MA_HDDV) };
                 SqlHelper.FillDataTable(Constants.ConnectionString, "docDanhSachHoaDonDichVuTheoMa_HDDV", dt, parameters);
             }
             catch (Exception)
             {
                 throw new ArgumentException(Constants.MsgExceptionTruyCapLoi);
             }
         }




        public int themDanhSachDonDatBan(dtoLapDonDatBan dtoLapDonDatBan)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MA_DDB",dtoLapDonDatBan.MA_DDB),
                    new SqlParameter("@MA_SANH",dtoLapDonDatBan.MA_SANH),
                    new SqlParameter("@MA_LOAI_CA", dtoLapDonDatBan.MA_LOAI_CA),
                    new SqlParameter("@NGAYDATBAN", dtoLapDonDatBan.NGAYDATBAN),
                    new SqlParameter("@GIABAN",dtoLapDonDatBan.GIABAN),
                    new SqlParameter("@SLBAN",dtoLapDonDatBan.SLBAN),
                    new SqlParameter("@SLBANDUTRU", dtoLapDonDatBan.SLBANDUTRU),
                    new SqlParameter("@MA_KH",dtoLapDonDatBan.MA_KH),
                    new SqlParameter("@MA_HDDV", dtoLapDonDatBan.MA_HDDV),
                    new SqlParameter("@MA_HDMA", dtoLapDonDatBan.MA_HDMA),
                    new SqlParameter("@TIENDATCOC", dtoLapDonDatBan.TIENDATCOC),
                    new SqlParameter("@SL_MONAN",dtoLapDonDatBan.SL_MONAN),
                    new SqlParameter("@TEN_MA_MONAN", dtoLapDonDatBan.TEN_MA_MONAN),
                    new SqlParameter("@TRIGIA", dtoLapDonDatBan.TRIGIA),
                    new SqlParameter("@TEN_MA_DV",dtoLapDonDatBan.TEN_MA_DV),
                    new SqlParameter("@SOLUONGDV", dtoLapDonDatBan.SOLUONG_DV),
                    new SqlParameter("@GIATRI", dtoLapDonDatBan.GIATRI),
                };
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery(Constants.ConnectionString, "themDanhSachDonDatBan", parameters));
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
