using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_5_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.Write a program in C# Sharp to create a file with text and read the file. Go to the editor
            // Expected Output:

            // Here is the content of the file mytest.txt:
            // Hello and Welcome
            // It is the first content
            // of the text file mytest.txt


            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest 5 uzduotis pakartojimas.txt";

            try
            {
                using (FileStream fileStr = File.Create(filePath))
                {
                    Console.WriteLine("failas yra sukurtas");
                }

                using (StreamWriter fileWriter = File.CreateText(filePath))
                {
                    Console.WriteLine("papildomi zodziai yra prideti");
                    fileWriter.WriteLine("Siandien yra sestadienis");
                    fileWriter.WriteLine("Mokausi kodinti");
                    fileWriter.WriteLine("Sekasi gerai");

                    string sarasas = File.ReadAllLines(filePath).ToString();

                    File.ReadAllText(filePath)
                    {

                    }
                        
                }

            }
            catch (Exception Isimtis)
            {
                Console.WriteLine(Isimtis);
            }
            Console.ReadKey();
        }
    }
}
