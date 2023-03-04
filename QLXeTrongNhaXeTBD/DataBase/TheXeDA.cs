using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBase
{
    public class TheXeDA
    {
        private static TheXeDA instance;
        public static TheXeDA Instance
        {
            get { if (instance == null) instance = new TheXeDA(); return instance; }
            private set { instance = value; }
        }
        public bool ThemTheXe(int soLuongThem)
        {
            int resurl;
            string query = "Exec USP_themThe @SoLuongThem =" + soLuongThem;
            resurl = DataProvider.Instance.ExcuteNonQuery(query,new object[] {soLuongThem});
            return resurl>0;
        }
        public bool SuaTheXe(int idTenthe, string newTen)
        {
            int resurl;
            string query = string.Format("update TheXe set tenThe = N'{0}' where idThe = {1}",newTen,idTenthe);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl > 0;
        }
        public bool XoaTheXe(int idTenthe)
        {
            int resurl;
            string query = string.Format("delete TheXe where idthe = ", idTenthe);
            resurl = DataProvider.Instance.ExcuteNonQuery(query);
            return resurl > 0;
        }
        public List<TheXeDA_HDT> HienTHiTheXe()
        {
            List<TheXeDA_HDT> listTheXe = new List<TheXeDA_HDT>();
            string query = "select * from TheXe ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                TheXeDA_HDT theXeDA = new TheXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public List<TheXeDA_HDT> TimKiemTheXe(int id)
        {
            List<TheXeDA_HDT> listTheXe = new List<TheXeDA_HDT>();
            string query = string.Format("select * from TheXe where idThe like '%{0}%' ",id) ;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheXeDA_HDT theXeDA = new TheXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public List<TheXeDA_HDT> HienthiTheXeInFQL()
        {
            List<TheXeDA_HDT> listTheXe = new List<TheXeDA_HDT>();
            string query = string.Format("select* from TheXe where idThe not in (select idThe from DanhSachXe where ngayRa is null )");
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheXeDA_HDT theXeDA = new TheXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }
        public List<TheXeDA_HDT> HienthiTheXeInFSua(int idThe)
        {
            List<TheXeDA_HDT> listTheXe = new List<TheXeDA_HDT>();
            string query = string.Format("select * from TheXe where idThe not in ( select idThe from DanhSachXe where ngayRa is null ) or idThe = " + idThe );
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TheXeDA_HDT theXeDA = new TheXeDA_HDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }

    }
}
