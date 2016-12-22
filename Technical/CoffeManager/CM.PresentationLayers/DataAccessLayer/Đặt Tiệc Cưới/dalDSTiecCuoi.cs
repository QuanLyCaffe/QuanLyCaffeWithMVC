using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using QLTC.DataTransferObject;
using QLTC.CommonLayer;

namespace QLTC.DataAccessLayer
{
    public class dalDSTiecCuoi
    {
        public dalDSTiecCuoi()
        {

        }
        public DataTable docDanhSachTiecCuoi()
        {
            return SqlHelper.ExecuteDatatable(Constants.ConnectionString, "docDanhSachTiecCuoi");
        }
    }
}
