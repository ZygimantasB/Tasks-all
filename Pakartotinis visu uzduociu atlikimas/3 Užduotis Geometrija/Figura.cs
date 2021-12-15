using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Užduotis_Geometrija
{
    public class Figura : IGeometrija
    {
        public string Pavadinimas { get; }

        public Figura(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public void FigurosPavadinimas(string pavadinimas)
        {
            Console.WriteLine($"Figuros pavadinimas yra {Pavadinimas}");
        }

        public double Plotas()
        {
            throw new NotImplementedException();
        }

        public double Perimetras()
        {
            throw new NotImplementedException();
        }
    }
}
