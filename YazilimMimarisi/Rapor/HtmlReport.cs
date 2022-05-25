using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Rapor
{
    public class HtmlReport : ReportBuilder
    {
        public HtmlReport(ReportInfo reportInfo): base(reportInfo)
        {

        }
        public override string rezervasyonFiyat()
        {
            var toplamFiyat = this.reportInfo.ulasim.toplamFiyat + this.reportInfo.konaklama.toplamFiyat;
            string format = string.Format("<h2>Toplam Fiyat: {0}</h2>", toplamFiyat.ToString());
            return format;
        }

        public override string seyehatDetayBilgi()
        {
            string format = string.Format("<h3>Konaklama Türü: {0}</h3>", this.reportInfo.ulasim.ulasim_tur);
            format += string.Format("<h3>Bulundugu yer: {0}</h3>", this.reportInfo.ulasim.gidecegiYer);
            format += string.Format("<h4>Gideceği Yer: {0}</h4>", this.reportInfo.ulasim.gidecegiYer);
            format += string.Format("<h5>Gidiş Tarihi: {0}</h5>", this.reportInfo.ulasim.gidisTarihi);
            format += string.Format("<h3>Dönüş Tarihi: {0}</h3>", this.reportInfo.ulasim.donusTarihi);
            format += string.Format("<h3>Koltuk No: {0}</h3>", this.reportInfo.ulasim.koltukNumara);
            format += string.Format("<h3>Konaklama Türü: {0}</h3>", this.reportInfo.konaklama.konaklama_tur);
            format += string.Format("<h3>Giriş Tarihi: {0}</h3>", this.reportInfo.konaklama.girisTarihi);
            format += string.Format("<h3>Çıkış Tarihi: {0}</h3>", this.reportInfo.konaklama.cikisTarihi);
            format += string.Format("<h3>Oda veya Çadır No: {0}</h3>", this.reportInfo.konaklama.OdaveyaCadirNo);
            
            return format;
        }

        public override string seyehatMusteriBilgi()
        {
            string format = string.Format("<h3>Ad Soyad: {0}</h3>", this.reportInfo.musteri.ad_soyad);
            format += string.Format("<h4>Kimlik No: {0}</h4>", this.reportInfo.musteri.kimlik_no);
            format += string.Format("<h4>Telefon No: {0}</h4>", this.reportInfo.musteri.telefon);
            return format;
        }
    }
}
