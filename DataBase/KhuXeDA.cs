using DataBase.HDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class KhuXeDA
    {

        public List<KhuXeDAHDT> HienthiKhuXe()
        {
            List<KhuXeDAHDT> listTheXe = new List<KhuXeDAHDT>();
            string query = "select * from KhuXe ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhuXeDAHDT theXeDA = new KhuXeDAHDT(item);
                listTheXe.Add(theXeDA);
            }
            return listTheXe;
        }

    }
}
