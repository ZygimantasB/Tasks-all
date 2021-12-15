using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papildoma_uzduotis_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite zodi");
            string zodis = Console.ReadLine();

            string paskutinis = zodis.Substring(0);
            string pirmas = zodis.Substring(0);

            Console.WriteLine($"{paskutinis} {pirmas}");

            Console.ReadKey();
        }
    }
}
