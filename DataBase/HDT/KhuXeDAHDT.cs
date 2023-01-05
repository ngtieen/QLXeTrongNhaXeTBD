using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.HDT
{
    public class KhuXeDAHDT
    {
        public KhuXeDAHDT(int idKhu, string tenKhu)
        {
            IdKhu = idKhu;
            TenKhu = tenKhu;
        }
        public KhuXeDAHDT(DataRow row)
        {
            IdKhu = (int)row["idKhuXe"]   ;
            TenKhu = (string)row["tenKhuXe"];
        }
        public int IdKhu { get; set; }
        public string TenKhu { get; set; }

    }
}
