using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            int kortuSk = 52;
            string[] kortuZenklai = new string[] { "Kryzius", "Vynas", "Bugnas", "Sirdis" };
            List<Korta> kortuKalade = new List<Korta>();

            //var r = new Random();

            //UzpildytiZenklais(kortuSk, kortuZenklai, kortuKalade);
            Zaidimas zaidimas = new Zaidimas(2);
            zaidimas.Zaisti();

            foreach (Korta korta in kortuKalade)
            {
                Console.WriteLine($"{korta.Zenklas} {korta.Verte} {korta.Indeksas}");
                //Console.WriteLine($"RANDOM: {r.Next(0, 2)}");
            }

            Console.WriteLine(kortuKalade.Count);

            Console.Read();
        }

        //public static void UzpildytiZenklais(int kortuSkaicius, string[] kortuZenklai, List<Korta> kortuKalade)
        //{
        //    foreach (string zenklas in kortuZenklai)
        //    {
        //        int vienoZenkloKiekis = kortuSkaicius / kortuZenklai.Length;

        //        for(int i = 2; i < vienoZenkloKiekis - 2; i++)
        //        {
        //            kortuKalade.Add(new SkaitineKorta(zenklas, i));
        //        }

        //        kortuKalade.Add(new Galva(zenklas, "B"));
        //        kortuKalade.Add(new Galva(zenklas, "Q"));
        //        kortuKalade.Add(new Galva(zenklas, "K"));
        //        kortuKalade.Add(new Galva(zenklas, "A"));
        //    }
        //}
    }
}
