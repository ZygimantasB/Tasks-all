using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swith_patikrinimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Įveskite pirmą skaičių:");
            //Int32 skaicius1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Įveskite antr1 skaičių:");
            //Int32 skaicius2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Įveskite trečią skaičių:");
            //Int32 skaicius3 = Convert.ToInt32(Console.ReadLine());

            int skaicius1 = 1;
            int skaicius2 = 2;
            int skaicius3 = 3;


            switch (skaicius)
            {
                case 1:
                    Console.WriteLine(skaicius1 + skaicius2 + skaicius3);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine(skaicius1 - skaicius3);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine(skaicius2 * skaicius3);
                    Console.ReadLine();
                    break;

            }
        }
    }
}
