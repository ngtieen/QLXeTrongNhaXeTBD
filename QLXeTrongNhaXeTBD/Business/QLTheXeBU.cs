using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DataBase.HDT;

namespace Business
{
    public class QLTheXeBU : TheXeBU
    {
        TheXeBU TX = new TheXeBU();
        TheXeDA TXDT = new TheXeDA();

        public void TaoThemTheXe(int sl)
        {
            if (sl != null && sl != 0) { TXDT.ThemTheXe(sl); }
        }
        public void KiemTraSuaTheXe(int IDTheXe ,string value)
        {
            TXDT.SuaTheXe(IDTheXe, TX.tenTheXe);
        }
        public List<TheXeDA_HDT> HienThifql()
        {
            TheXeDA the = new TheXeDA();
            return the.HienthiTheXeInFQL();
        }
        public List<TheXeDA_HDT> HienthiTheXeInFSua(int idThe)
        {
            TheXeDA the = new TheXeDA();
            return the.HienthiTheXeInFSua(idThe);
        }
    }
}
