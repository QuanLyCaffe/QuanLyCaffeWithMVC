using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.CommonLayer
{
    public class Constants
    {
        public static string ConnectionString = "Data Source=TUAN\\SQLEXPRESS;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True";

        public class Thang
        {
            public string TenDonViTinh { get; set; }
            public int MaDonViTinh { get; set; }
        }

        public static List<Thang> DanhMucDonViTinh()
        {
            List<Thang> lstDonViTinh = new List<Thang>();
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 1, TenDonViTinh = "1" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 2, TenDonViTinh = "2" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 3, TenDonViTinh = "3" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 4, TenDonViTinh = "4" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 5, TenDonViTinh = "5" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 6, TenDonViTinh = "6" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 7, TenDonViTinh = "7" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 8, TenDonViTinh = "8" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 9, TenDonViTinh = "9" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 10, TenDonViTinh = "10" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 11, TenDonViTinh = "11" });
            lstDonViTinh.Add(new Thang() { MaDonViTinh = 12, TenDonViTinh = "12" });

            return lstDonViTinh;
        }
        #region Thong bao
        public const string GridExceptionLoiChung = "Có lỗi dữ liệu. Vùi lòng kiểm tra lại!";
        public const string GridExceptionLoiNull = "Vui lòng nhập thông tin vào cột {0}";

        public const string MsgExceptionTonTaiMauTin = "Mẫu tin này đã tồn tại trong hệ thống.\n Đề nghị nhập lại mẫu tin mới.";
        public const string MsgExceptionTruyCapLoi = "Đã xảy ra lỗi trong quá trình truy cập tập tin dữ liệu";
        public const string MsgExceptionLuuLoi = "Đã xảy ra lỗi trong quá trình thực hiện giao tác lưu các mẩu tin dữ liệu.";
        public const string MsgExceptionLoiChung = "Đã xảy ra một lỗi trong chương trình.";

        public const string MsgFormLuuXong = "Lưu thành công!";
        #endregion Thong bao
    }
}
