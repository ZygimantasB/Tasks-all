using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_uzduoties_pakartojimas
{
    class Snipas
    {
        public string Name;
        public int Kelinta_karta_infiltruojasi_snipas { get;  set; }

        public Snipas (string name, int kelinta_karta_infiltruojasi)
        {
            Name = name;
            Kelinta_karta_infiltruojasi_snipas = kelinta_karta_infiltruojasi;
        }
        public void Snipo_vardas ()
        {
            Console.WriteLine("Snipo vardas yra: " + Name);
        }
        public void Infiltraciju_skaicius()
        {
            Kelinta_karta_infiltruojasi_snipas = Kelinta_karta_infiltruojasi_snipas + 1; 
        }
    }
}
