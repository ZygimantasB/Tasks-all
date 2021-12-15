using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Užduotis_Geometrija
{
    class Staciakampis : Figura, IGeometrija, IInformacija
    {
        public readonly double Staciakampis_a_krastine;
        public readonly double Staciakampis_b_krastine;

        public Staciakampis (double staciakampis_a_krastine, double staciakampis_b_krastine, string pavadinimas) : base (pavadinimas)
        {
            Staciakampis_a_krastine = staciakampis_a_krastine;
            Staciakampis_b_krastine = staciakampis_b_krastine;
        }

        public double Perimetras()
        {
            throw new NotImplementedException();
        }

        public double Plotas()
        {
            throw new NotImplementedException();
        }

        public double Staciakampis_plotas(double staciakampis_a_krastine, double staciakampis_b_krastine)
        {
            double staciakampio_plotas_formule = staciakampis_a_krastine * staciakampis_b_krastine;
            return staciakampio_plotas_formule;
        }
        public double Staciakampio_perimetras (double staciakampis_a_krastine, double staciakmpis_b_krastine)
        {
            double staciakampio_perimetras = 2 * (staciakampis_a_krastine + staciakmpis_b_krastine);
            return staciakampio_perimetras;
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas {Pavadinimas}");
            Console.WriteLine($"Figura {Pavadinimas} turi parametrus Krastine a {Staciakampis_a_krastine} ir krastine b {Staciakampis_b_krastine}");
        }
    }
}
