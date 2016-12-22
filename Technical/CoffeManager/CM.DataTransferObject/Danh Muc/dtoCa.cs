using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class dtoCa
    {
        private string _MA_LOAI_CA;

        public string MA_LOAI_CA
        {
            get { return _MA_LOAI_CA; }
            set { _MA_LOAI_CA = value; }
        }
        private string _TENCA;

        public string TENCA
        {
            get { return _TENCA; }
            set { _TENCA = value; }
        }
    }
}
