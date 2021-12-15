using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Uzduotis_Geometrija_pakartojimas
{
    class Staciakampis :Figura, IGeometrija, IInformacija
    {
        public double Staciakampio_krastine_A;
        public double Staciakampio_krastine_B;

        public Staciakampis (double staciakampoio_krastine_A, double staciakampoio_krastine_B, string figurospavadinimas) : base (figurospavadinimas)
        {
            Staciakampio_krastine_A = staciakampoio_krastine_A;
            Staciakampio_krastine_B = staciakampoio_krastine_B;
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas yra:  {Figuros_pavadinimas}");
            Console.WriteLine($"Figuros krastine A yra:  {Staciakampio_krastine_A}");
            Console.WriteLine($"Figuros krastine B yra:  {Staciakampio_krastine_B}");
        }

        public double Perimetras(double staciakampoio_krastine_A, double staciakampoio_krastine_B)
        {
            double staciakampio_perimetras = 2 * (Staciakampio_krastine_A + Staciakampio_krastine_B);
            return staciakampio_perimetras;
        }

        public double Plotas(double staciakampoio_krastine_A, double staciakampoio_krastine_B)
        {
            double staciakampio_plotas = Staciakampio_krastine_A * Staciakampio_krastine_B;
            return staciakampio_plotas;
        }
    }

}
