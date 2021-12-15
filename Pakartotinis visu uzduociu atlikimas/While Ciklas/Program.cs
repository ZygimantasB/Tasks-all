using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Ciklas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzduotis 2
            //int suma = 1;

            //Console.WriteLine("Iveskite pasirinkta skaiciu");
            //int skaicius = Convert.ToInt32(Console.ReadLine());

            //while (skaicius != 0)
            //{
            //    Console.WriteLine($"Gautas skasicius sumazinamas 1 {skaicius - 1}");
            //    skaicius = Convert.ToInt32(Console.ReadLine());

            //    suma = skaicius + skaicius;
            //    Console.WriteLine(suma);
            //        if (skaicius % 2 == 0)
            //        {
            //            Console.WriteLine($"lyginiu skaiciu suma {skaicius + skaicius}");
            //        }
            //}
            //Console.WriteLine($"{suma}");


            // Uzduotis 3

            bool ar_norime_testi = true;

            //Console.WriteLine("Iveskite skaiciu ");
            //int skaicius1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu ");
            //int skaicius2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Irasykite aritmetini veiksma (+, -, *, /)");
            //string aritmetinis_veiksmas = Console.ReadLine();

            while (ar_norime_testi)
            {

                Console.WriteLine("Iveskite skaiciu ");
                int skaicius1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Iveskite skaiciu ");
                int skaicius2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Irasykite aritmetini veiksma (+, -, *, /)");
                string aritmetinis_veiksmas = Console.ReadLine();

                switch (aritmetinis_veiksmas)
                {
                    case "+":
                        Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
                        break;

                    case "-":
                        Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
                        break;
                    case "*":
                        Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
                        break;
                    case "/":
                        Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / (double)skaicius2}");
                        break;
                }
                Console.WriteLine("Ar noriu skaiciuoti vel ?");
                string ivestis = Console.ReadLine();
                //ar_norime_testi = Console.ReadLine() == "taip";

                if (ivestis != "taip") 
                {
                    ar_norime_testi = false; 
                    //reak; arba vir6uje esantis atvejis.
                }
            }

            Console.ReadKey();
        }
    }
}
