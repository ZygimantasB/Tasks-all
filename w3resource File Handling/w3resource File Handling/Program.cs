using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3resource_File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to create a blank file in the disk newly. Go to the editor
            //Expected Output:
            //A file created with name mytest.txt

            // ------ Variantas 1 ----------------- mano sprendimas
            Console.WriteLine("Varinatas 1");

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest.txt";

            File.Create(filePath);

            // ------ Variantas 2 ----------------- mano sprendimas
            Console.WriteLine("Varinatas 2");

            string fileName = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest1.txt";
            try
            {
                Console.Write("\n\n Create a file named mytest1.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");
                // Create the file.
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest1.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }


            Console.ReadLine();
        }
    }
}
