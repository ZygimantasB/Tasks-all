using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_snipas
{
    class Snipas
    {
        public int Snipo_infiltracija { get; private set; }

        public Snipas ()
        {
            Snipo_infiltracija = 0;
        }

        public int Kelinta_infiltracija ()
        {
            Snipo_infiltracija += 1;

            return Snipo_infiltracija;
        }
    }
}
