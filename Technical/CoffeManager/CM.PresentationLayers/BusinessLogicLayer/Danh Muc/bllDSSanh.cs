using System;
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
    public class bllDSSanh
    {
        dalDSSanh dalDSSanh;
        public bllDSSanh()
        {
            dalDSSanh = new dalDSSanh();
        }

        public void docDanhSachSanh(DataTable dt)
        {
            dalDSSanh.docDanhSachSanh(dt);
        }
        public void docDanhSachSanhTheoMaSanh(DataTable dt, string MA_SANH)
        {
            dalDSSanh.docDanhSachSanhTheoMaSanh(dt, MA_SANH);
        }
        public void luuDanhSachSanh(DataTable dt)
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
                                dtoDSSanh dtoDSSanh = new dtoDSSanh()
                                {
                                    MA_SANH = dRow["MA_SANH"].ToString(),
                                    TENSANH = dRow["TENSANH"].ToString(),
                                    SLBANTOIDA = dRow["SLBANTOIDA"].ToString(),
                                    DONGIABANTOITHIEU = dRow["DONGIABANTOITHIEU"].ToString(),
                                    GHICHU = dRow["GHICHU"].ToString()
                                };
                                dalDSSanh.themDanhSachSanh(dtoDSSanh);
                                break;
                            case DataRowState.Modified:
                                dtoDSSanh dtoDSSanh1 = new dtoDSSanh()
                                {
                                    MA_SANH = dRow["MA_SANH"].ToString(),
                                    TENSANH = dRow["TENSANH"].ToString(),
                                    SLBANTOIDA = dRow["SLBANTOIDA"].ToString(),
                                    DONGIABANTOITHIEU = dRow["DONGIABANTOITHIEU"].ToString(),
                                    GHICHU = dRow["GHICHU"].ToString()
                                };
                                dalDSSanh.suaDanhSachSanh(dtoDSSanh1);
                                break;
                            case DataRowState.Deleted:
                                string MA_SANH = dRow["MA_SANH", DataRowVersion.Original].ToString();
                                dalDSSanh.xoaSanh(MA_SANH);
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
