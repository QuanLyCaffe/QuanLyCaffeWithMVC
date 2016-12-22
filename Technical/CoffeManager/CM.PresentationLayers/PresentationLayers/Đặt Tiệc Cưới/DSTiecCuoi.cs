using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTC.DataTransferObject;
using QLTC.BusinessLogicLayer;
using System.Data.SqlClient;
using QLTC.CommonLayer;

namespace QLTiecCuoi
{
    public partial class DSTiecCuoi : Form
    {
        bllDSTiecCuoi bllDSTiecCuoi;
        DataTable dt;
        public DSTiecCuoi()
        {
            InitializeComponent();
            bllDSTiecCuoi = new bllDSTiecCuoi();
            dt = new DataTable();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DSTiecCuoi_Load(object sender, EventArgs e)
        {
            dt = bllDSTiecCuoi.docDanhSachTiecCuoi();
            dgvDSTiecCuoi.DataSource = dt;
        }
    }
}
