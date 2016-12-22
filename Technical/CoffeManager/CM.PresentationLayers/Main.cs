using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DataTransferObject;
using BusinessLogicLayer;
using CommonLayer;

namespace PresentationLayers
{
    public partial class Main : Form
    {
        #region THAM SỐ FORM
        Ca frmCa;
        frmDSHoaDon frmDSHoaDon;
        HoaDon frmLapHoaDon;
        BaoCaoThang frmBaoCao;
        #endregion

        #region CÀI ĐẶT BAN ĐẦU
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        #endregion 

        #region XỬ LÝ SỰ KIỆN FORM
        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình !","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void tsmiLapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon = new HoaDon();
            frmLapHoaDon.Show();
        }

        private void tsmiDangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmiLapBaoCaoThang_Click(object sender, EventArgs e)
        {
            frmBaoCao = new BaoCaoThang();
            frmBaoCao.Show();
        }

        private void tsmiDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmCa = new Ca();
            //frmCa.Parent = this;
            frmCa.Show();
        }
    }  
}