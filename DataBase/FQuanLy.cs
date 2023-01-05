using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class FQuanLy
    {
        private static FQuanLy instance;
        public static FQuanLy Instance
        {
            get { if (instance == null) instance = new FQuanLy(); return instance; }
            private set { instance = value; }

        }
        public List<FQuanLy_HDT> fquanLy_HienThi()
        {
            List<FQuanLy_HDT> listTheXe = new List<FQuanLy_HDT>();
            string query = "select id, tenKhuXe as [Tên Khu Xe],bienSoXe as [Biển Số] , idThe as [ID thẻ] , tenLoaiXe as [Tên loại xe],ngayVao as [Ngày vào], ngayRa as [Ngày ra] , ds.tongTien as [Tổng Tiền] from DanhSachXe as ds,KhuXe as k,LoaiXe as l where ds.idKhu = k.idKhuXe and ds.idLoaiXe = l.idLoaiXe  and ngayRa is  null ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                FQuanLy_HDT theXeDA = new FQuanLy_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
    }
}
