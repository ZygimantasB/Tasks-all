using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzuotis_klases_pasikartio
{
    public class Keturkampis
    {
        public double P;

        public Keturkampis(double p)
        {
            P = p;
        }

        public double Keturkampio_plotas()
        {
            double keturkampio_apskaiciavimas = P * 4;
            return keturkampio_apskaiciavimas;
        }
    }
}
