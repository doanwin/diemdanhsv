using DevExpress.XtraEditors;
using DiemDanhSinhVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiemDanhSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tabHienThi_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemnguoidung frmthemnguoidung = new frmThemnguoidung();
            frmthemnguoidung.ShowDialog();
        }

       /* private Form KiemTraTonTai(Type fType)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }*/
        private void btnDSCahoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* Form frm = this.KiemTraTonTai(typeof(frmCaHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCaHoc f = new frmCaHoc();
                f.MdiParent = this;
                f.Show();
            }*/
            var form = new frmCaHoc();

            if (ExistForm(form))
                return;

            form.MdiParent = this;
            form.Show();
        }
        public bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if(child.Name==form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}
