using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_swith_salyga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaicius pirmas");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skaicius antras");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skaicius trecias");
            int skaicius3 = int.Parse(Console.ReadLine());

            switch(skaicius3)
            {
                case 1:
                    Console.WriteLine($"Visu skaiciu suma {skaicius1 + skaicius2 + skaicius3}");
                    break;
                case 2:
                    Console.WriteLine($"1 IR 3 SKIRTUMAS{skaicius1 - skaicius3}");
                    break;
                case 3:
                    Console.WriteLine($"1 ir antro sandauga {skaicius2 * skaicius3}");
                    break;
            }
            Console.ReadKey();

        }
    }
}
