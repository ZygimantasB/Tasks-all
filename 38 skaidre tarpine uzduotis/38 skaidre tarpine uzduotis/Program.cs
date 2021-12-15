using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_skaidre_tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą:");
            int kepalai_per_1val = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotojų turi kepykla:");
            int darbuotoju_skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo savikaina:");
            double kepalo_savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vieno kepalo pardavimo kaina:");
            double kepalo_pardavimo_kaina = Convert.ToDouble(Console.ReadLine());

            int kepalai_per_diena = kepalai_per_1val * 8 * darbuotoju_skaicius;
            Console.WriteLine("Kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų\n" 
                + kepalai_per_diena + " duonos kepalus");
            Console.ReadLine();
           

            double pelno_dalis = ((double)kepalai_per_diena * kepalo_pardavimo_kaina) - (kepalo_savikaina * (double)kepalai_per_diena);
            Console.WriteLine("Pelno dalis pardavus kepalus\n" + pelno_dalis + " Euro");
            Console.ReadLine();
        }
    }
}