using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_2_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Write a program in C# Sharp to remove a file from the disk.

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest 2 uzduotis pakartojimas.txt";

            if(File.Exists(filePath))
            {
                Console.WriteLine("Failas egzistuoja");
                Console.WriteLine("Faila reikalinga istrinti");
                File.Delete(filePath);
                Console.WriteLine("Failas yra istrintas");
            }
            else
            {
                Console.WriteLine("Failas yra sukurtas");
                File.Create(filePath);
            }

            //try
            //{
            //    using (FileStream fileStr = File.Create(filePath))
            //    {
            //        Console.WriteLine("Failas yra sukurtas"); 
            //    }

            //    File.Delete(filePath);
            //}
            //catch (Exception manoIsimtis)
            //{
            //    Console.WriteLine(manoIsimtis);
            //}

            Console.ReadKey();
        }
    }
}
