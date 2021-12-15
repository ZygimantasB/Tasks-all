using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas_eksperimentas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ar_kartoti = true;

            while (ar_kartoti)
            {
                Matematika();

                Console.WriteLine("Ar norite kartoti (Taip - Ne");
                string mano_pasirinkimas = Console.ReadLine().ToLower();

                if (mano_pasirinkimas != "taip")
                {
                    ar_kartoti = false;
                }
            }

            Console.ReadKey();
        }

        public void Sudetis (int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public int Atimtis(int a, int b, out int atimtis)
        {
            atimtis = a - b;
            return atimtis;
        }
        public int Daugyba(int a, int b)
        {
            return a * b;
        }
        public double Dalyba(double a, double b)
        {
            return a + b;
        }
        public static void Matematika()
        {
            Program objektas = new Program();


            Console.WriteLine("Irasyktie skasiciu");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasyktite skaiciu");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite aritmetini veiksma");
            string aritmetika = Console.ReadLine();

            if (aritmetika == "+")
            {
                objektas.Sudetis(skaicius1, skaicius2);
            }
            if (aritmetika == "-")
            {
                objektas.Atimtis(skaicius1, skaicius2, out int atimtis);
                Console.WriteLine(atimtis);
            }
            if (aritmetika == "*")
            {
                objektas.Daugyba(skaicius1, skaicius2);
                Console.WriteLine($"{skaicius1 * skaicius2}");
            }
            if (aritmetika == "/")
            {
                objektas.Dalyba(skaicius1, skaicius2);
                Console.WriteLine($"{(double)skaicius1 / (double)skaicius2}");
            }
        }
    }
}
