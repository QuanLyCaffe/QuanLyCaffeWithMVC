using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

using DataAccessLayer;
using DataTransferObject;
using CommonLayer;

namespace BusinessLogicLayer
{
    public class bllCa
    {
        dalCa dalCa;
        public bllCa()
        {
            dalCa = new dalCa();
        }
        public DataTable docDanhSachCa()
        {
            return (dalCa.docDanhSachCa());
        }

        // lưu danh sách ca
        public void luuDanhSachca(DataTable dt)
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
                                dtoCa dtoCa = new dtoCa()
                                {
                                    MA_LOAI_CA = dRow["MA_LOAI_CA"].ToString(),
                                    TENCA = dRow["TENCA"].ToString()
                                };

                                dalCa.themDanhSachCa(dtoCa);
                                break;
                            case DataRowState.Modified:
                                dtoCa dtoCa1 = new dtoCa()
                                {
                                    MA_LOAI_CA = dRow["MA_LOAI_CA"].ToString(),
                                    TENCA = dRow["TENCA"].ToString()
                                };
                                dalCa.suaDanhSachCa(dtoCa1);
                                break;
                            case DataRowState.Deleted:
                                string MA_LOAI_CA = dRow["MA_LOAI_CA", DataRowVersion.Original].ToString();
                                dalCa.xoaCa(MA_LOAI_CA);
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

        // xóa danh sách ca
        public void xoaDanhSachCa(string maCa)
        {
            try
            {
                dalCa.xoaCa(maCa);
            }
            catch
            {

            }
        }
    }
}
