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
    public partial class FrmDortgen : Form
    {
        public FrmDortgen()
        {
            InitializeComponent();
        }
        DortgenProfil secilenProfil;
        List<DortgenProfil> dortgenList = new List<DortgenProfil>();
        private void btnKupEkle_Click(object sender, EventArgs e)
        {
            DortgenProfil prof = new DortgenProfil();
            prof.ID = Donustur(textBoxID.Text,"ID");
            prof.Ad = textBoxAd.Text;
            prof.Agirlik = Donustur(textBoxAgiirlik.Text,"Ağırlık");
            prof.UzunKenar = Donustur(textBoxUzunKenar.Text,"Uzun Kenar");
            prof.KisaKenar = Donustur(textBoxKisaKenar.Text,"Kısa Kenar");
            prof.Yukseklik = Donustur(textBoxYukseklik.Text,"Yükseklik");
            prof.BirimFiyat = Donustur(textBoxBFiyat.Text,"Birim Fİyat");

            prof.UrunFiyat = prof.FiyatHesapla(prof.BirimFiyat, prof.GetHacim());

            Goster();

            int txtid = Convert.ToInt32(textBoxID.Text);
            DortgenProfil bul = dortgenList.Find(x => x.ID == txtid);

            if (bul == null || bul.ID != txtid)
            {
                listBoxDortgen.Items.Add(prof);
                dortgenList.Add(prof);
            }
            else
            {
                MessageBox.Show("Eklenemez...");
            }
        }

        private void btnKupGuncelle_Click(object sender, EventArgs e)
        {
            secilenProfil = (DortgenProfil)listBoxDortgen.SelectedItem;
            secilenProfil.ID = Convert.ToInt32(textBoxID.Text);
            secilenProfil.Ad = textBoxAd.Text;
            secilenProfil.Agirlik = Convert.ToInt32(textBoxAgiirlik.Text);
            secilenProfil.UzunKenar = Convert.ToInt32(textBoxUzunKenar.Text);
            secilenProfil.KisaKenar = Convert.ToInt32(textBoxKisaKenar.Text);
            secilenProfil.Yukseklik = Convert.ToInt32(textBoxYukseklik.Text);
            secilenProfil.BirimFiyat = Convert.ToInt32(textBoxBFiyat.Text);

            secilenProfil.UrunFiyat = secilenProfil.FiyatHesapla(secilenProfil.BirimFiyat, secilenProfil.GetHacim());
            Goster();


        }

        private void btnKupListele_Click(object sender, EventArgs e)
        {
            labelListelensin.Text = listBoxDortgen.SelectedItem.ToString();
        }

        private void btnKupSil_Click(object sender, EventArgs e)
        {
            secilenProfil = (DortgenProfil)listBoxDortgen.SelectedItem;
            dortgenList.Remove(secilenProfil);
            Goster();
        }
        private void Goster()
        {
            listBoxDortgen.Items.Clear();
            foreach (DortgenProfil item in dortgenList)
            {
                listBoxDortgen.Items.Add(item);
            }
        }
        private int Donustur(string text, string ozellikAd)
        {
            try
            {
                return Convert.ToInt16(text);
            }
            catch (Exception)
            {
                MessageBox.Show(ozellikAd + " numerik girilmedi" );
                return 0;
            }
        }
    }
}
