using DataBase;
using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class QlDoanhThu
    {
        public List<XeTrongNhaXeDA_HDT> HienThiTheoKhu(string tenKhu)
        {
            List<XeTrongNhaXeDA_HDT> list = new List<XeTrongNhaXeDA_HDT>();
            return DoanhThu.Instance.fDanhThu_HienThiDoanhThuTheoKhu(tenKhu); 
        }
        public List<XeTrongNhaXeDA_HDT> HienThiALL(string tenKhu)
        {
            List<XeTrongNhaXeDA_HDT> list = new List<XeTrongNhaXeDA_HDT>();
            return DoanhThu.Instance.fDoanhThuHienThiAll();
        }
        public int CountKhu(string tenKhu)
        {
            return DoanhThu.Instance.CountKHU(tenKhu);
        }
        public int CountALL()
        {
            return DoanhThu.Instance.CountALL();
        }
    }
}
