using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class QL_PhanQuyen
    {
        QL_PhanQuyenTableAdapter atp_phanquyen = new QL_PhanQuyenTableAdapter();
        QuyenChucNangTableAdapter atp_quyenchucnang = new QuyenChucNangTableAdapter();
    }
}
