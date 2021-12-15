using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trečia_papidloma_užduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių:");
            Int32 skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            Int32 skaicius2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Įveskite trečią skaičių:");
            Int32 skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite ketvirtą skaičių:");
            Int32 skaicius4 = Convert.ToInt32(Console.ReadLine());

            double rezultatas = (((double)skaicius1 + (double)skaicius2 + (double)skaicius3 + (double)skaicius4) / 4);

            Console.WriteLine("Sudėjus skaičius {0} + {1} + {2} + {3} gaunamas jų vidurkis {4:0.0}", 
                skaicius1, 
                skaicius2, 
                skaicius3, 
                skaicius4, 
                (double)rezultatas);
            Console.ReadLine();
        }
    }
}
