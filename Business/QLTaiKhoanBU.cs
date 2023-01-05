using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class QLTaiKhoanBU : TaiKhoanBU
    {
        public bool DangNhap(string username, string passwword)
        {
            return TaiKhoanDA.Instance.DangNhap(username, passwword);
        }
    }
}
