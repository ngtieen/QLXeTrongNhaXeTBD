using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.HDT
{
    public class TaiKhoanDA_HDT
    {
        public TaiKhoanDA_HDT(string username, string passWord, string dispalyName, int type)
        {
            Username = username;
            PassWord = passWord;
            DispalyName = dispalyName;
            Type = type;
        }
        public TaiKhoanDA_HDT(DataRow row)
        {
            this.Username = (string)row["userName"];
            this.PassWord = (string)row["passWord"];
            this.DispalyName = (string)row["displayName"];
            this.Type = (int)row["type"];
        }


        public string Username { get; set; }
        public string PassWord { get; set; }
        public string DispalyName { get; set; }
        public int Type { get; set; }
    }
}
