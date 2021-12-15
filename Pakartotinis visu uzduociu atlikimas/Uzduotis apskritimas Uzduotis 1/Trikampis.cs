using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_apskritimas_Uzduotis_1
{
    class Trikampis
    {
        public double Trikampio_apskaiciavimas_a;
        public double Trikampio_apskaiciavimas_b;
        public double Trikampio_apskaiciavimas_c;


        public Trikampis (double trikampio_apskaiciavimas_a, double trikampio_apskaiciavimas_b, double trikampio_apskaiciavimas_c)
        {
            Trikampio_apskaiciavimas_a = trikampio_apskaiciavimas_a;
            Trikampio_apskaiciavimas_b = trikampio_apskaiciavimas_b;
            Trikampio_apskaiciavimas_c = trikampio_apskaiciavimas_c;
        }
        public double Trikampio_perimetras ()
        {
            double trikampio_perimetras = Trikampio_apskaiciavimas_a + Trikampio_apskaiciavimas_b + Trikampio_apskaiciavimas_c;
            return trikampio_perimetras;
        }
        public double Trikampio_pusperimetris ()
        {
            double trikampio_pusperimetris = (Trikampio_apskaiciavimas_a + Trikampio_apskaiciavimas_b + Trikampio_apskaiciavimas_c) / 2;
            return trikampio_pusperimetris;
        }
    }
}
