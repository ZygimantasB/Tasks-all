using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_apskritimas_Uzduotis_1
{
    class Keturkampis
    {
        public double Keturkampio_apskaiciavimas;

        public Keturkampis (double keturkampio_apskaiciavimas)
        {
            Keturkampio_apskaiciavimas = keturkampio_apskaiciavimas;
        }

        public double Gauti_plota ()
        {
            double keturkampio_ploto_apskaiciavimas = Math.Pow(Keturkampio_apskaiciavimas, 2);
            return keturkampio_ploto_apskaiciavimas;
        }
        public double Gauti_ilgi()
        {
            double kvadrato_ilgio_apskaiciavimas = Keturkampio_apskaiciavimas + Keturkampio_apskaiciavimas + Keturkampio_apskaiciavimas + Keturkampio_apskaiciavimas;
            return kvadrato_ilgio_apskaiciavimas;
        }

    }
}
