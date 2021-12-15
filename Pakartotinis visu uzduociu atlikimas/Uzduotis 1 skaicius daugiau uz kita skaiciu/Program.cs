using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_1_skaicius_daugiau_uz_kita_skaiciu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyktie pirmas skaicius");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasyktie pirmas skaicius");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine($"Skaicius1 daugiau uz skaiciu2 {skaicius1}");
            }
            else if (skaicius2 > skaicius1)
            {
                Console.WriteLine($"Skaicius 2 yra daugiau uz skaicius 1 {skaicius2}");
            }
            else
            {
                Console.WriteLine("Skaicius 1 ir skaiciuys 2 yra lygus");
            }

            Console.ReadKey();
        }
    }
}
