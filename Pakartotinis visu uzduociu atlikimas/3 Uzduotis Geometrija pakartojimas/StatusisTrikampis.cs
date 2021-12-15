using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Uzduotis_Geometrija_pakartojimas
{
    class StatusisTrikampis : Figura, IGeometrija, IInformacija
    {
        public double Krastine_A;
        public double Krastine_B;
        public double Krastine_C;

        public StatusisTrikampis(double krastine_a, double krastine_b, double krastine_c, string figurospavadinimas) : base(figurospavadinimas)
        {
            Krastine_A = krastine_a;
            Krastine_B = krastine_b;
            Krastine_C = krastine_c;
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas yra: {Figuros_pavadinimas}");
            Console.WriteLine($"Figuros krastine A yra: {Krastine_A}");
            Console.WriteLine($"Figuros krastine B yra: {Krastine_B}");
            Console.WriteLine($"Figuros krastine C yra: {Krastine_C}");
        }

        public double Perimetras(double krastine_a, double krastine_b, double krastine_c)
        {
            double statusisTrikampis_perimetras = Krastine_A + Krastine_B + Krastine_C;
            return statusisTrikampis_perimetras;
        }

        public double Plotas(double krastine_a, double krastine_b)
        {
            double statusis_trikapis_plotas = (Krastine_A * Krastine_B) / 2;
            return statusis_trikapis_plotas;
        }
    }
}
