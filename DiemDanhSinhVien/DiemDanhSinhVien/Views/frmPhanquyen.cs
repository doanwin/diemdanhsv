using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DiemDanhSinhVien.Views
{
    public partial class frmPhanquyen : Form
    {
        BLL_Nhomnguoidung nhomnguoidungbll = new BLL_Nhomnguoidung();
        public frmPhanquyen()
        {
            InitializeComponent();
            loadDSNhomnguoi();
        }
        #region ham load
        void loadDSNhomnguoi()
        {
            dgv_nhomnguoi.DataSource = nhomnguoidungbll.loadNhomnguoidung();
        }

        #endregion
    }
}
