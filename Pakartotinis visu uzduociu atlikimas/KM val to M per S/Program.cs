using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM_val_to_M_per_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atstuma metrais");
            double atstumas_metrais = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite laika sekundemis");
            double laikas_sekundemis = Convert.ToDouble(Console.ReadLine());

            double kilometrai = (1 / 1000) * atstumas_metrais;
            double valandos = (1 / 3600) * laikas_sekundemis;

            Console.WriteLine($"{kilometrai} km{valandos} h");

            Console.ReadLine();
        }
    }
}
