using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Užduotis_Geometrija
{
    class StatusisTrikampis : Figura, IGeometrija, IInformacija
    {
        public readonly double Krastine_a;
        public double Krastine_b { get; }

        public readonly double Krastine_c;

        public StatusisTrikampis(double krastine_a, double krastine_b, double krastine_c, string pavadinimas) : base(pavadinimas) 
        {
            Krastine_a = krastine_a;
            Krastine_b = krastine_b;
            Krastine_c = krastine_c;
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas {Pavadinimas}");
            Console.WriteLine($"Figura {Pavadinimas} turi krastine a, kuri yra {Krastine_a}, b kuri yra {Krastine_b}, c kuri yra {Krastine_c} ");
        }

        public double Perimetras()
        {
            throw new NotImplementedException();
        }

        public double Plotas()
        {
            throw new NotImplementedException();
        }

        public double Statusis_trikampis_plotas (double krastine_a, double krastine_b)
        {
            double statusis_trikapis_formule_plotas = (krastine_a * krastine_b) / 2;
            return statusis_trikapis_formule_plotas;
        }
        public double Statusis_trikapis_perimetras (double krastine_a, double krastine_b, double krastine_c)
        {
            double statusis_trikampis_perimetro_formule = krastine_a + krastine_b + krastine_c;
            return statusis_trikampis_perimetro_formule;
        }
    }
}
