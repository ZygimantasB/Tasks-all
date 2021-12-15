using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
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
            Console.WriteLine("Irasykite automobiliu skaiciu");
            int automobiliu_skaicius = Convert.ToInt32(Console.ReadLine());

            List<Automobiliai> automobiliu_duomenys = new List<Automobiliai>();

            for (int i = 0; i < automobiliu_skaicius; i++)
            {
                Console.WriteLine("Irasykite automobilio modeli:");
                string automobilio_modeli = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio marke");
                string automobilio_marke = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio pagaminimo metus");
                int automobilio_pagaminimo_metai = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite automobilio rida");
                int automobilio_rida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite ar atlitka automobilio technine apziura ");
                string automobilio_technine_apziura = Console.ReadLine();

                bool technikine_atlikta = true;
                bool technikine_neatlikta = false;

                technikine_atlikta = automobilio_technine_apziura == "Taip";
                //technikine_neatlikta = automobilio_technine_apziura == "Ne";

                //bool automobolio_apziura_bool = Convert.ToBoolean(automobilio_technine_apziura);

                Console.WriteLine(technikine_atlikta ? "Technikine yra atlikta" : "Technikine yra neatlikta");

                Automobiliai priejimas_prie_automobiliu = new Automobiliai(automobilio_modeli, automobilio_marke, automobilio_pagaminimo_metai, automobilio_rida, automobilio_technine_apziura);

                automobiliu_duomenys.Add(priejimas_prie_automobiliu);

                foreach (var saraso_nuskaitymas in automobiliu_duomenys)
                {
                    Console.WriteLine($"{saraso_nuskaitymas.Marke} {saraso_nuskaitymas.Modelis} {saraso_nuskaitymas.Pagaminimo_metai} {saraso_nuskaitymas.Rida} {saraso_nuskaitymas.Technikines_apziura}");
                }

            }
        }
    }
}
