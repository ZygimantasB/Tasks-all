using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimas_užduoties_pakartojimas
{
    class Kvadratas
    {
        public double A;
        public double A_perimetras;

        public Kvadratas(double a, double a_perimetras)
        {
            A = a;
            A_perimetras = a_perimetras;
        }
        public double Kvadrato_apskaiciavimas()
        {
            double ploto_apskaiciavimas = Math.Pow(A, 2);
            return ploto_apskaiciavimas;
        }
        public double Kvadrato_perimetras()
        {
            double perimetro_apskaciavimas = 4 * A_perimetras;
            return perimetro_apskaciavimas;
        }

    }
}
