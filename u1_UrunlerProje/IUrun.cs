using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_UrunlerProje
{
    interface IUrun
    {
        int ID { get; set; }
        string Ad { get; set; }
        int Yukseklik { get; set; }
        int Agirlik { get; set; }
        int BirimFiyat { get; set; }
        int UrunFiyat { get; set; }
        int GetTabanAlan();
        int GetHacim();
        int GetFire();
    }
}
