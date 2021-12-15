using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Programa
    {
        static void Main(string[] args)
        {
            Programa p = new Programa();

            Console.WriteLine("Irasykite pirma skaičių su kuriuo norite atlitki aritmetinį veiskmą");
            int skaiciu1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaičių su kuriuo norite atlitki aritmetinį veiskmą");
            int skaiciu2 = int.Parse(Console.ReadLine());

            p.Atimtis(skaiciu1, skaiciu2, out int atimtis);
            Console.WriteLine($"Atemus galimus veikmus buvo gautas atsakymas {atimtis}");

            p.Sudetis(skaiciu1, skaiciu2, out int sudetis);
            Console.WriteLine($"Sudejus galimus veiksmus buvo gautas atsakymas {sudetis}");

            p.Daugyba(skaiciu1, skaiciu2, out int daugyba);
            Console.WriteLine($"Sudauginus galimus veiksmus buvo gautas atsakymas {daugyba}");

            p.Dalyba(skaiciu1, skaiciu2, out double dalyba);
            Console.WriteLine($"Padalinus galimus skaicius yra gautas atsakymas {dalyba:0.00}");

            Console.ReadKey();

        }

        public void Atimtis(int skaicius1, int skaicius2, out int atimtis)
        {
            atimtis = skaicius1 - skaicius2;
        }

        public void Sudetis(int skaicius1, int skaicius2, out int sudetis)
        {
            sudetis = skaicius1 + skaicius2;
        }

        public void Daugyba (int skaicius1, int skaicius2,out int daugyba)
        {
            daugyba = skaicius1 * skaicius2;
        }

        protected internal void Dalyba (double skaicius1, double skaicius2, out double dalyba)
        {
            dalyba = skaicius1 / skaicius2;
        }
    }

}
        
    

