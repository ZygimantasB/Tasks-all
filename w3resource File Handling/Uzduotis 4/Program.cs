using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Write a program in C# Sharp to create a file and add some text.

            // ------ Variantas 1---------------- - mano sprendimas
            Console.WriteLine("Varinatas 1");

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\test.txt";

            List<string> word = new List<string>();
            word.Add("Labas");
            word.Add("Rytas");
            
                if (File.Exists(filePath))
                {
                    Console.WriteLine("Failas jau yra sukurtas, naujo kuri nebereikia");
                }
                else
                {
                    File.Create(filePath);
                    Console.WriteLine("As sukuriau faila");
                }

            File.WriteAllLines(filePath, word);

            File.ReadLines(filePath).ToList();

            foreach (string myEnd_list in word)
            {
                Console.WriteLine(myEnd_list);
            }

           


            Console.ReadKey();
        }
    }
}
