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
        BLL_Phanquyen phanquyenBll = new BLL_Phanquyen();
        private string pMaNhom = "";
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
        void loadDsQuyenByMaNhom(string pMaNhom)
        {
            dgv_chucnangquyen.DataSource = phanquyenBll.GetDataByMaNhom(pMaNhom);
        }
        #endregion

        private void dgv_nhomnguoi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int r=dgv_nhomnguoi.CurrentCell.RowIndex;
                pMaNhom = dgv_nhomnguoi.Rows[r].Cells[0].Value.ToString();
                loadDsQuyenByMaNhom(pMaNhom);
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_chucnangquyen.RowCount; i++)
            {
                if (pMaNhom == "")
                {
                    MessageBox.Show("Vui lòng nhóm");
                    return;
                }
                string mamanhinh = dgv_chucnangquyen[0, i].Value.ToString();
                int coquyen =int.Parse( dgv_chucnangquyen[2, i].Value.ToString());
                int update = phanquyenBll.updateCoQuyen(coquyen, pMaNhom, mamanhinh);
                if (update != 0)
                {
                    MessageBox.Show("lưu thành công");
                    loadDsQuyenByMaNhom(pMaNhom);
                }
                else
                    MessageBox.Show("Lỗi !!!");
            }
        }
    }
}
