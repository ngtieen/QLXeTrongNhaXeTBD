using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.HDT
{
    public class LoaiXeDa_HDT
    {
        public LoaiXeDa_HDT(int idLoai, string tenLoaiXe)
        {
            IdLoai = idLoai;
            TenLoaiXe = tenLoaiXe;
        }
        public LoaiXeDa_HDT(DataRow row)
        {
            IdLoai = (int)row["idLoaiXe"];
            TenLoaiXe = (string)row["tenLoaiXe"];
        }

        public int IdLoai { get; set; }
        public string TenLoaiXe { get; set; }
    }
}
