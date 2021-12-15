using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medis_uzduoties_pakartojis_klases
{
    class Program
    {
        static void Main(string[] args)
        {
            Medis liepa = new Medis();

            bool ar_norime_auginti_medi = true;

            while (ar_norime_auginti_medi != false)
            {
                Console.WriteLine("Ar norime auginti medi");
                string medzio_augimas = Console.ReadLine();

                ar_norime_auginti_medi = medzio_augimas == "Taip";

                if (ar_norime_auginti_medi)
                {
                    liepa.Kiek_paaugo_medis();
                }
            }
            Console.WriteLine($"{liepa.Medzio_sakos_skaicius}");

            Console.ReadKey();

        }
    }
}
