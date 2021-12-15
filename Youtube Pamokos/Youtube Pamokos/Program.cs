using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Pamokos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init VAriables
            string thematrix, system, neo, enemy, inside, fight;
            string[] profession = new string[4], adj = new string[2];
            // Get Input From User
            Console.WriteLine("Welcome user");
            Console.WriteLine("Lets Play the game of madman");
            Console.WriteLine("Please share with me your name");

            neo = Console.ReadLine();

            // Getting the matrix variable from user
            
            Console.WriteLine($"Hello {neo}! Are you ready ? What is somerthing you want to " +
                $"know more about");

            thematrix = Console.ReadLine();

            Console.WriteLine($"You want to know more about {thematrix} huh ?");
            Console.WriteLine($"Okay well first tell me what you already know aobut {thematrix}");
            Console.WriteLine($"What noun would you categtorize {thematrix} as:");
            system = Console.ReadLine();

            // Getting enemy varaible from user
            Console.WriteLine($"Give me an aposing noun to {system}");
            enemy = Console.ReadLine();

            Console.WriteLine($"Now give me any relaxing noun (presnet tense)");
            inside = Console.ReadLine();

            //Getting all professions fro muser
            Console.WriteLine("Mow I need four professions");
            
            for (int i = 0; i < profession.Length; i++)
            {
                Console.WriteLine($"Profession (plirall) {i + 1} / {profession.Length}");
                profession[i] = Console.ReadLine();
            }

            // Init Story

            string manoistroija =
            $"{thematrix} is a {system}, {neo}.That system is our {enemy}." +
            $"But when you're {inside}, you look around, what do you see?" +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}.The very minds of the" +
            $"people we are trying to save.But until we do, these people are " +
            $"still a part of that system and that makes them our enemy.You have" +
            $"to understand, most of these people are not ready to be unplugged." +
            $"And many of them are so inured, so hopelessly {adj[1]} on the" +
            $"{system}, that they will {fight} to protect it.";

            // Print Story
            Console.WriteLine(manoistroija);

        }
    }
}
