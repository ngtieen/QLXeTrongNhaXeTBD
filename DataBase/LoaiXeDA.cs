using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DataBase.HDT;

namespace DataBase
{
    public class LoaiXeDA
    {
        private static LoaiXeDA instance;
        public static LoaiXeDA Instance
        {
            get { if (instance == null) instance = new LoaiXeDA(); return instance; }
            private set { instance = value; }

        }

        public bool ThemLoaiXe( string tenLoaiXe, int giaLoaiXe)
        {
            int resurl;
            string query = string.Format("insert LoaiXe values (N'{0},{1}) ",tenLoaiXe,giaLoaiXe);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl > 0;
        }
        public int HienThiGia(int idLoaiXe)
        {
            int resurl;
            string query = string.Format("Select gia from LoaiXe where idLoaiXe =  " + idLoaiXe);
            resurl = (int)DataProvider.Instance.ExecuteScalar(query);
            return resurl;
        }
        public bool SuaLoaiXe(int idLoaiXe, string tenLoaiXe, int giaLoaiXe)
        {
            int resurl;
            string query = string.Format("update LoaiXe set tenLoaiXe = N'{0}', gia = {1} where idLoaiXe = {2}", tenLoaiXe, giaLoaiXe,idLoaiXe);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl > 0;
        }
        public bool XoaLoaiXe(int idLoai)
        {
            int resurl;
            string query = string.Format("delete LoaiXe where idLoaiXe =  " + idLoai);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            // chạy xem kết quả trả về như nào
            return resurl > 0;
        }
        public List<LoaiXeDa_HDT> HienThiLoaiXe()
        {
            List<LoaiXeDa_HDT> listTheXe = new List<LoaiXeDa_HDT>();
            string query = "select * from LoaiXe ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiXeDa_HDT theXeDA = new LoaiXeDa_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
    }
}
