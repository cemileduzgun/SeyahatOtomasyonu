using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Model
{
    class Otobus : IUlasim
    {
        Ulasim ulasim;
        Musteri musteri;
        public Otobus(Ulasim ulasim, Musteri musteri)
        {
            this.ulasim = ulasim;
            this.musteri = musteri;
        }

        public KeyValuePair<Ulasim, Musteri> Ulasim()
        {
            var pair = new KeyValuePair<Ulasim, Musteri>(ulasim, musteri);
            return pair;
        }
    }
}
