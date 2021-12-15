using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokomes_klases
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobiliu_informacija();

            Console.ReadKey();
        }
        public static void Automobiliu_informacija()
        {
            Console.WriteLine("Irasykite kiek Jums reikia automobiliu");
            int kiek_reikia_auto = Convert.ToInt32(Console.ReadLine());

            List<Transporto_priemone> mano_automobiliai = new List<Transporto_priemone>();

            for (int i = 0; i < kiek_reikia_auto; i++)
            {
                Console.WriteLine("Irasykite automobilio marke");
                string automobilio_marke = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio modeli");
                string automobilio_modelis = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio metus");
                int automobilio_metai = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ar Atlitka technine apziura");
                int automobilio_technine_apziura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite automobilio metus");
                int automobilio_rida = Convert.ToInt32(Console.ReadLine());

                Transporto_priemone automobilis1 = new Transporto_priemone(automobilio_marke, automobilio_modelis, automobilio_metai, automobilio_technine_apziura, automobilio_rida);

                mano_automobiliai.Add(automobilis1);
            }

            foreach (var informacija_automobiliai in mano_automobiliai)
            {
                Console.WriteLine($" Marke/Modelis {informacija_automobiliai.Marke} {informacija_automobiliai.Modelis} Automobilio metai {informacija_automobiliai.Metai}" +
                    $" Automobilio technine apziura {informacija_automobiliai.Technine_apziura} automobilio rida {informacija_automobiliai.Rida}");
            }
    
        }
    }
}
