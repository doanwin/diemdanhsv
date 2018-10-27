using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_Phanquyen
    {
        DAL_QL_PhanQuyen phanquyen = new DAL_QL_PhanQuyen();
        public int updateCoQuyen(int? coquyen, string manhom, string mamanhinh)
        {
            return phanquyen.updateCoQuyen(coquyen, manhom, mamanhinh);
        }
        public DataTable GetDataByMaNhom(string manhom)
        {
            return phanquyen.GetDataByMaNhom(manhom);
        }
    }
}
