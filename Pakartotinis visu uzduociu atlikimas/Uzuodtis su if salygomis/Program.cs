using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzuodtis_su_if_salygomis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyktie pirma skaiciu");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasyktie antra skaiciu");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasyktie trecia skaiciu");
            int skaicius3 = int.Parse(Console.ReadLine());

            if (skaicius1 > skaicius2 && skaicius1 < 100)
            {
                Console.WriteLine("Skaicius 1 daugaiou uz 2 ir maziau uz simtra");
            }
            else if (skaicius2 > 0 && skaicius2 > skaicius1)
            {
                Console.WriteLine("Skaicius 2 daugaiu uz 0 ir daugaiu uz sakicius1");
            }
            else if(skaicius1 > skaicius2 & skaicius1 > skaicius3 || skaicius1 > 0)
                {
                Console.WriteLine("Skaicius 1 daugiaus uz 2 ir 3 ir art skciius yra teigiamas");
                }
            else if (skaicius3 >= 5 && skaicius3 <= 10 || skaicius3 > skaicius1)
            {
                Console.WriteLine("Aiski salyga");
            }

            Console.ReadKey();

        }
    }
}
