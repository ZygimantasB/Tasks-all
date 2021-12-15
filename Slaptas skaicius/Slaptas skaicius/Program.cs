using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slaptas_skaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            int slaptas_skaicius;

            Console.WriteLine("Pabandykite atspėti spalptą skaičių nuo 1 iki 10");
            slaptas_skaicius = Convert.ToInt32(Console.ReadLine());
            {
                while (slaptas_skaicius != 5)
                {
                    Console.WriteLine("Pabandykite atspėti slaptą skaičių:");
                    slaptas_skaicius = Convert.ToInt32(Console.ReadLine());
                
                    if (slaptas_skaicius > 5 && slaptas_skaicius <= 10)
                    {
                        Console.WriteLine("Slaptas skaicius yra mazesnis");
                    }
                    else if (slaptas_skaicius < 5 && slaptas_skaicius >= 1)
                    {
                        Console.WriteLine("Slaptas skaicius yra didesnis");
                    }
                    else if (slaptas_skaicius <= 0 || slaptas_skaicius > 10)
                    {
                        Console.WriteLine("Jūs įvedėte skaičių kuris nepatenka į rėmus tarp 1 ir 10");
                    }
                    else if (slaptas_skaicius == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Jus atspejote slapta skaiciu");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Paspauskite, bet kurį klavišą norėdam,i išeiti");
                Console.ReadKey();
            }
        }
    }
}
