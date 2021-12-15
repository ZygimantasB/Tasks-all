using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mano_automobiliai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyktie automobilio modelis");
            string automobilio_modelis = Console.ReadLine();

            Console.WriteLine("Irasyktie automobilio marke");
            string automobilio_marke = Console.ReadLine();

            Console.WriteLine("Irasyktie automobilio metai");
            int automobilio_metai = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasyktie automobilio metai");
            int automobilio_rida = int.Parse(Console.ReadLine());

            Console.WriteLine("Ar atlkitka technikine (Taip - Ne 123)");
            string technikines_atlikimas = Console.ReadLine().ToLower();

            Automobilis automobilis1 = new Automobilis(automobilio_modelis, automobilio_marke, automobilio_metai, automobilio_rida, technikines_atlikimas);

            automobilis1.Automobilio_duomenys();



            //automobilis1.Automobilio_duomenys(technikines_atlikimas); // butu gerai, kad veiktu sitas !!!! Neveike tai sukuriau konstruktoriu

            //automobilis1.Automobilio_duomenys();

            Console.ReadKey();
        }
    }
}
