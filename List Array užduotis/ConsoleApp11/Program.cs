using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int eile = 1;
            //string[] kiek_yra_mokiniu = new string[5];

            //Console.WriteLine("Irasykite keturias mokiniu pavardes: ");

            //for (int i = 0; i < kiek_yra_mokiniu.Length; i++)
            //{
            //    kiek_yra_mokiniu[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Viska isrikiuokite eiles tvarka");
            //Console.WriteLine("----------------------------------\n");

            //Array.Sort(kiek_yra_mokiniu);

            //for (int i = 0; i < kiek_yra_mokiniu.Length; i++)
            //{
            //    Console.WriteLine(eile + ". " + kiek_yra_mokiniu[i]);
            //    eile++;
            //}

            List<string> kiek_yra_mokiniu = new List<string>();

            kiek_yra_mokiniu.Add("Zygimantas");
            kiek_yra_mokiniu.Add("Andrius");
            kiek_yra_mokiniu.Add("Tadas");
            kiek_yra_mokiniu.Add("Gedinimas");
            kiek_yra_mokiniu.Add("Faustas");

            for (int i = 0; i <kiek_yra_mokiniu.Count; i++)
            {
                Console.WriteLine(kiek_yra_mokiniu[i]);
            }

            Console.WriteLine("Mokiniai eiles tvarka t.y. abecele");
            Console.WriteLine("----------------------------------");

            kiek_yra_mokiniu.Remove("Zygimantas");
            kiek_yra_mokiniu.RemoveAt(2);

            for (int i = 0; i < kiek_yra_mokiniu.Count; i++)
            {
                Console.WriteLine(kiek_yra_mokiniu[i]);
            }


                // Laukia, kol bus paspaustas klavisas
                Console.ReadKey();
        }
    }
}
