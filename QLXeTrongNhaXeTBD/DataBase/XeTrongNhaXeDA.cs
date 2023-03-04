using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class XeTrongNhaXeDA
    {
        private static XeTrongNhaXeDA instance;
        public static XeTrongNhaXeDA Instance
        {
            get { if (instance == null) instance = new XeTrongNhaXeDA(); return instance; }
            private set { instance = value; }

        }

        public int ThemXe(int idKhu,string BienSoXe,int idthe, int idLoaiXe)
        {
            int resurl;
            string query = string.Format("exec USP_InsertXe @idKhu , @bienSoXe , @idThe , @idLoai ");
            resurl = DataProvider.Instance.ExcuteNonQuery(query,new object[]{idKhu,BienSoXe,idthe, idLoaiXe });
            return resurl ;
        }
        public bool SuaXe(int id, int idKhuXXe, string BienSoXe, int IdThe, int idLoaiXe,string ngayVao)
        {
            int resurl;
            string query = string.Format("Update DanhSachXe set bienSoXe = '{0}', idLoaiXe = {1} " +
                ",idKhu = {2}, idThe = {3},ngayVao= '{5}' where id = {4} ", BienSoXe, idLoaiXe, idKhuXXe,IdThe,id,ngayVao);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl > 0;
        }
        public bool XoaXe(int idXe)
        {
            int resurl;
            string query = string.Format("delete DanhSachXe where id =  " + idXe);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            // chạy xem kết quả trả về như nào
            return resurl > 0;
        }
        public List<XeTrongNhaXeDA_HDT> fAdmin_HienThi()
        {
            List<XeTrongNhaXeDA_HDT> listTheXe = new List<XeTrongNhaXeDA_HDT>();
            string query = "select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeTrongNhaXeDA_HDT theXeDA = new XeTrongNhaXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public List<XeTrongNhaXeDA_HDT> fquanLy_HienThi()
        {
            List<XeTrongNhaXeDA_HDT> listTheXe = new List<XeTrongNhaXeDA_HDT>();
            string query = "select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe  and ngayRa is  null ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeTrongNhaXeDA_HDT theXeDA = new XeTrongNhaXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public List<XeTrongNhaXeDA_HDT> HienThiXeXuat(int id)
        {
            List<XeTrongNhaXeDA_HDT> listTheXe = new List<XeTrongNhaXeDA_HDT>();
            string query = "select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe and id = "+id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeTrongNhaXeDA_HDT theXeDA = new XeTrongNhaXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public int XuatXe(int id, int tongTien)
        {
            int resurl;
            string query = string.Format("Update DanhSachXe set ngayRa = GETDATE(), tongTien = {0} where id = {1}",tongTien,id);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl;
        }
        public List<XeTrongNhaXeDA_HDT> TimKiem(string stringTimKiem)
        {
            List<XeTrongNhaXeDA_HDT> listTheXe = new List<XeTrongNhaXeDA_HDT>();
            string query = String.Format("select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe and idThe like '%{0}%'", stringTimKiem);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeTrongNhaXeDA_HDT hienthi = new XeTrongNhaXeDA_HDT(item);
                listTheXe.Add(hienthi);
            }
            return listTheXe;
        }
        // exec USP_InsertXe @idKhu , @bienSoXe , @idThe , @idLoai
        public DataTable GetXeListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListXeByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}
