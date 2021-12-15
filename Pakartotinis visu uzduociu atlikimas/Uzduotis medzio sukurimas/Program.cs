using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_medzio_sukurimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Medis azuolas = new Medis();

            bool medzio_augimas = true;

            while (medzio_augimas != false)
            {
                Console.WriteLine("Ar norite, kad augtu medis");
                string ar_nori_augto = Console.ReadLine();

                medzio_augimas = ar_nori_augto == "taip";

                if(medzio_augimas)
                {
                    azuolas.Kiek_paaugo_medis();
                }
            }
            Console.WriteLine($"{azuolas.Medis_turi_saku}");

            Console.ReadKey();
        }
    }
}
