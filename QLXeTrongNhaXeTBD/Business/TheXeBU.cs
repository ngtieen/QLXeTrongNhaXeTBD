using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TheXeBU
    {
        QLKiemTra check = new QLKiemTra();
        public int IDTheXe;
        public string tenTheXe
        {
            get { return tenTheXe; }
            set
            {
                if (value != null) tenTheXe = value;
                else tenTheXe = "null";
            }
        }
    }
}
