using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Write a program in C# Sharp to create a file with text and read the file. Go to the editor
            //Expected Output:

            //Here is the content of the file mytest.txt:
            //Hello and Welcome
            //It is the first content
            //of the text file mytest.txt


            // ------ Variantas 1 ----------------
            Console.WriteLine("Varinatas 1");

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\test 5 uzduotis.txt";

            List<string> word = new List<string>();
            word = File.ReadAllLines(filePath).ToList();

            foreach (var words in word)
            {
                Console.WriteLine(words);
            }

            word.Add("Hello and Welcome");
            word.Add("It is the first content");
            word.Add("of the text file mytest.txt");

            File.WriteAllLines(filePath, word);

            //using (StreamWriter strWrite = File.CreateText(filePath))
            //{
            //    strWrite.WriteLine(" Hello and Welcome");
            //    strWrite.WriteLine(" It is the first content");
            //    strWrite.WriteLine(" of the text file mytest.txt");
            //}




            // ------ Variantas 2 ----------------
            Console.WriteLine("Varinatas 2");

            string fileName = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\w3resource\test 4 uzduotis.txt";

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Create a file with content in the disk :\n");
                Console.Write("---------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                    Console.WriteLine(" A file created with content name mytest.txt\n\n");
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
