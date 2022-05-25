using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class Konaklama
    {
        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }
        public int OdaveyaCadirNo { get; set; }
        public int toplamFiyat { get; set; }
        public string konaklama_tur { get; set; }
    }
}
