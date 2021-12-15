using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_6_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Write a program in C# Sharp to create a file and write an array of strings to the file. Go to the editor
            //Test Data:
            //Input number of lines to write in the file :2
            //Input 2 strings below :
            //Input line 1 : this is 1st line
            //Input line 2 : this is 2nd line
            //Expected Output :

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\test 6 uzduotis.txt";

            

            try
            {
                using (FileStream strWriter = File.Create(filePath))
                {
                    string[] tekstas = new string[1];
                    tekstas.Append("Input line 1 : this is 1st line");
                    tekstas.Append("Input line 2 : this is 2nd line");
                    tekstas = File.ReadAllLines(filePath).ToArray();

                    Console.WriteLine("failas yra sukurtas");
                    File.WriteAllLines(filePath, tekstas);

                    foreach(var nezinau in tekstas)
                    {
                        Console.WriteLine(tekstas);
                    }
                }

            }
            catch (Exception ArPavyks)
            {
                Console.WriteLine(ArPavyks);
            }
            Console.ReadKey();
        }
    }
}
