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
    public class bllKhachHang
    {
        dalKhachHang dalKhachHang;
        public bllKhachHang()
        {
            dalKhachHang = new dalKhachHang();
        }
        public DataTable docDanhSachKhachHang()
        {
            return (dalKhachHang.docDanhSachKhachHang());
        }
        public DataTable docDanhSachKhachHang1()
        {
            return (dalKhachHang.docDanhSachKhachHang1());
        }
        public void docDanhSachKhachHangTheoMa_KH(DataTable dt, string MA_KH)
        {
            dalKhachHang.docDanhSachKhachHangTheoMa_KH(dt, MA_KH);
        }
        public void luuDanhSachKhachHang(DataTable dt)
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
                                dtoKhachHang dtoKhachHang = new dtoKhachHang()
                                {
                                    MA_KH = dRow["MA_KH"].ToString(),
                                    TEN_CR = dRow["TEN_CR"].ToString(),
                                    TEN_CD = dRow["TEN_CD"].ToString(),
                                    DIACHI_CR = dRow["DIACHI_CR"].ToString(),
                                    DIACHI_CD = dRow["DIACHI_CD"].ToString(),
                                    SDT_CR = dRow["SDT_CR"].ToString(),
                                    SDT_CD = dRow["SDT_CD"].ToString(),
                                    CMND_CR = dRow["CMND_CR"].ToString(),
                                    CMND_CD = dRow["CMND_CD"].ToString(),
                                    NGAYSINH_CR = dRow["NGAYSINH_CR"].ToString(),
                                    NGAYSINH_CD = dRow["NGAYSINH_CD"].ToString()
                                };
                                dalKhachHang.themDanhSachKhachHang(dtoKhachHang);
                                break;
                            case DataRowState.Modified:
                                dtoKhachHang dtoKhachHang1 = new dtoKhachHang()
                                {
                                    MA_KH = dRow["MA_KH"].ToString(),
                                    TEN_CR = dRow["TEN_CR"].ToString(),
                                    TEN_CD = dRow["TEN_CD"].ToString(),
                                    DIACHI_CR = dRow["DIACHI_CR"].ToString(),
                                    DIACHI_CD = dRow["DIACHI_CD"].ToString(),
                                    SDT_CR = dRow["SDT_CR"].ToString(),
                                    SDT_CD = dRow["SDT_CD"].ToString(),
                                    CMND_CR = dRow["CMND_CR"].ToString(),
                                    CMND_CD = dRow["CMND_CD"].ToString(),
                                    NGAYSINH_CR = dRow["NGAYSINH_CR"].ToString(),
                                    NGAYSINH_CD = dRow["NGAYSINH_CD"].ToString()
                                };
                                dalKhachHang.suaDanhSachKhachHang(dtoKhachHang1);
                                break;
                            case DataRowState.Deleted:
                                string MA_KH = dRow["MA_KH", DataRowVersion.Original].ToString();
                                dalKhachHang.xoaKhachHang(MA_KH);
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
