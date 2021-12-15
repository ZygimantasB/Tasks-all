using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Uzduotis_Geometrija_pakartojimas
{
    class Kvadratas : Figura, IGeometrija, IInformacija
    {
        public double Kvadrato_krastine;

        public Kvadratas(double kvadrato_krastine, string figurospavadinimas) : base (figurospavadinimas)
        {
            Kvadrato_krastine = kvadrato_krastine;
            Figuros_pavadinimas = figurospavadinimas;
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas yra: {Figuros_pavadinimas}");
            Console.WriteLine($"Figuros krastine yra: {Figuros_pavadinimas}");
        }

        public double Perimetras(double kvadrato_krastine)
        {
            double kvadrato_perimetras = Kvadrato_krastine * 4;
            return kvadrato_perimetras;
        }

        public double Plotas(double kvadrato_krastine)
        {
            double kvadrato_plotas = Math.Pow(Kvadrato_krastine, 2);
            return kvadrato_plotas;
        }
    }
}
