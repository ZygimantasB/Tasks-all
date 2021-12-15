using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papildoma_uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyktie pirma skasiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasyktie pirma skasiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Rezultatas sudejus {skaicius1 + skaicius2}");
            Console.WriteLine($"Rezultatas atemus {skaicius1 - skaicius2}");
            Console.WriteLine($"Rezultatas sudauginus {skaicius1 * skaicius2}");
            Console.WriteLine($"Rezultatas padalinus {(double)skaicius1 / (double)skaicius2}");

            Console.ReadKey();
        }
    }
}
