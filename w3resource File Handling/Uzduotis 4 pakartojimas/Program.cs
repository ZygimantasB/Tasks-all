using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Write a program in C# Sharp to create a file and add some text

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\mytest 4 uzduotis pakartojimas.txt";

            List<string> pridetiniaiZodziai = new List<string>();
            pridetiniaiZodziai.Add("Labas");
            pridetiniaiZodziai.Add("Rytas");
            pridetiniaiZodziai.Add("Siandien");
            pridetiniaiZodziai.Add("Sestadienis");
            pridetiniaiZodziai.Add("As");
            pridetiniaiZodziai.Add("Coooding dooing");

            try
            {
                if (File.Exists(filePath))
                {
                    Console.WriteLine("failo kurti nereikia");

                    using (StreamWriter strWriter = File.CreateText(filePath))
                    {
                        Console.WriteLine("Mes pridedama i faila duomenis");
                        strWriter.WriteLine("Labas");
                        strWriter.WriteLine("Rytas");
                        strWriter.WriteLine("Siandien");
                        strWriter.WriteLine("Sestadienis");
                    }
                }
                else if (File.CreateText(filePath))
                {
                    using (FileStream fileStream = File.Create(filePath)
                    {

                    }
                    
                }
            }
            catch (Exception Isimtuke)
            {
                Console.WriteLine(Isimtuke);
            }
            Console.ReadLine();
        }
    }
}
