using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_dar_vienas_bandymas
{
    class Snipas
    {
        public int Snipo_infiltracija;
        public string Snipo_vardas;

        public Snipas(string snipo_vardas, int snipo_infiltracija)
        {
            Snipo_infiltracija = snipo_infiltracija; 
            Snipo_vardas = snipo_vardas;
        }

        public void Snipo_duomenys()
        {
            Console.WriteLine("Snipo vardas yra " + Snipo_vardas);
        }

        public void Snipo_infiltraciju_skaicius ()
        {
            Console.WriteLine($"Snipas infiltravosi {Snipo_infiltracija += 1}");
        }

    }
}
