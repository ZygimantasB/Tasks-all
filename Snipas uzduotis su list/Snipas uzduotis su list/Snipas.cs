using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_uzduotis_su_list
{
    class Snipas
    {
        public string Vardas;
        public int Kelinta_infiltracija { get; private set; }

        public Snipas (string vardas, int kelinta_operacija)
        {
            Vardas = vardas;
            Kelinta_infiltracija = kelinta_operacija;
        }

        public void Snipo_vardas ()
        {
            Console.WriteLine("Snipo vardas yra " + Vardas);
        }
        public void Infiltraciju_skaicius ()
        {
            Console.WriteLine(Kelinta_infiltracija += 1);
        }
    }
}
