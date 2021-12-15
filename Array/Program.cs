using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var cats = new bool[3];
            cats[0] = true;

            Console.WriteLine(cats[0]);
            Console.WriteLine(cats[1]);
            Console.WriteLine(cats[2]);

            var names = new string[3] { "Jack", "John", "Marry" };
        }
    }
}
