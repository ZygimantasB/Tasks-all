using System;

namespace Viskas_viename_ko_ismokau;
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[2];
            number[0] = 11;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[0]);

            var nepatinka = new bool[5];
            nepatinka[0] = true;

            Console.WriteLine(nepatinka[0]);
            Console.WriteLine(nepatinka[0]);
            Console.WriteLine(nepatinka[1]);
            Console.WriteLine(nepatinka[0]);
            Console.WriteLine(nepatinka[0]);

            int a = 15;
            byte k = (byte)a;
            Console.WriteLine(a);

            string zodis = "22";
            int s = int.Parse(zodis);
            Console.WriteLine(zodis);

            var labas = "99";
            int m = Convert.ToInt32(labas);
            Console.WriteLine(labas);
            
        }
    }
}
