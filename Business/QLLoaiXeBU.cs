using DataBase;
using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class QLLoaiXeBU : LoaiXeBU
    {
        public List<LoaiXeDa_HDT> HienThi()
        {
            LoaiXeDA  khu = new LoaiXeDA();
            return khu.HienThiLoaiXe();
        }
        public int HienThiGiaXe(int id)
        {
            int gia = LoaiXeDA.Instance.HienThiGia(id);
            return gia;
        }
    }
}
