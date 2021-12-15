using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 20; i++)
            {
                if ((double)i % 3 == 0)
                {
                    Console.WriteLine("Skaičius yra dalus iš trijų " + i);
                    Console.ReadLine();
                }
                else if ((double)i % 3 != 0)
                {
                    Console.WriteLine("Skaičius nėra dalus iš trijų " + i);
                    Console.ReadLine();
                }
            }
        }
    }
}
