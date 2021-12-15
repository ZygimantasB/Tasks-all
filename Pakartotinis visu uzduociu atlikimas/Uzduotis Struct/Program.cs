using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Struct
{
    class Program 
    {
        static void Main(string[] args)
        {
            Struct_sukurimas bandymas_struct = new Struct_sukurimas();

            Naujos_kalses_sukurimas bandymas_klase = new Naujos_kalses_sukurimas();

            //Console.WriteLine("Irasykite nauja zodi");
            //string naujas_zodis = Console.ReadLine();

            //Console.WriteLine("Irasyktie sugalvota skaiciu");
            //int sugalvotas_skaicius = Convert.ToInt32(Console.ReadLine());

            //List<string> sugalvotas_list = new List<string> { "Gerdas", "Tomas", "Gediminas" };

            string zodis = bandymas_struct.Zodziu_isvedimas();

            int skaicius = bandymas_struct.Naujo_skaiciaus_isvedimas();

            List<string> sarasas = bandymas_struct.Naujo_list_isvedimas();

            Console.WriteLine(zodis);
            Console.WriteLine(skaicius);

            foreach (var naujas_sarasas in sarasas)
            {
                Console.WriteLine(naujas_sarasas);
            }

            Console.ReadKey();
        }
    }
}
