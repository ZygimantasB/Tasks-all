using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            Program aritmetika = new Program();

            int a;
            int b;
            int c;
            int d;

            Console.WriteLine("Irasykite skaiciu su kuriuo norite atlikti veiksma:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu su kuriuo norite atlikti veiksma:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu su kuriuo norite atlikti veiksma:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu su kuriuo norite atlikti veiksma:");
            d = int.Parse(Console.ReadLine());

            aritmetika.aritmetiniai_skaiciai(a, b, c, d, out int suma, out int atimtis, out int daugyba, out double dalyba,
                out double vidurkis, out double liekana);

            Console.WriteLine($"suma = {suma} atimtis = {atimtis} daugyba = {daugyba} dalyba = " +
                $"{dalyba:0.00000000} vidurkis = {vidurkis:0.00} liekana = {liekana}");

            Console.ReadKey();
        }

        private void aritmetiniai_skaiciai(int a, int b, int c, int d, out int suma, out int atimtis, 
            out int daugyba, out double dalyba, out double vidurkis, out double liekana)

        {
            suma = a + b + c + d;
            atimtis = a - b - c - d;
            daugyba = a * b * c * d;
            dalyba = (double)a / (double)b / (double)c / (double)d;
            vidurkis = ((double)a + (double)b + (double)c + (double)d) / 4;
            liekana = (double)a % (double)b % (double)c % (double)d;

        }
    }
}
