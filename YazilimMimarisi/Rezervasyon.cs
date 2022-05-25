using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimMimarisi.Model;
namespace YazilimMimarisi
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        int cadirGecefiyat = 50;
        int otelGecefiyat = 100;
        int ucakSaatFiyat = 200;
        int otobusKmFiyat = 1;

        public Musteri musteriBilgi { get; set; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
           
            string secilenUlasimTuru = ulasimTuru.SelectedItem.ToString();
            string secilenKonaklamaTuru = konaklamaTuru.SelectedItem.ToString();

            Musteri musteri = new Musteri();
            musteri.ad_soyad = musteriBilgi.ad_soyad;
            musteri.kimlik_no = musteriBilgi.kimlik_no;
            musteri.telefon = musteriBilgi.telefon;


            var gidisTarihiKonaklama = gidisTarihi.Value;
            var cikisTarihiKonaklama = cikisTarihi.Value;
            var gunFarki = cikisTarihiKonaklama.Day - gidisTarihiKonaklama.Day;


            Ulasim ulasim = new Ulasim {
                ulasim_tur= ulasimTuru.Text,
                bulunduguYer = tbBulunduguYer.Text,
                gidecegiYer = tbGidecegiYer.Text,
                gidisTarihi = gidisTarihi.Value,
                donusTarihi = donusTarihi.Value,
                koltukNumara=Convert.ToInt32(KoltukNumara_txt.Text)

            };

            Konaklama konaklama = new Konaklama
            {
                girisTarihi = girisTarihi.Value,
                cikisTarihi = cikisTarihi.Value,
                OdaveyaCadirNo = Convert.ToInt32(oda_cadir_numara.Text),
                konaklama_tur = konaklamaTuru.Text
            };

            if(secilenUlasimTuru == "Uçak")
            {
                var ucakBilet = Convert.ToInt32(aradakiSaat_txt.Text) * ucakSaatFiyat;
                ulasim.toplamFiyat = ucakBilet;
                if(secilenKonaklamaTuru == "Otel")
                {
                    int otelFiyat = otelGecefiyat * gunFarki;
                    konaklama.toplamFiyat = otelFiyat;
                    Seyehat seyehat = new Seyehat(new UcakOtel(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
                else if(secilenKonaklamaTuru == "Çadır")
                {
                    int cadirFiyat = cadirGecefiyat * gunFarki;
                    konaklama.toplamFiyat = cadirFiyat;
                    Seyehat seyehat = new Seyehat(new UcakCadir(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
            }
            else if (secilenUlasimTuru == "Otobüs")
            {
                var otobusBilet = Convert.ToInt32(aradaKilometre_txt.Text) *otobusKmFiyat ;
                ulasim.toplamFiyat = otobusBilet;
                if (secilenKonaklamaTuru == "Otel")
                {
                    int otelFiyat = otelGecefiyat * gunFarki;
                    konaklama.toplamFiyat = otelFiyat;
                    Seyehat seyehat = new Seyehat(new OtobusOtel(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
                else if (secilenKonaklamaTuru == "Çadır")
                {
                    int cadirFiyat = cadirGecefiyat * gunFarki;
                    konaklama.toplamFiyat = cadirFiyat;
                    Seyehat seyehat = new Seyehat(new OtobusCadir(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
            }

            RaporEkrani raporEkrani = new RaporEkrani();
            raporEkrani.ulasim = ulasim;
            raporEkrani.konaklama = konaklama;
            raporEkrani.musteri = musteri;
            
            MessageBox.Show("Rezervasyonunuz Oluşturulmuştur.");
            raporEkrani.Show();
        }

        private void ulasimTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ulasimTuru.Text == "Uçak")
            {
                PanelOtobus.Hide();
            }
            else
            {
                PanelOtobus.Show();
            }

            if (ulasimTuru.Text == "Otobüs")
            {
                PanelUcak.Hide();
            }
            else
            {
                PanelUcak.Show();
            }

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RaporEkrani raporEkrani = new RaporEkrani();
            raporEkrani.Show();
            this.Hide();
        }
    }
}
