using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DoanhThu
    {
        private static DoanhThu instance;
        public static DoanhThu Instance
        {
            get { if (instance == null) instance = new DoanhThu(); return instance; }
            private set { instance = value; }

        }
        public List<XeTrongNhaXeDA_HDT> fDanhThu_HienThiDoanhThuTheoKhu(string tenKhu)
        {
            List<XeTrongNhaXeDA_HDT> danhsach = new List<XeTrongNhaXeDA_HDT>();
            string query =string.Format("select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe  and ngayRa is not null and k.tenKhuXe = N'{0}' ",tenKhu);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeTrongNhaXeDA_HDT xeTrongNhaXeDA_HDT = new XeTrongNhaXeDA_HDT(item);
                danhsach.Add(xeTrongNhaXeDA_HDT);
            }
            return danhsach;
        }
        
        public List<XeTrongNhaXeDA_HDT> fDoanhThuHienThiAll()
        {
            List<XeTrongNhaXeDA_HDT> danhsach = new List<XeTrongNhaXeDA_HDT>();
            string query = string.Format("select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe  and ngayRa is not null" );
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeTrongNhaXeDA_HDT xeTrongNhaXeDA_HDT = new XeTrongNhaXeDA_HDT(item);
                danhsach.Add(xeTrongNhaXeDA_HDT);
            }
            return danhsach;
        }
        public int CountKHU(string tenKhu)
        {
            int resurl;
            string query = string.Format("select count(*) from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe  and ngayRa is  not null and k.tenKhuXe=N'{0}'", tenKhu);
            resurl = (int)DataProvider.Instance.ExecuteScalar(query);
            return resurl;
        }
        public int CountALL()
        {
            int resurl;
            string query = string.Format("select count(*) from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe  and ngayRa is  not null ");
            resurl = (int)DataProvider.Instance.ExecuteScalar(query);
            return resurl;
        }

    }
}
