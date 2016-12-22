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
    public class bllLoaiNguoiDung
    {
        dalLoaiNguoiDung dalLoaiNguoiDung;
        public bllLoaiNguoiDung()
        {
            dalLoaiNguoiDung = new dalLoaiNguoiDung();
        }
        public DataTable docDanhSachLoaiNguoiDung()
        {
            return (dalLoaiNguoiDung.docDanhSachLoaiNguoiDung());
        }

        public void luuDanhSachLoaiNguoiDung(DataTable dt)
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
                                dtoLoaiNguoiDung dtoLoaiNguoiDung = new dtoLoaiNguoiDung()
                                {
                                    MA_LND = dRow["MA_LND"].ToString(),
                                    TENLOAINGUOIDUNG = dRow["TENLOAINGUOIDUNG"].ToString(),
                                    MOTA = dRow["MOTA"].ToString()
                                };
                                dalLoaiNguoiDung.themDanhSachLoaiNguoiDung(dtoLoaiNguoiDung);
                                break;
                            case DataRowState.Modified:
                                dtoLoaiNguoiDung dtoLoaiNguoiDung1 = new dtoLoaiNguoiDung()
                                {
                                    MA_LND = dRow["MA_LND"].ToString(),
                                    TENLOAINGUOIDUNG = dRow["TENLOAINGUOIDUNG"].ToString(),
                                    MOTA = dRow["MOTA"].ToString()
                                };
                                dalLoaiNguoiDung.suaDanhSachLoaiNguoiDung(dtoLoaiNguoiDung1);
                                break;
                            case DataRowState.Deleted:
                                string MA_LND = dRow["MA_LND", DataRowVersion.Original].ToString();
                                dalLoaiNguoiDung.xoaLoaiNguoiDung(MA_LND);
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
