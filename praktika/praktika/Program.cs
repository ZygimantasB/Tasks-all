using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasirinkimas;

            Console.WriteLine("Pasirinkite ko norite");
            Console.WriteLine("1 - limonadas");
            Console.WriteLine("2 - arbata");
            Console.WriteLine("3 - kakava");
            Console.WriteLine("4 - kava");
            Console.WriteLine("5 - nieko");
            Console.Write("Jusu pasirinkimas:");

            pasirinkimas = Console.ReadLine();

            Program bandymas = new Program();

            bandymas.Uzduotis(pasirinkimas);

            Console.ReadKey();
        }

        private void Uzduotis(string pasirinkimas)
        {
            switch(pasirinkimas)
            {
                case "1":
                    Console.WriteLine("Jus pasirinkome limonada");
                    break;
                case "2":
                    Console.WriteLine("Jus pasirinkome arbata");
                    break;
                case "3":
                    Console.WriteLine("Jus pasirinkome kakava");
                    break;
                case "4":
                    Console.WriteLine("Jus pasirinkome kava");
                    break;
                case "5":
                    Console.WriteLine("Jus niko nepasirinkote");
                    break;
                default:
                    Console.WriteLine("N4ra tokio pasirinkimo");
                    break;
            }
        }


    }
}

