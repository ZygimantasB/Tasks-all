using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_skaiciuotuvas_su_metodais
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ar_norime_testi = true;
            while (ar_norime_testi)
            {
                Skaiciuoti();

                Console.WriteLine("Ar noriu kartoti (taip arba ne)");
                string ivestis = Console.ReadLine().ToLower();

                if (ivestis != "taip")
                {
                    ar_norime_testi = false;
                }
            }

        }

        public static int Suma(int a, int b)
            {
            return a + b;
            }
        public static int Atimtis(int a, int b)
        {
            return a - b;
        }
        public static int Daugyba(int a, int b)
        {
            return a * b;
        }
        public static double Dalyba (double a, double b)
        {
            return (double)a / (double)b;
        }

        public static void Skaiciuoti()
        {
            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite aritmetini veiksma (+, -, *, /)");
            string aritmetika = Console.ReadLine();
            double atsakymas = 0;

            switch (aritmetika)
            {
                case "+":
                    atsakymas = Suma(skaicius1, skaicius2);
                    break;

                case "-":
                    atsakymas = Atimtis(skaicius1, skaicius2);
                    break;

                case "*":
                    atsakymas = Daugyba(skaicius1, skaicius2);
                    break;

                case "/":
                    atsakymas = Dalyba(skaicius1, skaicius2);
                    break;

                default:
                    Console.WriteLine("Jus ivedete blogai");
                    break;
            }
            Console.WriteLine($"Atsakymas yra {atsakymas}");
            Console.ReadLine();
        }
    }
}
