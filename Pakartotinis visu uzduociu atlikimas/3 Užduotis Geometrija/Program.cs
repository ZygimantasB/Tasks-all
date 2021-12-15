using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Užduotis_Geometrija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- APSKRITIMAS --------------------");

            Console.WriteLine("Irasykite R t.y. apskritimo spinduli (c)");
            double R = double.Parse(Console.ReadLine());

            Console.WriteLine("irasykite figuros pavadinima");
            string figuros_pavadinimas = Console.ReadLine();

            Apskritimas apskritimas_plotas_perimetras = new Apskritimas(R, figuros_pavadinimas);
            // kaip parasyti pavadinima figuros t.y. pasiimti ji is cia ?

            apskritimas_plotas_perimetras.Info();

            apskritimas_plotas_perimetras.FigurosPavadinimas(figuros_pavadinimas); // Reikejo kitaip ??

            double ploto_atvaizdavimas_konsoleje = apskritimas_plotas_perimetras.Apskritimas_plotas(R);
            Console.WriteLine($"Apskritimo plotas: {ploto_atvaizdavimas_konsoleje:0.00} cm {apskritimas_plotas_perimetras.Pavadinimas}");

            double perimetro_atvaizdavimas_konsoleje = apskritimas_plotas_perimetras.Apskritimas_perimetras(R);
            Console.WriteLine($"Apskritimo perimetras: {perimetro_atvaizdavimas_konsoleje:0.00} cm");

            Console.WriteLine("-----------------KVADRATAS --------------------");

            Console.WriteLine("Parasykite kvadrato krastime");
            int kvadrato_krastine = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("irasykite figuros pavadinima");
            string figuros_pavadinimas1 = Console.ReadLine();

            Kvadratas kvadrato_plotas_perimetras = new Kvadratas(kvadrato_krastine, figuros_pavadinimas1);

            kvadrato_plotas_perimetras.Info();

            double plotas_kvadratas_atvaizdavimas_konsoleje = kvadrato_plotas_perimetras.Kvadrato_plotas(kvadrato_krastine);
            Console.WriteLine($"Kvadrato plotas {plotas_kvadratas_atvaizdavimas_konsoleje}");

            double perimetras_kvadrato_konsoleje = kvadrato_plotas_perimetras.Kvadrato_perimetras(kvadrato_krastine);
            Console.WriteLine($"Kvadrato perimetras {perimetras_kvadrato_konsoleje}");

            Console.WriteLine("----------------- STACIAKAMPIS --------------------");

            Console.WriteLine("Irasykite staciakampio krastine a");
            double krastine_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite staciakampio krastine b");
            double krastine_b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("irasykite figuros pavadinima");
            string figuros_pavadinimas2 = Console.ReadLine();

            Staciakampis staciakampis_formules = new Staciakampis(krastine_a, krastine_b, figuros_pavadinimas2);

            staciakampis_formules.Info();

            double plotas_staciakampis_atvaizdavimas = staciakampis_formules.Staciakampis_plotas(krastine_a, krastine_b);
            Console.WriteLine($"Staciakampis plotas: {plotas_staciakampis_atvaizdavimas}");

            double perimetras_atvaizdavimas_konsoleje = staciakampis_formules.Staciakampio_perimetras(krastine_a, krastine_b);
            Console.WriteLine($"Staciakampio perimetras: {perimetras_atvaizdavimas_konsoleje}");

            Console.WriteLine("----------------- TRIKAMPIS --------------------");

            Console.WriteLine("Irasykite trikampio krastine a");
            double trikampis_krastine_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite trikampio krastine b");
            double trikampis_krastine_b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite trikampio krastine c");
            double trikampis_krastine_c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("irasykite figuros pavadinima");
            string figuros_pavadinimas3 = Console.ReadLine();

            StatusisTrikampis statusisTrikapis_formules = new StatusisTrikampis(trikampis_krastine_a, trikampis_krastine_b, trikampis_krastine_c, figuros_pavadinimas3);

            statusisTrikapis_formules.Info();

            double statusis_plotas_atvaizdavimas = statusisTrikapis_formules.Statusis_trikampis_plotas(trikampis_krastine_a, trikampis_krastine_b);
            Console.WriteLine($"Statusis trikampis plotas: {statusis_plotas_atvaizdavimas}");

            double statusis_perimetras_atvaizdavimas = statusisTrikapis_formules.Statusis_trikapis_perimetras(trikampis_krastine_a, trikampis_krastine_b, trikampis_krastine_c);
            Console.WriteLine($"Statusis trikampis perimetras: {statusis_perimetras_atvaizdavimas}");

            // Įdomus parašymas, kuris yra žemiau. 

            //List<Figura> figuros = new List<Figura>() {

            //    new Kvadratas (kvadrato_krastine, figuros_pavadinimas1),
            //    new Staciakampis (krastine_a, krastine_b,figuros_pavadinimas2),
            //    new StatusisTrikampis (trikampis_krastine_a, trikampis_krastine_b, trikampis_krastine_c, figuros_pavadinimas3),
            //    new Apskritimas (R, figuros_pavadinimas)
            //};

            //foreach (var figuru_sarasas in figuros)
            //{
            //    Console.WriteLine(figuru_sarasas);
            //}

            Console.ReadKey();
        }
    }
}
