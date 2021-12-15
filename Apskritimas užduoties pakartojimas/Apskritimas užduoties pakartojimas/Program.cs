using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimas_užduoties_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite R, apskaičiuos apskritimo spinduli");
            double r_spindulys = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Irasykite R, apskaičiuos apskritimo ilgi");
            double r_ilgis = Convert.ToDouble(Console.ReadLine());

            Apskritimas apskirtimo_apskaiciavimas = new Apskritimas(r_spindulys, r_ilgis);


            Console.WriteLine($"Apskritimo spindulys: {apskirtimo_apskaiciavimas.Apskritimo_plotas():0.00}");

            Console.WriteLine($"Apskritimo ilgis: {apskirtimo_apskaiciavimas.Apskritimo_ilgio_apskaiciavimas():0.00}");

            // Apskaiciuojamas kvadratas

            Console.WriteLine("Irasykite A, apskaičiuos kvadrato plota");
            double s_plotas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasykite A, apskaičiuos kvadrato perimerta");
            double a_perimetras = Convert.ToDouble(Console.ReadLine());

            Kvadratas kvadrato_apskaiciavimas = new Kvadratas(s_plotas, a_perimetras);

            Console.WriteLine($"Apskaiciuoti kvadrato perimetra: {kvadrato_apskaiciavimas.Kvadrato_apskaiciavimas()}");
            Console.WriteLine($"Kvadrato Perimetras: {kvadrato_apskaiciavimas.Kvadrato_perimetras()}");

            // Trikampio apskaiciavimas

            Console.WriteLine("Irasyktie krastinę A apskaiciuoti trikampio pusperimetri");
            double a_krastine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasyktie krastinę B apskaiciuoti trikampio pusperimetri");
            double b_krastine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasyktie krastinę C apskaiciuoti trikampio pusperimetri");
            double c_krastine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasykite trikampio krastine H");
            double h_krastine_trikampio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasykite trikapio J krastine");
            double j_trikampio_krastine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Heronmo formules apskaiciavimas irasykiote p");
            double p_herono_formule = Convert.ToDouble(Console.ReadLine());

            Trikampis trikampio_pusperimetrio_apskaiciavimas = new Trikampis(a_krastine, b_krastine, c_krastine, j_trikampio_krastine, h_krastine_trikampio, p_herono_formule);

            Console.WriteLine($"Trikampio pusperimetris: {trikampio_pusperimetrio_apskaiciavimas.Pusperimetrio_apskaiciavimas():0.00}");
            Console.WriteLine($"Trikampio aukstines apskaiciavimas: {trikampio_pusperimetrio_apskaiciavimas.Trikampio_aukstine()} ");
            Console.WriteLine($"Herono formules apskaiciavimas {trikampio_pusperimetrio_apskaiciavimas.Herono_formule()}");

            Console.ReadKey();



        }
    }
}
