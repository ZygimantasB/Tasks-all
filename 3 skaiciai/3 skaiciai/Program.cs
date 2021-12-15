using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_skaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite primą skaičių:");
            Int32 skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            Int32 skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečią skaičių:");
            Int32 skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Visų trijų skaičių sandauga " + skaicius1 * skaicius2 * skaicius3 + " sudauginus " +
                "visus tris skaičius.");
            Console.ReadLine();
        }
    }
}
