using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Managing_Folders_and_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Zygimantas\Desktop\C Sharp Faiilai";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories); // Visada nurodys i turima direktorija. 

            //// SearchOption.AllDirectories ... Mes galime iskoti aplankalu, aplankaluose. 

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}


            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            {
                //Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension (file));
                //Console.WriteLine(Path.GetFullPath(file));
                //Console.WriteLine(Path.GetDirectoryName(file));

                //var info = new FileInfo(file);
                //Console.WriteLine($"{Path.GetFileName(file)} : { info.Length } bytes"); // Jei nori informacijos apie faila. Norint pakeisti i kb reikia padalinti is 1024.

                
            }

            //string newPath = @"C:\Users\Zygimantas\Desktop\C Sharp Faiilai\SubFoderD";
            //Directory.CreateDirectory(newPath);


            //bool directoryExists = Directory.Exists(newPath); // Tikrinam ar egzistuoja

            //if (directoryExists)
            //{
            //    Console.WriteLine("Direktorija egzistuoja");
            //}
            //else
            //{
            //    Console.WriteLine("Direktorija neegzisutotja");
            //    Directory.CreateDirectory(newPath); // Sukurs direktorijas ir subdirektorijas, jeigu jos neegzistuoja.
            //}

            //// Failu kopijavimas

            string[] files = Directory.GetFiles(rootPath);
            string destinationFolder = @"C:\Users\Zygimantas\Desktop\C Sharp Faiilai\New folder";

            //foreach (var file in files)
            //{
            //    File.Copy(file, $"{destinationFolder} { Path.GetFileName(file)}", true); // po kalblelio mes galime paprasyti faila perrasyti, jei jis egzistuoja
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{ i }.txt", false);
            //}

            foreach (var file in files)
            {
                File.Move(file, $"{destinationFolder} { Path.GetFileName(file)}");
            }

            Console.ReadLine();
        }
    }
}
