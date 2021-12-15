using System;
using New_Operator.Math;

using New_Operator.Math;

namespace New_Operator.Math
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);

            Console.WriteLine(result);

        }
    }
}
