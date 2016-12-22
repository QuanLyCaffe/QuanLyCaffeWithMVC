using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC.DataTransferObject
{
    public class dtoDichVu
    {
        private string _MA_DV;

        public string MA_DV
        {
            get { return _MA_DV; }
            set { _MA_DV = value; }
        }
        private string _TENDV;

        public string TENDV
        {
            get { return _TENDV; }
            set { _TENDV = value; }
        }
        private string _GIADV;

        public string GIADV
        {
            get { return _GIADV; }
            set { _GIADV = value; }
        }
    }
}
