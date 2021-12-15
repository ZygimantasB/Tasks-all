using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = new string[5];
            int[] amziai = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Irasykite varda:");
                vardai[i] = Console.ReadLine();
                Console.WriteLine("Irasyti amziu");
                amziai[i] = int.Parse(Console.ReadLine());


            for (int j = 0; vardai[i] < 5; i++)

                foreach (var suyvesti_vardai in vardai)
                    {
                        Console.WriteLine($"{suyvesti_vardai}");
                    }
                
            }
                

            Console.ReadKey();
        }
    }
}
