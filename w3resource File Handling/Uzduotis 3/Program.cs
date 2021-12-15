using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Write a program in C# Sharp to create a blank file in the disk if the same file already exists.

            // ------ Variantas 1---------------- - mano sprendimas
            Console.WriteLine("Varinatas 1");

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest.txt";
            string filePath1 = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest";

            if (File.Exists(filePath))
            {
                File.Create(filePath1);
                Console.WriteLine("Failas egzistuoja, sukurtas naujas failas mytest");
            }
            else
            {
                Console.WriteLine("Failo nera, naujo kurti nereikia");
            }

            // ------ Variantas 2 -----------------
            Console.WriteLine("Varinatas 2");

            string fileName = @"mytest.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Create a file in the disk if it is exists:\n");
                Console.Write("-----------------------------------------------\n");
                // Create the file.
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

            

            Console.ReadKey();
        }
    }
}
