using DataBase;
using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class fQuanLyBU
    {
        public List<FQuanLy_HDT> FquanLy_hienThi()
        {
            List<FQuanLy_HDT> list = new List<FQuanLy_HDT>();

            return FQuanLy.Instance.fquanLy_HienThi() ;
        }
    }
}
