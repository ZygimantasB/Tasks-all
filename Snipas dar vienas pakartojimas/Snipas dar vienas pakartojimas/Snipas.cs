using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_dar_vienas_pakartojimas
{
    class Snipas
    {
        public string Vardas;
        public int Kelinta_karta_snipas_infiltruojasi;

        public Snipas(string vardas, int kelinta_karta_snipas_infiltruojasi)
        {
            Vardas = vardas;
            Kelinta_karta_snipas_infiltruojasi = kelinta_karta_snipas_infiltruojasi;
        }

        public void Snipo_vardas_yra ()
        {
            Console.WriteLine("Šnipo vardas yra " + Vardas);
        }
        public void Kelinta_infiltracija ()
        {
            Console.WriteLine("Snipas infiltravosi " + Kelinta_karta_snipas_infiltruojasi++ + " Karta(us)");
        }
    }
}
