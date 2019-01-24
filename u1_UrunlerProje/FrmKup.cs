using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u1_UrunlerProje
{
    public partial class FrmKup : Form
    {
        public FrmKup()
        {
            InitializeComponent();
        }
        KupProfil secilenProfil;
        List<KupProfil> kupProfilList = new List<KupProfil>();
        private void btnKupEkle_Click(object sender, EventArgs e)
        {
            KupProfil kup = new KupProfil();
            kup.ID = Donustur(textBoxID.Text, "Id");
            kup.Agirlik = Donustur(textBoxAgirlik.Text, "Ağırlık");
            kup.Yukseklik = Donustur(textBoxKenar.Text, "Kenar");
            kup.BirimFiyat = Donustur(textBoxBFiyat.Text, "Birim Fiyat");
            kup.Ad = textBoxAD.Text;

            kup.UrunFiyat = kup.FiyatHesapla(kup.BirimFiyat, kup.GetHacim());

            Goster();

            int txtID = Convert.ToInt32(textBoxID.Text);
            KupProfil bul = kupProfilList.Find(x=>x.ID == txtID);   // listede bulunan id değeri txtid'ye eşitse yani bul = null

            if (bul == null) // bul = null demek. yani listemde yok daha önce eklenmemiş. O halde ekleyebiliriz.
            {
                listBoxKup.Items.Add(kup);
                kupProfilList.Add(kup);
            }
            else if (bul.ID != txtID)
            {
                listBoxKup.Items.Add(kup);
                kupProfilList.Add(kup);
            }
            else // bul != null demek. yani listemde var daha önce eklenmiş. O halde eklemiyoruz ve mesaj veriyoruz.
            {
                MessageBox.Show("Eklenemez..");
            }

        }
        private void btnKupGuncelle_Click(object sender, EventArgs e)
        {
            secilenProfil = (KupProfil)listBoxKup.SelectedItem;   // listbox'taki seçili satırı alıyor.
            secilenProfil.Ad = textBoxAD.Text;
            secilenProfil.Agirlik = Convert.ToInt32(textBoxAgirlik.Text);
            secilenProfil.BirimFiyat = Convert.ToInt32(textBoxBFiyat.Text);
            secilenProfil.Yukseklik = Convert.ToInt32(textBoxKenar.Text);

            secilenProfil.UrunFiyat = secilenProfil.FiyatHesapla(secilenProfil.BirimFiyat, secilenProfil.GetHacim());

            Goster();

        }
        private void btnKupListele_Click(object sender, EventArgs e)
        {
            labelListelensin.Text = listBoxKup.SelectedItem.ToString();
        }
        private void btnKupSil_Click(object sender, EventArgs e)
        {
            secilenProfil = (KupProfil)listBoxKup.SelectedItem; // listbox'taki seçili satırı alıyor ve nesneye atıyor
            kupProfilList.Remove(secilenProfil);
            Goster();
        }
        private int Donustur(string text, string ozellikAd)
        {
            try
            {
                return Convert.ToInt16(text); 
            }
            catch (Exception)
            {
                MessageBox.Show(ozellikAd + " Numerik Girilmedi..");
                return 0;
            }
        }
        private void Goster()   // listbox'ı doldurma
        {
            listBoxKup.Items.Clear();
            foreach (KupProfil item in kupProfilList)
            {
                listBoxKup.Items.Add(item);
            }
        }

        private void listBoxKup_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listbox'daki seçtiğim index her değiştiğinde aşağıdaki işlemler olacaktır.
            secilenProfil = (KupProfil)listBoxKup.SelectedItem;
            textBoxHacim.Text = Convert.ToString(secilenProfil.GetHacim());
            textBoxFire.Text = secilenProfil.GetFire().ToString();
            textBoxID.Text = secilenProfil.ID.ToString();
            textBoxAD.Text = secilenProfil.Ad;
            textBoxBFiyat.Text = secilenProfil.BirimFiyat.ToString();
            textBoxKenar.Text = secilenProfil.Agirlik.ToString();
            textBoxAgirlik.Text = secilenProfil.Agirlik.ToString();

            textBoxFiyat.Text = secilenProfil.FiyatHesapla(secilenProfil.BirimFiyat, secilenProfil.GetHacim()).ToString();
        }
    }
}
