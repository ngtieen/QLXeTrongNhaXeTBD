using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.HDT
{
    public class TheXeDA_HDT
    {
        public TheXeDA_HDT(int idThe, string tenThe)
        {
            IdThe = idThe;
            TenThe = tenThe;
        }
        public TheXeDA_HDT(DataRow row)
        {
            IdThe = (int)row["idThe"];
            TenThe = (string)row["tenThe"];
        }

        public int IdThe { get; set; }
        public string TenThe { get; set; }
    }
}
