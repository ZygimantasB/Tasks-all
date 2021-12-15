using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių tarp 1 ir 3:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių tarp 1 ir 3:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių tarp 1 ir 3:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            //int skaicius1 = 1;
            //int skaicius2 = 2;
            //int skaicius3 = 3;

            switch (skaicius1)
            {
                case 1:
                    int suma = skaicius1 + skaicius2 + skaicius3;
                    Console.WriteLine("Jei skaicius yra vienas yra išvedama visų trijų suma " + suma);
                    Console.ReadLine();
                    break;
                case 2:
                    int suma1 = skaicius1 - skaicius2;
                    Console.WriteLine("Jei skaičius yra 2 konsolė išveda pirmo ir antro skaičiaus skirtimą " + suma1);
                    Console.ReadLine();
                    break;
                case 3:
                    int suma2 = skaicius2 * skaicius3;
                    Console.WriteLine("Jei skaičius yra 3 tda yra išvedama antra ir treečio skaičiaus andauga" + suma2);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
