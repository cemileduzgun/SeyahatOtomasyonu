using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class Ulasim
    {
        public string bulunduguYer { get; set; }
        public string gidecegiYer { get; set; }
        public DateTime gidisTarihi { get; set; }
        public DateTime donusTarihi { get; set; }

        public int aradakiKilometre { get; set; }
        public int aradakiSaat { get; set; }
        public int koltukNumara { get; set; }
        public int toplamFiyat { get; set; }

        
    }
}
