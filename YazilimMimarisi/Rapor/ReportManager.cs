using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Rapor
{
    public class ReportManager
    {
        private ReportBuilder builder;

        public ReportManager(ReportBuilder reportBuilder)
        {
            builder = reportBuilder;
        }

        public string build()
        {
            string sonuc = builder.build();
            return sonuc;
        }
    }
}
