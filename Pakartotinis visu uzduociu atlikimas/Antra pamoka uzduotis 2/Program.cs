using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra_pamoka_uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parasyktie skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 % 2 == 0)
            {
                Console.WriteLine("Skaicius yra dalus");
            }
            else
            {
                Console.WriteLine("Skaicius yra nedalus");
            }

            Console.ReadKey();
        }
    }
}
