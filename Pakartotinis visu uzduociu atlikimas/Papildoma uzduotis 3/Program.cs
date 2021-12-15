using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papildoma_uzduotis_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyktei pirma skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Irasyktei antra skaiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasyktei trecia skaiciu");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasyktei ketvirta skaiciu");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Skaicius pirmas {skaicius1} Skaicius antras {skaicius2} Skaicius trecias {skaicius3} Skaicius ketvirtas {skaicius4}" +
                $" Skaicius vidurkis {((double)skaicius1 + (double)skaicius2 + (double)skaicius3 + (double)skaicius4) / 4}");

            Console.ReadKey();
        }
    }
}
