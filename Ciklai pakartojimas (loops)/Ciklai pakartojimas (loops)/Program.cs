using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_pakartojimas__loops_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite 1 jei laptopas, 2 jei stacionaras");
            Console.WriteLine("Pasirinkote:");
            int pasirinko = Convert.ToInt32(Console.ReadLine());
            //int pasirinko = Convert.ToInt32(Console.ReadLine());

            while (pasirinko != 1 && pasirinko != 2)
            {
                int pasirinko1 = Convert.ToInt32(Console.ReadLine());

                switch (pasirinko1)
                {
                    case 1:
                    Console.WriteLine("laptopas");
                        break;
                    case 2:
                        Console.WriteLine("stacionaras");
                        break;
                    default:
                    Console.WriteLine("Jūs pasirinkote klaidingai, rinkinės iš naujo");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
