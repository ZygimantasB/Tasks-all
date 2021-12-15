using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_uzduotis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            Single skaicius1 = Convert.ToSingle(Console.ReadLine());

            if (skaicius1 % 2 == 0)
            {
                Console.WriteLine("Skaicius1 yra dalys is dvieju");
                Console.ReadLine();
            }

            else
                {
                Console.WriteLine("Skaicius1 yra nedalus is 2");
                Console.ReadLine();
                }
        }
    }
}
