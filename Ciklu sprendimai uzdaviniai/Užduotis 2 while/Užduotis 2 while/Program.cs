using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis_2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo pasirinktą skaičių");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            {
                while (skaicius != 0 || skaicius < 0)
                {
                    Console.WriteLine("Iveskas skaicius yra sumazinamas 1 " + (skaicius - 1));
                    int skaicius1 = Convert.ToInt32(Console.ReadLine());

                    if (/*int lyginis_skaicius == skaicius1 % skaicius1 &&*/ skaicius1 % skaicius1 == 0)
                    {
                            Console.WriteLine("Lyginiu skaiciu suma " + (skaicius1 + skaicius1));
                    }
                    Console.WriteLine("Irasykiteykite skaiciu:");
                }
                //Console.ReadLine();
                //int lyginis_skaicius = Convert.ToInt32(Console.ReadLine());

                //lyginis_skaicius % lyginis_skaicius == 0;
                //int lyg_suma = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Lyginiu skaivciu suma " + lyg_suma);
                //    Console.ReadLine();
            }
        }
    }
}
