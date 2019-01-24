using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_UrunlerProje
{
    class SilindirProfil : TemelUrun
    {
        public int YariCap { get; set; }
        public override int GetTabanAlan()
        {
            return Convert.ToInt32(YariCap * YariCap * Math.PI);
        }
    }
}
