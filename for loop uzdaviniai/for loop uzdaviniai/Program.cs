using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_uzdaviniai
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to display the first 10 natural numbers. Go to the editor
            //Expected Output:
            //1 2 3 4 5 6 7 8 9 10

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //            2.Write a C# Sharp program to find the sum of first 10 natural numbers. Go to the editor
            //            Expected Output :
            //            The first 10 natural number is :
            //            1 2 3 4 5 6 7 8 9 10
            //            The Sum is : 55


            //int suma = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    suma += i;

            //    Console.WriteLine("{0} ", suma);
            //}

            // _________ trecia uzduotis ___________

            //int suma = 0;
            //int i;

            //for (i = 0; i <= 7; i++)
            //{
            //    suma += i;
            //    Console.WriteLine(suma);
            //}

            // _________ ketvirta uzduotis ___________

            //int suma = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    suma += i;
            //    double vidurkus = suma / 10;
            //    Console.WriteLine("Pirmi desint skaiciu" + i);
            //    Console.WriteLine("Pirmu 10 skaiciu suma " + suma);
            //    Console.WriteLine("Pirmu 10 skaiciu vidurkis " + vidurkus);
            //}

            //Nuskaito mygtuko paspaudima


            // _________ penkta uzduotis ___________

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(Math.Pow(i, 3));
            //}

            // _________ sesta uzduotis ___________

            //int j = 15;

            //for (int i = 0; i <= 10; i++)
            //{
            //    int suma = 15 * i;
            //    Console.WriteLine($"{j} x {i} = {suma}");
            //}    

            // _________ septinta uzduotis ___________

            //int j = 10;
            //int k = 1;

            //for (int i = 1; i <= 8; i++)
            //{
            //    int suma = k * i;
            //    int suma1 = i * j;
            //    Console.WriteLine($"{k}x{i} = {suma} ");
            //    Console.WriteLine($"{j}x{i} = {suma1} ");
            //}

            //int suma = 0;
            //for (int i = 1; i <= 20; i += 2)
            //{
            //    suma += i;
            //    Console.WriteLine("Nelyginiai skaciai yra " + i);
            //    Console.WriteLine("Nelyginiu skaiciu suma yra " + suma);
            //}

            // _________ devinta uzduotis ___________ 

            //for (int i = 1; i <= 4; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //        Console.Write("*");
            //    Console.WriteLine("\n");
            //}

            // _________ desimta uzduotis ___________ 

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(j);
            //        Console.Write("\n");
            //}

            // _________ vienuolikta uzduotis ___________ 

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(i);
            //    Console.Write("\n");
            //}

            // _________ dvylikta uzduotis ___________ 


            //int k = 1;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)

            //        Console.Write($"{j} ");
            //    Console.Write("\n");
            //}

            // _________ trylikta uzduotis ___________ 

            int k = 1;
            
            
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{k++} ");
                Console.Write("\n");
            }



            Console.ReadKey();

        }
    }
}
