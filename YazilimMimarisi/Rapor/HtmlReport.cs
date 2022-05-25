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
            string format = string.Format("<h3>Bulundugu yer: {0}</h3>", this.reportInfo.ulasim.bulunduguYer);
            format += string.Format("<h4>Gideceği Yer: {0}</h4>", this.reportInfo.ulasim.gidecegiYer);
            return format;
        }

        public override string seyehatMusteriBilgi()
        {
            string format = string.Format("<h3>Ad Soyad: {0}</h3>", this.reportInfo.musteri.ad_soyad);
            format += string.Format("<h4>Kimlik No: {0}</h4>", this.reportInfo.musteri.kimlik_no);
            return format;
        }
    }
}
