using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Užduotis_Geometrija
{
    class Kvadratas :Figura, IGeometrija, IInformacija
    {
        public readonly double KvadratoKrastine;

        public Kvadratas(double kvadratoKrastine, string pavadinimas) : base(pavadinimas)
        {
            KvadratoKrastine = kvadratoKrastine;
        }

        public double Kvadrato_plotas(double kvadrato_krastine)
        {
            double kvadrato_plotas_formule = Math.Pow(kvadrato_krastine, 2);
            return kvadrato_plotas_formule;
        }
        public double Kvadrato_perimetras (double kvadrato_krastine)
        {
            double kvadrato_perimetras_formule = kvadrato_krastine + kvadrato_krastine + kvadrato_krastine + kvadrato_krastine;
            return kvadrato_perimetras_formule;
        }

        public double Plotas()
        {
            throw new NotImplementedException();
        }

        public double Perimetras()
        {
            throw new NotImplementedException();
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas {Pavadinimas}");
            Console.WriteLine($"Figura turi {Pavadinimas}, kuri yra {KvadratoKrastine}");
        }
    }
}
