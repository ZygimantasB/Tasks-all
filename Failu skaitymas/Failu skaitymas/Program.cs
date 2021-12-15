using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failu_skaitymas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pavyzdys numeris 1");
            //Console.WriteLine("Pavyzdys numeris 1");
            //Console.WriteLine("Pavyzdys numeris 1");

            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Failu sukurimas\test.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList(); // Yra pavyzdys, kaip perskaityti faiulus, kurie yra mano list, bet reikia sukurti foreatch

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("Bandymas, Ar man pavyko ?");

            //File.WriteAllLines(filePath, lines);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Pavyzdys numeris 2");

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.I_live = entries[2];

                people.Add(newPerson);
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } : { person.I_live}");
            }

            people.Add(new Person { FirstName = "Abrom", LastName = "Linkoln", I_live = "Wachington" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName}, {person.LastName}, { person.I_live}");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();
        }
    }
}
