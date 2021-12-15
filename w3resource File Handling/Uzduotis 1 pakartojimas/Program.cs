using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_1_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to create a blank file in the disk newly. Go to the editor

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest 1 uzduotis pakartojimas.txt";

            try
            {
                Console.Write("\n\n Create a file named mytest1.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");

                using (FileStream fileStr = File.Create(filePath))
                {
                    Console.WriteLine("Failas pavadinimu mytest 1 uzduotis pakartojimas.txt yra sukurtas");
                }
            }
            catch (Exception ManoIsimtis)
            {
                Console.WriteLine(ManoIsimtis.ToString());
                throw;
            }
            Console.ReadLine();
        }
    }
}
