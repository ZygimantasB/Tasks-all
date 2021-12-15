using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyginti_tris_skaicius__kuris_didesnis
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

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("skaicius1 yra daugiau už skacius2 ir skaicus3");
                Console.ReadLine();
            }

            else if (skaicius1 < skaicius2 && skaicius1 < skaicius3)
            {
                Console.WriteLine("skaicius1 yra mažiau už skacius2 ir skaicus3");
                Console.ReadLine();
            }

            else if (skaicius1 > skaicius2 && skaicius1 < skaicius3)
            {
                Console.WriteLine("skaicius1 yra daugiau už skacius2, bet mažiau už skaicus3");
                Console.ReadLine();
            }

            else if (skaicius1 < skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("skaicius1 yra mažiau už skacius2, bet daugiau už skaicus3");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Nėra teisingos sąlygos");
                Console.ReadLine();
            }
        }
    }
}
