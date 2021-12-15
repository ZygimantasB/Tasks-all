using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreatch_uzduoties_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------Uzduotis su foreatch sarasas --------------------

            //Console.WriteLine("Kiek kartu noresite pakartoti");
            //int pakartoti = int.Parse(Console.ReadLine());

            //string[] vardas = new string[pakartoti];

            //for (int i = 0; i < pakartoti; i++)
            //{
            //    Console.WriteLine("Irasykite varda");
            //    vardas[i] = Console.ReadLine();

            //    vardas[i].Reverse();
            //    foreach (var visi_vardai in vardas)
            //    {
            //        Console.WriteLine($"Sarasas: {visi_vardai}");
            //    }
            //}

            //----------------Uzduotis su foreatch sarasas LIST --------------------

            List<string> irasykite_vardas = new List<string>();

            bool ar_nori_kartoti = true;

            while(ar_nori_kartoti)
            {
                Console.WriteLine("Irasykite varda");
                string vardas = Console.ReadLine();
                irasykite_vardas.Add(vardas);

                Console.WriteLine("Ar norite testi ?");

                ar_nori_kartoti = Console.ReadLine() == "taip";
            }

            irasykite_vardas.Sort(); // surasyti eiles tvarka
            irasykite_vardas.Reverse(); // surasyti atgaline tvarka

            foreach(var visas_sarasas in irasykite_vardas)
            {
                Console.WriteLine(visas_sarasas);
            }

            Console.ReadKey();

        }
    }
}
