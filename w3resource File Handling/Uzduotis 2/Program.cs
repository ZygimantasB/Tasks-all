using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program in C# Sharp to remove a file from the disk. 

            // ------ Variantas 1 ----------------- mano sprendimas
            //Console.WriteLine("Varinatas 1");

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest.txt";

            File.Create(filePath);

            File.Delete(filePath);

            Console.WriteLine("Failas istrintas");

            // ------ Variantas 2 ----------------- 
            Console.WriteLine("Varinatas 2");

            string fileName = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest.txt";
            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
            Console.Write("--------------------------------------------------------------\n");

            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($" The file {fileName} deleted successfully.\n\n");
            }
            else
            {
                Console.WriteLine(" File does not exist");

                Console.ReadLine();
            }
        }
    }
}
