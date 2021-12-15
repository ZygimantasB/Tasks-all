using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzuotis_klases_pakartojimas
{
    public class Apskirtimias
    {
        public double R;

        public Apskirtimias(double r)
        {
            R = r;
        }

        public double Apskritimo_plotas()
        {
            double apskaiciavimas = Math.PI * Math.Pow(R, 2);
            return apskaiciavimas;
        }

    }
}

