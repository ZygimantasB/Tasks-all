using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimas_užduoties_pakartojimas
{
    class Trikampis
    {
        public double A;
        public double B;
        public double C;
        public double H_aukstine;
        public double J_aukstine;
        public double P;

        public Trikampis(double a, double b, double c, double h_aukstine, double j_aukstine, double p)
        {
            A = a;
            B = b;
            C = c;
            H_aukstine = h_aukstine;
            J_aukstine = j_aukstine;
            P = p;
        }
        public double Pusperimetrio_apskaiciavimas()
        {
            double perimetro_formule = (A + B + C) / 2;
            return perimetro_formule;
        }
        public double Trikampio_aukstine()
        {
            double trikampio_aukstines_apskaiciavimas = 0.5 * (H_aukstine * J_aukstine);
            return trikampio_aukstines_apskaiciavimas;
        }
        public double Herono_formule()
        {
            double herono_formules_apskaiciavimas = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return herono_formules_apskaiciavimas;
        }

    }
}
