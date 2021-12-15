using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_skaidre_kepykla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą: ");
            int darbuotojas_kepalas_per_valanda = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotojų turi kepykla: ");
            int kepykla_turi_darbuotoju = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo savikaina.: ");
            double vieno_kepalo_savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vieno kepalo pardavimo kaina.: ");
            double vieno_kepalo_pardavimo_kaina = Convert.ToDouble(Console.ReadLine());

            int per_viena_diena_kepalu = darbuotojas_kepalas_per_valanda * kepykla_turi_darbuotoju;
            Console.WriteLine("Kiek iškeps kepalu per vieną dieną " + per_viena_diena_kepalu);
            Console.ReadLine();

            Console.WriteLine("Gautas pelnas " + ((per_viena_diena_kepalu * vieno_kepalo_pardavimo_kaina)
                - (per_viena_diena_kepalu - vieno_kepalo_savikaina) + " Eur"));
            Console.ReadLine();
        }
    }
}
