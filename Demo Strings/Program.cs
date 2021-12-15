using System;

namespace Demo_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullname = firstName + " " + lastName;

            var myfullname = string.Format("my name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hello my name\n is dosint matter\n hello world\n c:\\filmia\\yra\\geri";
            Console.WriteLine(text);

            var texts = @"Hello my name
is dosint matter 
hello world 
c:\\filmia\\yra\\geri";
            Console.WriteLine(texts);
        }
    }
}
