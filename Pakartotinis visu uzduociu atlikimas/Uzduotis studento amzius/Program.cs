using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_studento_amzius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite studento amziu");
            int studento_amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite antras skaicius");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (studento_amzius > skaicius1)
            {
                Console.WriteLine("Studento amzius yra didesnis uz pi" +
                    "rma skaiciu");
            }
            else if (skaicius2 > studento_amzius)
            {
                Console.WriteLine("Skaicisu 2 yra daugfaiu uz studenmto amziu");
            }
            else
            {
                Console.WriteLine("Studento amzius nera didesnis nei uz viena skaiciu");
            }

            Console.ReadKey();
        }
    }
}
