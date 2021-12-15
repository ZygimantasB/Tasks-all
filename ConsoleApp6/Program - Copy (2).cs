using System;

namespace ConsoleApp6
{
    class Program1
    {
        static void Main(string[] args)
        {
            var season = Season.Autum;

            switch (season)
            {
                case Season.Autum:
                    Console.WriteLine("It's autum and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go beach.");
                    break;

                default:
                    Console.WriteLine("I don't unserstand that seeason!");
                    break;
            }
        }
    }
}
