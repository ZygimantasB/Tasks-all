using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdaviniai
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.w3resource.com/csharp-exercises/for-loop/index.php uzduotys

            //________Pirma uzduotis____________
            //1.Write a program in C# Sharp to display the first 10 natural numbers. Go to the editor
            //1 2 3 4 5 6 7 8 9 10

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //____Antra uzduotis_____________

            //int suma = 0;
            //for ( int i = 1; i <= 10; i++)
            //{
            //    suma = suma + i;
            //    Console.WriteLine(suma);
            //}

            //________Trecia uzduotis____________

            //int suma = 0;
            //for (int n = 1; n <=7; n++)
            //{
            //    suma = suma + n;
            //    Console.WriteLine($"Skaciai is eiles {n} Skaiciu suma {suma}");
            //}

            //_____________ketvirta uzduotis____________ PAVIZDI GALIMA KARTS NUO AKRTO PASIZIURETI !!!!!!!!!!

            //int i, n;
            //int suma = 0;
            //double vidurkis;

            //for (i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("Iveskite skaiciu {0}", i);
            //    n = int.Parse(Console.ReadLine());

            //    suma += n;
            //}
            //vidurkis = 10.0;
            //Console.WriteLine($"Skaiciu suma: {suma} Skaiciu vidurkis: {vidurkis}");

            //_____________penkta uzduotis____________
            //    int i, n;

            //    for (i = 1; i <= 5; i++)
            //    {
            //        Console.WriteLine("Pirmas skaicius yra {0}", $"{Math.Pow(i,3)}");
            //    }
            //}
            //_____________sesta uzduotis____________

            //int i;
            //int skaicius = 15;

            //for (i = 1; i <= 15; i ++)
            //{
            //    int sandauga = skaicius * i;
            //    Console.WriteLine($"{skaicius} * {i} = {sandauga}");
            //}

            //_____________septinta uzduotis____________

            //int i;
            //int number = 10;

            //for (i = 1; i <= 8; i++)
            //{
            //    int sandauga = number * i;
            //    Console.Write($"{number}*{i}={sandauga} ");
            //}

            //_____________astunta uzduotis____________

            //int i;
            //int suma = 0;
            //int n;


            //Console.WriteLine("Irasykite norima skaiciu:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nelyginiai skaiciai");

            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Skaiciai {0} ",2*i-1);
            //    suma += 2 * i - 1;
            //}
            //Console.WriteLine($"Nelyginiai skaiciai yra {n} skaiciu suma {suma}");

            //_____________devinta uzduotis____________  NELABAI SUPRTAU SIOS UZDUOTIES !!!!!!!!!

            //Console.WriteLine("Enter the  N number of limit");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int i, j;
            //Console.WriteLine("The Right Angled Triagle is");
            //Console.WriteLine("\n");
            //for (i = 1; i <= N; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");

            //}
            //Console.ReadLine();

            //_____________DESIMTA uzduotis____________ NELABAI SUPRTAU SIOS UZDUOTIES !!!!!!!!!

            //Console.WriteLine("Iveskite kiek jums reiks eiluciu:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} ", j);
            //    }
            //    Console.ReadLine();
            //}

            //_____________vienuolikta uzduotis uzduotis____________


            //Console.WriteLine("Kiek eiluciu norite irasyti:");
            //int eilute = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= eilute; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    Console.Write("{0} ", i);
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            //_____________dvylikta uzduotis uzduotis____________

            //int k = 1;
            //Console.WriteLine("Iveskite eilutes:");
            //int eilutes = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= eilutes; i++)
            //{
            //    for (int j = 1; j <= i; j++)

            //    Console.Write("{0} ", k++);
            //    Console.WriteLine("\n");
            //}
            //Console.ReadLine();

            //_____________trylikta uzduotis uzduotis____________

            int i, j, spc, rows, k, t = 1;

            Console.Write("Irasykite eiluciu skaiciu : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;


                
            }



            // Laukia kol bus paspaustas klavisas
            Console.ReadKey();
        }
    }
}

