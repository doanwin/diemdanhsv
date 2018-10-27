using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.qldiemdanhsvTableAdapters;
using System.Data;

namespace DAL
{
    public class DAL_QL_PhanQuyen
    {
        QL_PhanQuyenTableAdapter atp_phanquyen = new QL_PhanQuyenTableAdapter();
        QuyenChucNangTableAdapter atp_quyen = new QuyenChucNangTableAdapter();

        public DataTable GetDataByMaNhom(string manhom)
        {
            return atp_quyen.GetData(manhom);
        }

        public int updateCoQuyen(int? coquyen,string manhom, string mamanhinh)
        {
            return atp_phanquyen.UpdateQuery(coquyen,manhom, mamanhinh);
        }
        
    }
}
