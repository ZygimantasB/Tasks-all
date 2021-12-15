using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("irasyktie skaiciu");
                int skaicius1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("irasyktie skaiciu");
                int skaicius2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(skaicius1 / skaicius2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
