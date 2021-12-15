using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_medis
{
    class Program
    {
        static void Main(string[] args)
        {
            Medis azuolas = new Medis();

            bool ar_norim_auginti = true;

            while (ar_norim_auginti != false)

            { 

                Console.WriteLine("Ar norite auginti medi");
                string vartotojo_ivedimas = Console.ReadLine();

                ar_norim_auginti = vartotojo_ivedimas == "Taip";

                if (ar_norim_auginti)
                {
                    azuolas.Saku_augimas();

                }
            }

            Console.WriteLine($"{azuolas.Saku_skaicius}");

            Console.ReadLine();
            
        }
    }
}
