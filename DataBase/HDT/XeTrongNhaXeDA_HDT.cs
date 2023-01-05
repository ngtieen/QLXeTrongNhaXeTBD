using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.HDT
{
    public class XeTrongNhaXeDA_HDT
    {

        public XeTrongNhaXeDA_HDT(DataRow row)
        {
            IdXe = (int)row["id"];
            NgayXeVao = (DateTime?)row["Ngày vào"];
            var DateCheckOutTepm = row["Ngày ra"];
            if (DateCheckOutTepm.ToString() != "")
                this.NgayXeRa = (DateTime?)DateCheckOutTepm;
            TenKhuXe = (string)row["Tên khu xe"];
            BienSoXe = (string)row["Biển số"];
            IdThe = (int)row["ID Thẻ"];
            TenLoaiXe = (string)row["Tên Loại xe"];
            var tongTien = row["Tổng Tiền"];
            if (tongTien.ToString() != "")
                this.TongTien = (int?)tongTien;
            //TongTien = (int?)row["Tổng Tiền"];
        }

        public XeTrongNhaXeDA_HDT(int idXe, string tenKhuXe, string bienSoXe, int idThe, string tenLoaiXe, DateTime? ngayXeVao, DateTime? ngayXeRa, int tongTien)
        {
            IdXe = idXe;
            TenKhuXe = tenKhuXe;
            BienSoXe = bienSoXe;
            IdThe = idThe;
            TenLoaiXe = tenLoaiXe;
            NgayXeVao = ngayXeVao;
            NgayXeRa = ngayXeRa;
            TongTien = tongTien;
        }

        public int IdXe { get; set; }
        public string TenKhuXe { get; set; }
        public string BienSoXe { get; set; }
        public int IdThe { get; set; }
        public string TenLoaiXe { get; set; }

        public DateTime? NgayXeVao { get; set; }
        public DateTime? NgayXeRa { get; set; }
        public int? TongTien { get;set; }

    }
}
