using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Model
{
    class Ucak : IUlasim
    {
        Ulasim ulasim;
        Musteri musteri;
        public Ucak(Ulasim ulasim, Musteri musteri)
        {
            this.ulasim = ulasim;
            this.musteri = musteri;
        }
        public KeyValuePair<Ulasim, Musteri> Ulasim()
        {
            Console.WriteLine($"Musteri: {musteri.kimlik_no}");
            Console.WriteLine($"bulundugu yer: {ulasim.bulunduguYer}");
            var pair = new KeyValuePair<Ulasim, Musteri>(ulasim, musteri);
            return pair;
        }
    }
}
