using YazilimMimarisi.Model;

namespace YazilimMimarisi
{
    public class Seyehat
    {
        private SoyutFabrika soyutFabrika;
        private IUlasim ulasim;
        private IKonaklama konaklama;

        public Seyehat(SoyutFabrika soyutFabrika)
        {
            this.soyutFabrika = soyutFabrika;
            ulasim = this.soyutFabrika.UlasimOlustur();
            konaklama = this.soyutFabrika.KonaklamaOlustur();
        }

        public void olustur()
        {
            var ulasimPair = ulasim.Ulasim();
            var konaklamaPair = konaklama.Konaklama();

            var ulasimEkle = ulasimPair.Key;
            var konaklamaEkle = konaklamaPair.Key;
            var musteri = ulasimPair.Value;
            string sorgu = "INSERT INTO tblRezervasyon (gidis_tarihi_ulasim, donus_tarihi_ulasim, bulundugu_yer_ulasim, gidecegi_yer_ulasim, kimlik_no, giris_tarihi_konaklama, cikis_tarihi_konaklama) " +
                $"values ('{ulasimEkle.gidisTarihi.ToString("yyyy-MM-dd hh:mm:ss")}', '{ulasimEkle.donusTarihi.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                $"'{ulasimEkle.bulunduguYer}', '{ulasimEkle.gidecegiYer}', '{musteri.kimlik_no}', '{konaklamaEkle.girisTarihi.ToString("yyyy-MM-dd hh:mm:ss")}', '{konaklamaEkle.cikisTarihi.ToString("yyyy-MM-dd hh:mm:ss")}')";

            DbManager.Instance().veritabaniKomut(sorgu);
        }

        
    }
}