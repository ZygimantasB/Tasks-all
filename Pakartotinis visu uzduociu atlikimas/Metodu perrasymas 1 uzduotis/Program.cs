using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_perrasymas_1_uzduotis
{
    class Progra
    {
        static void Main(string[] args)
        {
            List<Zmogus> zmones = new List<Zmogus>();

            zmones.Add(new Zmogus("Paprastas", "Zmogus"));
            zmones.Add(new Pilietis("NePaprastas", "Zmogus", "AK"));
            zmones.Add(new Gyventojas("Special", "Gyventojas", "AK2", "kaunas"));

            foreach(Zmogus zmogus in zmones)
            {
                zmogus.Info();
            }
            Console.Read();
        }
    }
}
