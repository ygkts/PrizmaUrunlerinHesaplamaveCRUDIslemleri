using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_UrunlerProje
{
    class KupProfil : TemelUrun
    {
        public override string ToString()   // Arka plandaki tostring metodu virtual tanımlanmıştır. Bizde bunu override ettik.
        {
            return Ad;
        }

    }
}
