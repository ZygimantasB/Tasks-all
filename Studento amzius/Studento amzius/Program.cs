using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studento_amzius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite studento amžių:");
            Int32 studento_amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite pirmą skaičių:");
            Int32 pirmas_skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            Int32 antras_skaicius = Convert.ToInt32(Console.ReadLine());

            if (studento_amzius > pirmas_skaicius)
            {
                Console.WriteLine("Studento amžius yra didesnis už pirmą skaičių");
                Console.ReadLine();
            }
            else if (studento_amzius > antras_skaicius)
            {
                Console.WriteLine("Studento amžius yra didesnis už antrtą skaičių");
                Console.ReadLine();
            }
            else if (studento_amzius > pirmas_skaicius && studento_amzius > antras_skaicius)
            {
                Console.WriteLine("Studento amžius yra daugiau už skaicius1 ir skaicius2");
                Console.ReadLine();
            }
            else if (studento_amzius < pirmas_skaicius && studento_amzius < antras_skaicius)
            {
                Console.WriteLine("Studento amžius yra mažiau už skaicius1 ir skaicius2");
                Console.ReadLine();
            }

            else if (studento_amzius < pirmas_skaicius && studento_amzius > antras_skaicius)
            {
                Console.WriteLine("Pirmas skaicius yra daugiau nei studento amžius, tačiau studento amžius yra daugiau nei skaičius2");
                Console.ReadLine();
            }
            else if (studento_amzius > pirmas_skaicius && studento_amzius < antras_skaicius)
            {
                Console.WriteLine("Pirmas skaicius yra mažiau nei studento amžius, tačiau skaičius2 yra daugiau nei studento amžius");
                Console.ReadLine();
            }
        }
    }
}
