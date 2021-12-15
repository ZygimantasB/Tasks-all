using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int p = 1;

            for (i = 0; i <= 1000; i++)
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            for (p = 0; p <= 1000; p++)
                if(p % 5 == 0)
                {
                    Console.WriteLine(p);
                }
            Console.WriteLine(p + i);
            Console.ReadLine();
            
        }
    }
}
