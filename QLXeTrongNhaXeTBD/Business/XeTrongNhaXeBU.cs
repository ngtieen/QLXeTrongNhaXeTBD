using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Business
{
    public class XeTrongNhaXeBU : IXeBU
    {
        public int IDXe { get; set; }
        public DateOnly NgayXeVao { get; set; }
        public DateOnly NgayXeRa { get; set; }
        public int IDXeOKhu { get; set; }
        public string BienSoXe { get; set; }
        public int IDTheXe { get; set; }
        public int IDLoaiXe { get; set; }
    }
}
