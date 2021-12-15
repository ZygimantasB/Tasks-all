using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_6
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

            //string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\Mytest 6 task.txt";

            //string[] sarasiukas = new string[1] { "this is 1st line, this is 2nd line" };
            //sarasiukas = File.ReadAllLines(filePath).ToArray();

            //foreach (var fullSarasiukas in sarasiukas)
            //{
            //    Console.WriteLine(fullSarasiukas);
            //}

            //File.WriteAllLines(filePath, sarasiukas);


            // Variantas 2

            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i;

            Console.Write("\n\n Create a file and write an array of strings  :\n");
            Console.Write("---------------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write($" Input {n} strings below :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write($" Input line: {i + 1}");
                ArrLines[i] = Console.ReadLine();
            }
            File.WriteAllLines(fileName, ArrLines);

            using (StreamReader sr = File.OpenText(fileName)) // sunaikina sr, veikas vyksta tik skliaustuose. 
            {
                string s = "";
                Console.Write($"\n The content of the file is {n}  :\n");
                Console.Write("----------------------------------\n");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine($" {s} ");
                }
                Console.WriteLine();


                Console.ReadLine();
            }
        }
    }
}
