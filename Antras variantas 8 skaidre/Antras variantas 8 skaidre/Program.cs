using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antras_variantas_8_skaidre
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int suma = 1;

            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    suma = suma *i;
                }
            }

            Console.WriteLine(suma);
            Console.ReadLine();

            
            
            
            
            
            
            //int suma = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if ((i % 3 == 0) || (i % 5 == 0))
            //    {
            //        suma = suma + i;
            //    }
            //}
            //Console.WriteLine(" suma {0}", suma);
            //Console.ReadLine();



            //Console.WriteLine("Pradžia:");
            //int pradzia = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Pabaiga:");
            //int pabaiga = Convert.ToInt32(Console.ReadLine());

            //if (pradzia > pabaiga)
            //{
            //    Console.WriteLine("Blogi rėžiai") ;
            //}

            //else
            //{
            //    for (int i = pradzia; i <= pabaiga; i++)
            //    {
            //        Console.WriteLine("{0} {1}", i, Math.Pow(i,2));

            //    }
            //}
            //Console.ReadLine();



            //for (var i = 0; i <= 30; i += 3)

        }
    }
}
