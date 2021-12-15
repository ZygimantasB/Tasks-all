using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_pakartojimas_visos_užduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzduotis Nr.1 4 Pamoka metodai --------------------------

            //Console.WriteLine("--Man pavyko-- Irasykite ka nors");
            //string tekstas = Console.ReadLine();

            //Uzduotis1_teksto_atvaizdavimas uzduotis1 = new Uzduotis1_teksto_atvaizdavimas(tekstas);

            //uzduotis1.Uzduotis1_atlikimas();
            //Console.WriteLine("----------------------");
            //// Uzduotis Nr. 2 ----------------------

            //Console.WriteLine("Irasykite savo varda");
            //string mano_vardas = Console.ReadLine();

            //Console.WriteLine("Irasyktie savo amziu");
            //int mano_amzius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Irasykite savo hobi");
            //string mano_hobis = Console.ReadLine();

            //Metodas_Pasisveikinti uzduotis2 = new Metodas_Pasisveikinti(mano_vardas, mano_amzius, mano_hobis);
            //uzduotis2.Uzduoties2_rezultatas();

            //Console.WriteLine("------------------");

            //// Uzduotis su skaiciavimais -----------------------

            //Program aritmetika = new Program();

            //Console.WriteLine("Irasykite pirma skaiciu");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Irasykite antra skaiciu");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //aritmetika.Sudetis(number1, number2);

            // Uzuotis su string ---------------------- Pabandymas

            //Program uzduotis_string = new Program();

            //string vardas = "Zygimantas";
            //String pavarde = "Brinkis";

            //uzduotis_string.Zodziai(vardas, pavarde);

            //Uzduotis automobiliai ---------------------------------

            Console.WriteLine("Irasykite automobilio marke");
            string automobilio_marke = Console.ReadLine();

            Console.WriteLine("Irasykite automobilio modelis");
            string automobilio_modelis = Console.ReadLine();

            Console.WriteLine("Irasykite pagaminimo metai");
            int automobilio_pagaminimo_metai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite pagaminimo metai");
            int automobilio_rida = Convert.ToInt32(Console.ReadLine());

            
            Uzuotis_isvardinti_automobilius automobiliu_sarasas = new Uzuotis_isvardinti_automobilius(automobilio_marke, automobilio_modelis,
                    automobilio_pagaminimo_metai, automobilio_rida); /// Norėčiau sužinoti ar galima padareyti, kad man nereiktų objekto įrašyti kiekvieną kartą, ar aš galėčiau vsią objektą parašyti cigkle


            Uzuotis_isvardinti_automobilius[] automobiliu_informacija = new Uzuotis_isvardinti_automobilius[10];

            for (int i = 0; i < 10; i++)
            {
                
            }

            

            Console.ReadKey();
        }

        public void Sudetis(int a, int b) // Koki veiksma galiu atlikto bloke su void ?
        {
            Console.WriteLine($"Aritmetinis veiksmas {a + b}");
        }
        public void Zodziai(string vardas1, string pavarde1)
        {
            Console.WriteLine("Vardas mano yra pavartde mano yra " + vardas1 + " " + pavarde1);
        }
    }
}
