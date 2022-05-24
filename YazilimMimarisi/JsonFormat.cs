using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace YazilimMimarisi
{
    public class JsonFormat
    {
        private readonly string dosyaYolu = $"C:\\Users\\windows\\Source\\Repos\\SeyahatOtomasyonuk\\YazilimMimarisi\\Seyehat.json";
        public List<Ulasim> ulasim { get; set; }
        public List<Konaklama> konaklama { get; set; }
        public List<Musteri> musteri { get; set; }

        public int toplamFiyat { get; set; }

        public void seyehat()
        {
            try
            {
                string sorgu = "SELECT * FROM tblRezervasyon r INNER JOIN MusteriBilgisi m ON r.kimlik_no = m.kimlik_no ";

                var seyehatJson = DbManager.Instance().seyehat(sorgu);

                var jsonToWrite = JsonConvert.SerializeObject(seyehatJson, Formatting.Indented);

                using (var writer = new StreamWriter(dosyaYolu))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch(Exception e)
            {
                //ignored
            }
        }

    }
}
