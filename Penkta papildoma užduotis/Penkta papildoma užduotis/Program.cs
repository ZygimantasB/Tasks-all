using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penkta_papildoma_užduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite žodį:");
            var zodis = Console.ReadLine();
            var z = new StringBuilder();

            z.Append(zodis);

            var tmp = z[0];
            z[0] = z[z.Length - 1];
            z[z.Length - 1] = tmp;

            zodis = z.ToString();
            Console.WriteLine(zodis);
            Console.ReadLine();
        }
    }
}
