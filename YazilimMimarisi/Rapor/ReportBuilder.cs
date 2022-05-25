using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Rapor
{
    public abstract class ReportBuilder
    {
        protected ReportInfo reportInfo;

        public ReportBuilder(ReportInfo reportInfo)
        {
            this.reportInfo = reportInfo;
        }
        
        public string build()
        {
            string cikti = seyehatMusteriBilgi();
            cikti += seyehatDetayBilgi();
            cikti += rezervasyonFiyat();

            return cikti;
        }

        public abstract string seyehatMusteriBilgi();
        public abstract string seyehatDetayBilgi();
        public abstract string rezervasyonFiyat();
    }
}
