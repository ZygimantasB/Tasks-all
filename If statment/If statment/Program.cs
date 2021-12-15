using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaicius pirmas:");
            Int32 skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius antras:");
            Int32 skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Skaicius1 yra daugiau uz skaiciu2");
                Console.ReadLine();
            }

            else if (skaicius1 < skaicius2)
            {
                Console.WriteLine("Skaicius1 yra maziau uz skaiciu2");
                Console.ReadLine();
            }

            else 
                {
                Console.WriteLine("Skaicius1 yra lygus skaiciui2");
                Console.ReadLine();
                }
        }
    }
}
