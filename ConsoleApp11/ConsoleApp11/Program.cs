using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobiliu_duomenys();

            Console.ReadLine();

        }
        public static void Automobiliu_duomenys()
        {
            Console.WriteLine("Irasykite kiek Jus turite automobiliu");
            int automobiliu_kiekis = Convert.ToInt32(Console.ReadLine());

            List<Automobiliu_informacija> duomenys_apie_automobilius = new List<Automobiliu_informacija>();

            for (int i = 0; i < automobiliu_kiekis; i++)
            {
                Console.WriteLine("Irasykite automobilio marke");
                string automobilio_marke = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio modeli");
                string automobilio_modelis = Console.ReadLine();

                Console.WriteLine("Irasykite automobilio pagaminimo metus");
                int  automobilio_pagaminimo_metai = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite automobilio rida");
                int automobilio_rida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite, kada atlikta automobilio technikine");
                int automobilio_technikine_atlikta = Convert.ToInt32(Console.ReadLine());

                Automobiliu_informacija automobiliai = new Automobiliu_informacija(automobilio_marke, automobilio_modelis, 
                    automobilio_pagaminimo_metai, automobilio_rida, automobilio_technikine_atlikta); //// 

                duomenys_apie_automobilius.Add(automobiliai);

                {
                    foreach (var galutine_informacija in duomenys_apie_automobilius)
                    {
                        Console.WriteLine($"{galutine_informacija.Automobilis} {galutine_informacija.Modelis} {galutine_informacija.Pagaminimo_metai} " +
                            $"{galutine_informacija.Rida} {galutine_informacija.Technikines_atlikta}");
                    }
                }
            }

        }
    }
}

