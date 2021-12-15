using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susikurti_visus_reikiamus_kintamuosius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių vienas:");
            Int32 skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite skaičių du:");
            Int32 skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite skaičių trys:");
            Int32 skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Skaičius1 yra didesnis už Skaičių2");
                Console.ReadLine();
            }

            else if (skaicius2 > 0 && skaicius2 > skaicius1)
            {
                Console.WriteLine("Skaičius2 yra daugaiu už nulį ir Skaičius2 yra daugiau už Skaičių1");
                Console.ReadLine();
            }

            else if (skaicius2 > skaicius3 && skaicius2 > 0)
            {
                Console.WriteLine("Skaičius2 yra daugaiu už nulį ir Skaičius2 yra daugiau už Skaičių1");
                Console.ReadLine();
            }

            else if (skaicius3 >= 5 && skaicius3 <= 10)
            {
                Console.WriteLine("Skaičius2 yra daugaiu už nulį ir Skaičius2 yra daugiau už Skaičių1");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Nėra teisingos sąlygos");
                Console.ReadLine();
            }

        }
    }
}
