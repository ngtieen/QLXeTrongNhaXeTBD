using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TaiKhoanDA
    {
        private static TaiKhoanDA instance;
        public static TaiKhoanDA Instance
        {
            get { if (instance == null) instance = new TaiKhoanDA(); return instance; }
            private set { instance = value; }

        }
        public bool ThemTaiKhoan(string ten, string tenDangnhap, string matkhau, int type)
        {
            int resurl;
            string query = "exec USP_ThemTaiKhoan @disPlayname , @username  , @password  , @type ";
            resurl = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ten,tenDangnhap,matkhau,type });
            return resurl > 0;
        }
        public bool SuaTaiKhoan(int idTenthe, string newTen)
        {
            int resurl;
            string query = string.Format("update TheXe set tenThe = N'{0}' where idThe = {1}", newTen, idTenthe);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl > 0;
        }
        public bool XoaTaiKhoan(string username)
        {
            int resurl;
            string query = string.Format("delete Account where userName = " +username);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            // chạy xem kết quả trả về như nào
            return resurl > 0;
        }
        public List<TaiKhoanDA_HDT> HienTHiTheXe()
        {
            List<TaiKhoanDA_HDT> listTheXe = new List<TaiKhoanDA_HDT>();
            string query = "select * from Account ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDA_HDT theXeDA = new TaiKhoanDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public bool DangNhap(string username, string passwword)
        {
            string query = string.Format("exec USP_DangNhap  @username , @password");
            DataTable resurl = DataProvider.Instance.ExcuteQuery(query,new object[] {username,passwword});
            return resurl.Rows.Count > 0;
        }
    }
}
