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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(ulasimTuru.SelectedItem.ToString());
            string secilenUlasimTuru = ulasimTuru.SelectedItem.ToString();
            string secilenKonaklamaTuru = konaklamaTuru.SelectedItem.ToString();

            Musteri musteri = new Musteri();
            musteri.kimlik_no = "2397";

            
            Ulasim ulasim = new Ulasim {
                bulunduguYer = tbBulunduguYer.Text,
                gidecegiYer = tbGidecegiYer.Text,
                gidisTarihi = gidisTarihi.Value,
                donusTarihi = donusTarihi.Value
            };

            Konaklama konaklama = new Konaklama
            {
                girisTarihi = girisTarihi.Value,
                cikisTarihi = cikisTarihi.Value
            };

            if(secilenUlasimTuru == "Uçak")
            {
                if(secilenKonaklamaTuru == "Otel")
                {
                    Seyehat seyehat = new Seyehat(new UcakOtel(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
                else if(secilenKonaklamaTuru == "Çadır")
                {
                    Seyehat seyehat = new Seyehat(new UcakCadir(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
            }
            else if (secilenUlasimTuru == "Otobüs")
            {
                if (secilenKonaklamaTuru == "Otel")
                {
                    Seyehat seyehat = new Seyehat(new OtobusOtel(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
                else if (secilenKonaklamaTuru == "Çadır")
                {
                    Seyehat seyehat = new Seyehat(new OtobusCadir(ulasim, konaklama, musteri));
                    seyehat.olustur();
                }
            }
        }

        
    }
}
