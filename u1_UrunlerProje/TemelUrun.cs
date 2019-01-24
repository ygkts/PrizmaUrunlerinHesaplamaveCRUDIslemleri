using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_UrunlerProje
{
    class TemelUrun : IUrun
    {
        public string Ad { get; set;}
        public int Agirlik { get; set; }
        public int BirimFiyat { get;  set;}
        public int ID { get; set; }
        public int UrunFiyat { get; set; }
        public int Yukseklik { get; set; }
        public int FiyatHesapla(int BirimFiyat, int Hacim)
        {
            UrunFiyat = BirimFiyat * Hacim;
            return UrunFiyat;
        }

        public int GetFire()
        {
            return Convert.ToInt16(GetHacim() * 0.10);
        }

        public int GetHacim()
        {
            return GetTabanAlan() * Yukseklik;
        }

        public virtual int GetTabanAlan()
        {
            return Yukseklik * Yukseklik;
        }
    }
}
