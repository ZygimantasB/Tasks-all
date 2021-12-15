using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_metodai
{
    class Program
    {
        static void Main(string[] args)
        {
            //int suma;
            //int atimtis;
            //int daugyba;
            //double padalinti;

            Pasisveikinimas(); // su static nereikia sukurti objekto

            Program objektas_pasisveikinimas1 = new Program();

            objektas_pasisveikinimas1.Pasisveikinimas1(); // Be static reikia sukurti objekta

            objektas_pasisveikinimas1.Uzduotis_Nr_2("Zygimantas", 29, "PC");

            objektas_pasisveikinimas1.Uzduotis_suma(5, 8);
            objektas_pasisveikinimas1.Uzduotis_skirtumas(5, 8);
            objektas_pasisveikinimas1.Uzduotis_sandauga(5, 8);
            objektas_pasisveikinimas1.Uzduotis_dalyba(5, 8);

            objektas_pasisveikinimas1.Visi_veiksmai(5, 8, out int suma, out int atimtis, out int daugyba, out double padalinti);
            Console.WriteLine($"Suma:{suma} Atimtis:{atimtis} Daugyba:{daugyba} Dalyba:{padalinti}");

            Console.ReadKey();
        }

        public static void Pasisveikinimas() // Naudojatn static mums nereikia kurti objekto
        {
        Console.WriteLine("As noriu pasisveikinti (naudojant static metoda (Pasisveikinimas)))");
        }
        public void Pasisveikinimas1 ()
        {
            Console.WriteLine("As noriu pasisveikinti su Jumis (Parasymas be static metodo, reikia sukurti objekta Pasisveikinimas1)))");
        }
        public void Uzduotis_Nr_2(string vardas, int amzius, string hobis)
        {
            Console.WriteLine($"Jusu vardas \n{vardas}");
            Console.WriteLine($"Jusu amzius \n{amzius}");
            Console.WriteLine($"Hobio pavadinimas \n{hobis}");
            Console.WriteLine($"Labas, {vardas} ({amzius}m.).\nJusu irasytas hobis: {hobis}");
        }
        public void Uzduotis_suma(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        public void Uzduotis_skirtumas(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public void Uzduotis_sandauga(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public void Uzduotis_dalyba(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {(double)a / (double)b}");
        }
        public void Visi_veiksmai(int a, int b, out int suma, out int skirtumas, out int daugyba, out double dalyba)
        {
            suma = a + b;
            skirtumas = a - b;
            daugyba = a * b;
            dalyba = (double)a / (double)b;
        }
    }
}
