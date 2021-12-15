using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zmogus> zmones = new List<Zmogus>();
            zmones.Add(new Zmogus("Paprastas", "Zmogus"));
            zmones.Add(new Pilietis("Paprastas", "Pileitis", "AK"));
            zmones.Add(new Gyventojas("Special", "Gyventojas", "AK2", "Kaunas"));

            foreach (Zmogus zmogus in zmones)
            {
                zmogus.Info();
            }

            Console.Read();
        }
    }
}
