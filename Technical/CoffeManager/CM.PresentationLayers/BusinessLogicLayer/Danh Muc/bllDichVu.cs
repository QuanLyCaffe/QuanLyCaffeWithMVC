using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using QLTC.DataAccessLayer;
using QLTC.CommonLayer;
using QLTC.DataTransferObject;


namespace QLTC.BusinessLogicLayer
{
    public class bllDichVu
    {
        dalDichVu dalDichVu;
        public bllDichVu()
        {
            dalDichVu = new dalDichVu();
        }
        public DataTable docDanhSachDichVu()
        {
            return (dalDichVu.docDanhSachDichVu());
        }

        public void docDanhSachDichVuTheoMaDichVu(DataTable dt, string MA_DV)
        {
            dalDichVu.docDanhSachDichVuTheoMaDichVu(dt, MA_DV);
        }
        public void luuDanhSachDichVu(DataTable dt)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    foreach (DataRow dRow in dt.Rows)
                    {
                        switch (dRow.RowState)
                        {
                            case DataRowState.Added:
                                dtoDichVu dtoDichVu = new dtoDichVu()
                                {
                                    MA_DV = dRow["MA_DV"].ToString(),
                                    TENDV = dRow["TENDV"].ToString(),
                                    GIADV = dRow["GIADV"].ToString()
                                };
                                dalDichVu.themDanhSachDichVu(dtoDichVu);
                                break;
                            case DataRowState.Modified:
                                dtoDichVu dtoDichVu1 = new dtoDichVu()
                                {
                                    MA_DV = dRow["MA_DV"].ToString(),
                                    TENDV = dRow["TENDV"].ToString(),
                                    GIADV = dRow["GIADV"].ToString()
                                };
                                dalDichVu.suaDanhSachDichVu(dtoDichVu1);
                                break;
                            case DataRowState.Deleted:
                                string MA_DV = dRow["MA_DV", DataRowVersion.Original].ToString();
                                dalDichVu.xoaDichVu(MA_DV);
                                break;
                        }
                    }
                    dt.AcceptChanges();
                    scope.Complete();
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (TransactionAbortedException)
            {
                throw new ArgumentException(Constants.MsgExceptionLuuLoi);
            }
            catch (ApplicationException)
            {
                throw new ArgumentException(Constants.MsgExceptionLoiChung);
            }

        }

    }
}
