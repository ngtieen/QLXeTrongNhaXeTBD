using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class QLKiemTra
    {
        public bool CheckKTDB (string chuoiKT)
        {
            string ktdb = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in ktdb)
            {
                if(chuoiKT.Contains(item)) return true;
            }
            return false;
        }
    }
}
