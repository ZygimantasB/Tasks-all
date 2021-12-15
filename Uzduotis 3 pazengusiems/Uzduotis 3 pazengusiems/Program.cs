using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_3_pazengusiems
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius1;
            double skaicius2;
            double atsakymas;
            string aritmetinis_veiksmas;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\tMano PIRMASIS skaičiuotuvas\n");


            Console.WriteLine("Įveskite pirmą skaičių su kuriuo norite atlikti aritmetinį veiksmą:");
            skaicius1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių su kuriuo norite atlikti aritmetinį veiksmą:");
            skaicius2 = double.Parse(Console.ReadLine());

            Console.WriteLine("pasirinkite norima operatoriu: (+, -, *, /, %)\n");
            aritmetinis_veiksmas = Console.ReadLine();

            if (aritmetinis_veiksmas == "+")
            {
                atsakymas = skaicius1 + skaicius2;
                Console.WriteLine("Jūsų atsakymas yra " + atsakymas + "\n");
            }
            if (aritmetinis_veiksmas == "-")
            {
                atsakymas = skaicius1 - skaicius2;
                Console.WriteLine("Jūsų atsakymas yra " + atsakymas + "\n");
            }
            if (aritmetinis_veiksmas == "*")
            {
                atsakymas = skaicius1 * skaicius2;
                Console.WriteLine("Jūsų atsakymas yra " + atsakymas + "\n");
            }
            if (aritmetinis_veiksmas == "/")
            {
                atsakymas = skaicius1 / skaicius2;
                Console.WriteLine("Jūsų atsakymas yra " + atsakymas + "\n");
            }
            if (aritmetinis_veiksmas == "%")
            {
                atsakymas = skaicius1 % skaicius2;
                Console.WriteLine("Jūsų atsakymas yra " + atsakymas + "\n");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tPaspauskite bet kurį klavišą norint iseiti iš konsolės");
            Console.ReadKey();
        }    
    }
}
