using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_pamokos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            for (int i = 0; i < 20; i++)
                Console.WriteLine($"Dabartinis skaicius {i}");
            if (i % 3 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is triju" + i);
                Console.ReadLine();
            }



            //for (int i = 0; i < 20; i+=3)
            //    Console.WriteLine($"Dabartinis skaicius {i}");
        }
    }
}
