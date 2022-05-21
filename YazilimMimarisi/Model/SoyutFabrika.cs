using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Model
{
    public abstract class SoyutFabrika
    {
        public abstract IUlasim UlasimOlustur();
        public abstract IKonaklama KonaklamaOlustur();

    }
}
