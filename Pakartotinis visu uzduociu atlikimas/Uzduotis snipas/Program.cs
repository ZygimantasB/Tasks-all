using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_snipas
{
    class Program
    {
        static void Main(string[] args)
        {
            Snipas uzduotis = new Snipas();

            Program snipai = new Program();

            List<string> snipineji_mane_ka = snipai.Snipu_sarasas();

            int skaiciuokle = uzduotis.Kelinta_infiltracija();
            //snipai.Snipu_sarasas();

            for (int i = 0; i < snipineji_mane_ka.Count; i++)
            {
                Console.WriteLine(($"Snipas infiltravosi {skaiciuokle++} {snipineji_mane_ka}"));
                Console.WriteLine("----------------------");
            }


            //for ( int i = 0; i < snipineji_mane_ka.Count; i++)
            //{
            //    Console.WriteLine(ka_tu_snipeli.);

            //        for (int j = 0; j < 10; j++)
            //        {
            //        Console.WriteLine(snipineji_mane_ka);
            //        }

            //}

            Console.ReadKey();
        }

        public List<string> Snipu_sarasas()
        {
            List<string> snipu_sarasas = new List<string>();

            snipu_sarasas.Add("Andrius");
            snipu_sarasas.Add("Neringa");
            snipu_sarasas.Add("Tomas");
            snipu_sarasas.Add("Virgis");
            snipu_sarasas.Add("Linas");
            snipu_sarasas.Add("Otilija");
            snipu_sarasas.Add("Reda");
            snipu_sarasas.Add("Matas");
            snipu_sarasas.Add("Simona");
            snipu_sarasas.Add("Faustas");

            for (int i = 0; i < snipu_sarasas.Count; i++)
            {
                Console.WriteLine(snipu_sarasas.ElementAt(i));
            }

            return snipu_sarasas;
        }
    }
}
