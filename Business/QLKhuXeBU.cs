using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DataBase.HDT;

namespace Business
{
    public class QLKhuXeBU : KhuXeBU
    {
        public List<KhuXeDAHDT> HienThi()
        {
           KhuXeDA khu = new KhuXeDA();
           return  khu.HienthiKhuXe();
        }
    }
}
