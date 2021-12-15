using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_skaiciu_rezultatas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašyti programą, kuri iš ekrano nuskaito 3 skaičius, sudaugina juos ir atspausdina rezultatą ekrane.


            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite antra skaiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite antra skaiciu");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaicius1 * skaicius2 * skaicius3} rezultatas visu triju skaiciu sudauginus");

            Console.ReadLine();
        }
    }
}
