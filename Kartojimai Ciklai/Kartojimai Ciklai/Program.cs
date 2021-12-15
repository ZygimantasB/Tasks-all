using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimai_Ciklai
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pakartojimas = true;

            Console.WriteLine("Pirmas skaicius");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Antras skaicius");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aritmetinis veikmas (+, -, *, /)");
            string action = Console.ReadLine();

            while (pakartojimas != true)
            {
                switch (action)
                {
                    case "+":
                        Console.WriteLine(number1 + number2);
                        break;
                    case "-":
                        Console.WriteLine(number1 - number2);
                        break;
                    case "*":
                        Console.WriteLine(number1 * number2);
                        break;
                    case "/":
                        Console.WriteLine((double)number1 / (double)number2);
                        break;
                }

                Console.WriteLine("Ar norite kartoti ?");
                string kartoti = Console.ReadLine();

                pakartojimas = kartoti == "Taip";

            }
            Console.ReadLine();
        }

    }
}
