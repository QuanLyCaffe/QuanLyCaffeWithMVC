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
    public class bllDSTiecCuoi
    {
        dalDSTiecCuoi dalDSTiecCuoi;
        public bllDSTiecCuoi()
        {
            dalDSTiecCuoi = new dalDSTiecCuoi();
        }
        public DataTable docDanhSachTiecCuoi()
        {
            return (dalDSTiecCuoi.docDanhSachTiecCuoi());
        }

    }
}
