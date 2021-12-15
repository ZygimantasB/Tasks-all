using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreatch_paaiškinimas
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Detalus_duomenys_automobiliu();

            Console.ReadLine();
        }

        public static void Detalus_duomenys_automobiliu()
        {
            Console.WriteLine("Kiek Jums reikia automobiliu");
            int automobiliu_skaicius = Convert.ToInt32(Console.ReadLine());

            List<Mano_automobiliu_informacija> mano_automobiliai = new List<Mano_automobiliu_informacija>();

            for (int i = 0; i < automobiliu_skaicius; i++)
            {
                Console.WriteLine("Irasykite automobilio marke");
                string turimo_automobilio_marke = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio modeli");
                string turimo_automobilio_modelis = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio pagaminimo metai");
                int turimo_automobilio_pagaminimo_metai = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite automobilio rida");
                int turimo_automobilio_rida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite automobilio technine apziura");
                bool turimo_automobilio_technine_apziura = Convert.ToBoolean(Console.ReadLine());

                Mano_automobiliu_informacija automobiliu_pateikiami_duomenys = new Mano_automobiliu_informacija(turimo_automobilio_modelis, turimo_automobilio_marke,
                    turimo_automobilio_rida, turimo_automobilio_pagaminimo_metai, turimo_automobilio_technine_apziura);

                mano_automobiliai.Add(automobiliu_pateikiami_duomenys);

                foreach(var pateikiamas_rezultatas in mano_automobiliai)
                {
                    Console.WriteLine($"Marke/modelis {turimo_automobilio_marke} {turimo_automobilio_modelis} Pagaminimo metai {turimo_automobilio_pagaminimo_metai} Rida " +
                        $"{turimo_automobilio_rida} Technine apziura {turimo_automobilio_technine_apziura}");
                }
            }
        }

    }
}
