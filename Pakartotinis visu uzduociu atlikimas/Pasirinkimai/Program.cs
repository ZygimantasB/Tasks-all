using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasirinkimai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite norima punklta 1 limonadas // - 2 - arbata // 3 - kakava // 4 - kava // 5 - nieko");
            string pasirinkimas = Console.ReadLine();

            bool teisingas = true;

            while (!teisingas)
            {
                switch (pasirinkimas)
                {
                    case "1":
                        Console.WriteLine("Jus pasirinkote Limonada");
                        break;
                    case "2":
                        Console.WriteLine("Jus pasirinkote Arbata");
                        break;
                    case "3":
                        Console.WriteLine("Jus pasirinkote Kakava");
                        break;
                    case "4":
                        Console.WriteLine("Jus pasirinkote kava");
                        break;
                    default:
                        Console.WriteLine("Jus nieko nepasirinkote");
                        break;
                }
                //Console.WriteLine("Ar norite kartoti");
                //string kartojimas = Console.ReadLine();
                //teisingas = pasirinkimas == "taip";

            }
            Console.ReadKey();
        }
    }
}
