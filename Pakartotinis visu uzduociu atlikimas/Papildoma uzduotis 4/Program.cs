using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papildoma_uzduotis_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskitre oro temperatura farenheitais");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            double celcijus = ((temperatura - 32) * (5/ 9));

            Console.WriteLine($"Temperatura celcijus {(double)celcijus}");

            Console.ReadKey();
        }
    }
}
