using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandymas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tikrina();

            Console.ReadKey();
        }
        private static void Tikrina()
        {
           for (int i = 0; i < 1000; i++)
           for (int j = 0; j < 1000; j++)
                {
                    if (i % 3 == 0)
                    if (j % 5 == 0)
                        {
                            int suma = i + j;
                            Console.WriteLine(suma);
                        }
                }
            
        }
    }
}
