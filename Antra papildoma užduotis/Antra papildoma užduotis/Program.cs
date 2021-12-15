using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra_papildoma_užduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių:");
            int skaicius_pirmas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            int skaicius_antras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skaicius_pirmas ir skaičius_antras sudėtis\n" + skaicius_pirmas + skaicius_antras);
            Console.ReadLine();
            
            Console.WriteLine("skaicius_pirmas ir skaičius_antras atimtis\n" + (skaicius_pirmas - skaicius_antras));
            Console.ReadLine();

            Console.WriteLine("skaicius_pirmas ir skaičius_antras daugyba\n" + skaicius_pirmas * skaicius_antras);
            Console.ReadLine();

            Console.WriteLine("skaicius_pirmas ir skaičius_antras dalyba\n" + (double)skaicius_pirmas / (double)skaicius_antras);
            Console.ReadLine();
        }
    }
}
