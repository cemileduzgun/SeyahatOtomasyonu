using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using YazilimMimarisi.Rapor;
namespace YazilimMimarisi
{
    public partial class RaporEkrani : Form
    {
        public Ulasim ulasim { get; set; }
        public Konaklama konaklama { get; set; }
        public Musteri musteri { get; set; }
        public RaporEkrani()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // json rapor
            jsonReport json = new jsonReport();
            json.getir();
            MessageBox.Show("Rapor oluşturuldu");
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // html rapor
            ReportInfo reportInfo = new ReportInfo();
            reportInfo.musteri = musteri;
            reportInfo.konaklama = konaklama;
            reportInfo.ulasim = ulasim;

            ReportBuilder reportBuilder = new HtmlReport(reportInfo);
            ReportManager reportManager = new ReportManager(reportBuilder);

            string str = reportManager.build();
            File.WriteAllText(@"C:\Users\windows\source\Repos\SeyahatOtomasyonue\YazilimMimarisi\HtmlRepor.htm", str);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ReportInfo reportInfo = new ReportInfo();
            reportInfo.musteri = musteri;
            reportInfo.konaklama = konaklama;
            reportInfo.ulasim = ulasim;

            ReportBuilder reportBuilder = new HtmlReport(reportInfo);
            ReportManager reportManager = new ReportManager(reportBuilder);

            string str = reportManager.build();
            File.WriteAllText(@"C:\Users\windows\source\Repos\SeyahatOtomasyonue\YazilimMimarisi\XmlReport.xml", str);
        }
    }
}
