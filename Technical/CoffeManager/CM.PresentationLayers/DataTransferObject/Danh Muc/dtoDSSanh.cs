using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.DataTransferObject
{
    public class dtoDSSanh
    {
        private string _MA_SANH;

        public string MA_SANH
        {
            get { return _MA_SANH; }
            set { _MA_SANH = value; }
        }
        private string _TENSANH;

        public string TENSANH
        {
            get { return _TENSANH; }
            set { _TENSANH = value; }
        }
        private string _SLBANTOIDA;

        public string SLBANTOIDA
        {
            get { return _SLBANTOIDA; }
            set { _SLBANTOIDA = value; }
        }
        private string _DONGIABANTOITHIEU;

        public string DONGIABANTOITHIEU
        {
            get { return _DONGIABANTOITHIEU; }
            set { _DONGIABANTOITHIEU = value; }
        }
        private string _GHICHU;


        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
    }
}
