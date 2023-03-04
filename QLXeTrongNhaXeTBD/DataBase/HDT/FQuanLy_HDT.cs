using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.HDT
{
    public class FQuanLy_HDT
    {
        public FQuanLy_HDT(DataRow row)
        {
            IdXe = (int)row["id"];
            NgayXeVao = (DateTime?)row["Ngày vào"];
            TenKhuXe = (string)row["Tên khu xe"];
            BienSoXe = (string)row["Biển số"];
            IdThe = (int)row["ID Thẻ"];
            TenLoaiXe = (string)row["Tên Loại xe"];
            //TongTien = (int?)row["Tổng Tiền"];
        }

        public FQuanLy_HDT(int idXe, string tenKhuXe, string bienSoXe, int idThe, string tenLoaiXe, DateTime? ngayXeVao, DateTime? ngayXeRa, int tongTien)
        {
            IdXe = idXe;
            TenKhuXe = tenKhuXe;
            BienSoXe = bienSoXe;
            IdThe = idThe;
            TenLoaiXe = tenLoaiXe;
            NgayXeVao = ngayXeVao;
        }

        public int IdXe { get; set; }
        public string TenKhuXe { get; set; }
        public string BienSoXe { get; set; }
        public int IdThe { get; set; }
        public string TenLoaiXe { get; set; }

        public DateTime? NgayXeVao { get; set; }

    }
}
