using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medis_uzduoties_pakartojis_klases
{
    class Medis
    {
        public double Medzio_sakos_skaicius { get; private set; }
        public double Medzio_augimas;
        
        public Medis ()
        {
            Medzio_sakos_skaicius = 0;
            Medzio_augimas = 0;
        }

        public void Kiek_paaugo_medis()
        {
            Medzio_augimas = Medzio_sakos_skaicius + 1;
        }
    }
}
