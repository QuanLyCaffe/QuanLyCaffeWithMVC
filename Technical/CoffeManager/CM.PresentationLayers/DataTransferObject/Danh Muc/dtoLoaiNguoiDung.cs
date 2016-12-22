using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.DataTransferObject
{
    public class dtoLoaiNguoiDung
    {
        private string _MA_LND;

        public string MA_LND
        {
            get { return _MA_LND; }
            set { _MA_LND = value; }
        }
        private string _TENLOAINGUOIDUNG;

        public string TENLOAINGUOIDUNG
        {
            get { return _TENLOAINGUOIDUNG; }
            set { _TENLOAINGUOIDUNG = value; }
        }
        private string _MOTA;

        public string MOTA
        {
            get { return _MOTA; }
            set { _MOTA = value; }
        }
    }
}
