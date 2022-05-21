using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi.Model
{
    public interface IUlasim
    {
        //void Ulasim();
        KeyValuePair<Ulasim, Musteri> Ulasim();

    }
}
