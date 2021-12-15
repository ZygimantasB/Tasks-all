using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_are_Delegates
{
    public delegate int OperationDelegate(int param1, int param2);
    class Program
    {
        static int Add (int p1, int p2)
        {
            return p1 + p2;
        }

        static int Multiplay (int p1, int p2)
        {
            return p1 * p2;
        }
        static int Divide (int number1, int number2)
        {
            return number1 / number2;
        }

        static int Substraction (int number1, int number2)
        {
            return number1 - number2;
        }
        static void Main(string[] args)
        {
            OperationDelegate del = Add;
            int result = del(1, 6);
            OperationDelegate multi = Multiplay;
            int ansver = multi(7, 9);

            OperationDelegate div = Divide;
            int divideResult = div(8,2);

            OperationDelegate subs = Substraction;
            int resultSubstraction= subs(89,78);


            Console.WriteLine(result);

            Console.WriteLine(ansver);

            Console.WriteLine(divideResult);

            Console.WriteLine(resultSubstraction);



            Console.ReadKey();
        }
    }
}
