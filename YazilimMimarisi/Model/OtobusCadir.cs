using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Model
{
    class OtobusCadir: SoyutFabrika
    {
        Ulasim ulasim;
        Konaklama konaklama;
        Musteri musteri;

        public OtobusCadir(Ulasim ulasim, Konaklama konaklama, Musteri musteri)
        {
            this.ulasim = ulasim;
            this.konaklama = konaklama;
            this.musteri = musteri;
        }

        public override IKonaklama KonaklamaOlustur()
        {
            return new Cadir(konaklama, musteri);
        }

        public override IUlasim UlasimOlustur()
        {
            return new Otobus(ulasim, musteri);
        }
    }
}
