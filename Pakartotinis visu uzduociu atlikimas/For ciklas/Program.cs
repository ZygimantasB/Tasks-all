using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ciklas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pirmas budas
            //for (int i = 0; i <= 20; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            // Antras budas
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Uzduotis2

            //Console.WriteLine("Prazdia");
            //int pradzia = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Prazdia");
            //int pabaiga = Convert.ToInt32(Console.ReadLine());

            //if (pradzia > pabaiga)
            //{
            //    Console.WriteLine("Blogi reziai");
            //}
            //else
            //{
            //    for (pradzia = 0; pradzia <= pabaiga; pradzia++ )
            //    {
            //        Console.WriteLine($"{pradzia} {Math.Pow(pradzia,2)}");
            //    }
            //}

            // suma skaiciu iki 1000, kruie dalinasi is 3 ir 5. Turite gauti 233168 atsakymą.
            //int suma = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        suma += i;
            //    }
            //}
            //Console.WriteLine($"{suma}");

            // suma skaiciu iki 10, kruie dalinasi is 3 ir 5. Šių skaičių suma yra 23.

            //int suma = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        suma += i;
            //    }
            //}
            //Console.WriteLine($"{suma}"); 

            // Rasti visų skaičių, žemesnių už 100 ir kurie dalinasi iš 7, sandaugą. Turite gauti 1760012288 atsakymą.
            //int suma = 1;
            //for (int i = 1; i < 100; i++)
            //{
            //    if( i % 7 == 0)
            //    {
            //        suma *= i;
            //    }
            //}
            //Console.WriteLine(suma);


            // - Visi skaičiai mažesni už 20 ir kurie dalinasi iš 7 yra: 7, 14. Šių skaičių sandauga yra 98.


            int suma = 1;

            for (int i = 1; i < 20; i++)
            {
                if (i % 7 == 0)
                {
                    suma *= i;
                }
            }
            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}
