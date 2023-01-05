using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DataBase.HDT;

namespace Business
{
    public class QLXeTrongNhaXeBU : XeTrongNhaXeBU
    {
        public List<XeTrongNhaXeDA_HDT> FquanLy_hienThi()
        {
            List<XeTrongNhaXeDA_HDT> list = new List<XeTrongNhaXeDA_HDT>();

            return XeTrongNhaXeDA.Instance.fquanLy_HienThi(); ;
        }
        public List<XeTrongNhaXeDA_HDT> FAdmin_HienThi()
        {
            List<XeTrongNhaXeDA_HDT> list = new List<XeTrongNhaXeDA_HDT>();

            return XeTrongNhaXeDA.Instance.fAdmin_HienThi(); ;
        }
        public bool ThemXe(int idKhu, string BienSoXe, int loaiXe, int idThe)
        {

            return XeTrongNhaXeDA.Instance.ThemXe(idKhu, BienSoXe, idThe, loaiXe) > 0;
        }
        public bool XuatXe(int id,int tongTien)
        {
            return XeTrongNhaXeDA.Instance.XuatXe(id, tongTien)>0;
        }
        public bool XoaXe(int id)
        {
            return XeTrongNhaXeDA.Instance.XoaXe(id);
        }
        public bool SuaXe(int id, int idKhuXXe, string BienSoXe, int IdThe, int idLoaiXe, string ngayVao)
        {
           return XeTrongNhaXeDA.Instance.SuaXe(id,idKhuXXe,BienSoXe,IdThe,idLoaiXe,ngayVao);
        }
        public List<XeTrongNhaXeDA_HDT> TimKiemByID(string iD)
        {
            List<XeTrongNhaXeDA_HDT> list = new List<XeTrongNhaXeDA_HDT>();
            return XeTrongNhaXeDA.Instance.TimKiem(iD); ;
        }
    }
}
