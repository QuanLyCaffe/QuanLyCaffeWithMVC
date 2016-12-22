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
    public class bllNguoiDung
    {
        dalNguoiDung dalNguoiDung;
        public bllNguoiDung()
        {
            dalNguoiDung = new dalNguoiDung();
        }

        public void docDanhSachNguoiDung(DataTable dt)
        {
            dalNguoiDung.docDanhSachNguoiDung(dt);
        }

        public void luuDanhSachNguoiDung(DataTable dt)
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
                                dtoNguoiDung dtoNguoiDung = new dtoNguoiDung()
                                {
                                    MA_ND = dRow["MA_ND"].ToString(),
                                    MA_LND = dRow["MA_LND"].ToString(),
                                    TEN_ND = dRow["TEN_ND"].ToString(),
                                    DIACHI = dRow["DIACHI"].ToString(),
                                    SODIENTHOAI = dRow["SODIENTHOAI"].ToString(),
                                    CMND = dRow["CMND"].ToString(),
                                    NGAYSINH = dRow["NGAYSINH"].ToString(),
                                    NGAYVAOLAM = dRow["NGAYVAOLAM"].ToString(),
                                    TENDANGNHAP = dRow["TENDANGNHAP"].ToString(),
                                    PASS = dRow["PASS"].ToString()
                                };
                                dalNguoiDung.themDanhSachNguoiDung(dtoNguoiDung);
                                break;
                            case DataRowState.Modified:
                                dtoNguoiDung dtoNguoiDung1 = new dtoNguoiDung()
                                {
                                    MA_ND = dRow["MA_ND"].ToString(),
                                    MA_LND = dRow["MA_LND"].ToString(),
                                    TEN_ND = dRow["TEN_ND"].ToString(),
                                    DIACHI = dRow["DIACHI"].ToString(),
                                    SODIENTHOAI = dRow["SODIENTHOAI"].ToString(),
                                    CMND = dRow["CMND"].ToString(),
                                    NGAYSINH = dRow["NGAYSINH"].ToString(),
                                    NGAYVAOLAM = dRow["NGAYVAOLAM"].ToString(),
                                    TENDANGNHAP = dRow["TENDANGNHAP"].ToString(),
                                    PASS = dRow["PASS"].ToString()
                                };
                                dalNguoiDung.suaDanhSachNguoiDung(dtoNguoiDung1);
                                break;
                            case DataRowState.Deleted:
                                string MA_ND = dRow["MA_ND", DataRowVersion.Original].ToString();
                                dalNguoiDung.xoaNguoiDung(MA_ND);
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
