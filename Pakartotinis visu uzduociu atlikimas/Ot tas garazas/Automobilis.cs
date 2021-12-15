using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ot_tas_garazas
{
    class Automobilis
    {
        public string Modelis;
        public int Rida;
        public bool GalimaVaziuoti;

        public Automobilis(string modelis, int rida, bool galimavaziuoti)
        {
            GalimaVaziuoti = galimavaziuoti;

        }
        public Automobilis(string modelis, int rida)
        {
            GalimaVaziuoti = false;
        }
        public void Vaziuoti()
        {
            if (Rida >= 10)
            {
                Console.WriteLine($"{Modelis} automobilis sugedo, ji reikia tvarkyti jo rida yra {Rida}.");
            }
            else if (Rida <= 10 && Rida > 0)
            {
                Console.WriteLine($"{Modelis} automobilis gali vaziuoti, automobilio rida siuo metu yra {Rida}.");
            }
            else
            {
                Console.WriteLine("Klaidingi parametrai");
            }
        }
    }
}
