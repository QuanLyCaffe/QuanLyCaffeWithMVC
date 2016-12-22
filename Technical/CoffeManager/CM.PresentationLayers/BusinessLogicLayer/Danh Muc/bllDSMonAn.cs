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
    public class bllDSMonAn
    {
        dalDSMonAn dalDSMonAn;
        public bllDSMonAn()
        {
            dalDSMonAn = new dalDSMonAn();
        }
        public DataTable docDanhSachMonAn()
        {
            return (dalDSMonAn.docDanhSachMonAn());
        }

        public void docDanhSachMonAnTheoMaMonAn(DataTable dt, string MA_MONAN)
        {
            dalDSMonAn.docDanhSachMonAnTheoMaMonAn(dt, MA_MONAN);
        }

        public void luuDanhSachMonAn(DataTable dt)
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
                                dtoDSMonAn dtoDSMonAn = new dtoDSMonAn()
                                {
                                    MA_MONAN = dRow["MA_MONAN"].ToString(),
                                    TENMONAN = dRow["TENMONAN"].ToString(),
                                    DONGIA = dRow["DONGIA"].ToString(),
                                    GHICHU = dRow["GHICHU"].ToString()
                                };
                                dalDSMonAn.themDanhSachMonAn(dtoDSMonAn);
                                break;
                            case DataRowState.Modified:
                                dtoDSMonAn dtoDSMonAn1 = new dtoDSMonAn()
                                {
                                    MA_MONAN = dRow["MA_MONAN"].ToString(),
                                    TENMONAN = dRow["TENMONAN"].ToString(),
                                    DONGIA = dRow["DONGIA"].ToString(),
                                    GHICHU = dRow["GHICHU"].ToString()
                                };
                                dalDSMonAn.suaDanhSachMonAn(dtoDSMonAn1);
                                break;
                            case DataRowState.Deleted:
                                string MA_MONAN = dRow["MA_MONAN", DataRowVersion.Original].ToString();
                                dalDSMonAn.xoaMonAn(MA_MONAN);
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
