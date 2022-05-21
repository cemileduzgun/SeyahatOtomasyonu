using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Model
{
    class Otel : IKonaklama
    {
        Konaklama konaklama;
        Musteri musteri;
        public Otel(Konaklama konaklama, Musteri musteri)
        {
            this.konaklama = konaklama;
            this.musteri = musteri;
        }

        public KeyValuePair<Konaklama, Musteri> Konaklama()
        {
            var pair = new KeyValuePair<Konaklama, Musteri>(konaklama, musteri);
            return pair;
        }
    }
}
