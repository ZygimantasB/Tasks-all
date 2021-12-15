using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_dar_vienas_bandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            int infiltracijos_pradzia = 1;

            Console.WriteLine("Irasykite snipo varda");
            string snipo_vardas = Console.ReadLine();

            Snipas informacija_apie_snipa = new Snipas(snipo_vardas, infiltracijos_pradzia);

            List<Snipas> informacija_apie = new List<Snipas>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{informacija_apie}. Snipas infiltravosi {informacija_apie_snipa.Snipo_infiltracija}");
            }
        }
    }
}
