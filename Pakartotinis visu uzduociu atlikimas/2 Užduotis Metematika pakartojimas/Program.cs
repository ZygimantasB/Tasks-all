using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Užduotis_Metematika_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite skaiciu a");
            int skaicius_A = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite skaiciu b");
            int skaicius_B = int.Parse(Console.ReadLine());

            //IMatematika objekto_sukurimas = new IMatematika(skaicius_A, skaicius_B); Taip nedaryti bandymas

            Skaicius obejekto_sukurimas = new Skaicius(skaicius_A, skaicius_B);

            int sudetis = obejekto_sukurimas.Prideti(skaicius_A, skaicius_B);
            int atimtis = obejekto_sukurimas.Atimti(skaicius_A, skaicius_B);
            int daugyba = obejekto_sukurimas.Padauginbti(skaicius_A, skaicius_B);
            double dalyba = obejekto_sukurimas.Dalyba((double)skaicius_A, (double)skaicius_B);
            double kelimaskvadratu = obejekto_sukurimas.PakeltiKvadratu(skaicius_A);
            double kelimasKubu = obejekto_sukurimas.PakeltiKubu(skaicius_A);

            Console.WriteLine($"Sudetis: {sudetis}");
            Console.WriteLine($"Atimtis: {atimtis}");
            Console.WriteLine($"Daugyba: {daugyba}");
            Console.WriteLine($"Dalyba: {dalyba}");
            Console.WriteLine($"Kelimas kvadratu: {kelimaskvadratu}");
            Console.WriteLine($"Kelimas kubu: {kelimasKubu}");

            Console.ReadKey();

        }
    }
}
