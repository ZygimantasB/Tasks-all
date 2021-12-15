using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_užduotis_spelioniu_žaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pabandykite atspėti skaičių nuo 1 iki 10");
            int slaptas_skaicius = int.Parse(Console.ReadLine());

            while (slaptas_skaicius != 5)
            {
                Console.WriteLine("Įrašykite skaiciu:\n");
                slaptas_skaicius = int.Parse(Console.ReadLine());

                if (slaptas_skaicius > 5 && slaptas_skaicius <= 10)
                {
                    Console.WriteLine("Slaptas skaičius yra mazesnis");
                }
                else if (slaptas_skaicius < 5 && slaptas_skaicius >= 1)
                {
                    Console.WriteLine("Slaptas skaičius yra didesnis");
                }
                else if (slaptas_skaicius <= 0 || slaptas_skaicius > 10)
                {
                    Console.WriteLine("Jūs pasirinkote netinkamą skaičių, jis nėra tarp intervalo 1 ir 10");
                }
                else if (slaptas_skaicius == 5)
                {
                    Console.WriteLine("Atspėjote slaptą skaičių");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Paspauskite, bet kurį klavišą, norėdami išeiti");
            Console.ReadKey();
        }
    }
}
