using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_3_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Write a program in C# Sharp to create a blank file in the disk if the same file already exists

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest 3 uzduotis pakartojimas.doc";

            try
            {
                using (FileStream fileStr = File.Create(filePath))
                {
                    Console.WriteLine("failas yras sukurtas");
                }
            }
            catch (Exception Mano)
            {
                Console.WriteLine(Mano);
            }

            Console.ReadKey();
        }
    }
}
