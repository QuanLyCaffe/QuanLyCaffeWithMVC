using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.DataTransferObject
{
    public class dtoDSTiecCuoi
    {
        private string _MA_SANH;

        public string MA_SANH
        {
            get { return _MA_SANH; }
            set { _MA_SANH = value; }
        }
        private string _MA_LOAI_CA;

        public string MA_LOAI_CA
        {
            get { return _MA_LOAI_CA; }
            set { _MA_LOAI_CA = value; }
        }
        private string _NGAYDATBAN;

        public string NGAYDATBAN
        {
            get { return _NGAYDATBAN; }
            set { _NGAYDATBAN = value; }
        }
        private string _SLBAN;

        public string SLBAN
        {
            get { return _SLBAN; }
            set { _SLBAN = value; }
        }
    }
}
