using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciu_speliojimo_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pabandykite atspeti skaiciu, kuris yra tarp 1 ir 10");

            Console.WriteLine("Irasyktie slapta skaiciu");
            int slaptas_skaicius = int.Parse(Console.ReadLine());

            while (slaptas_skaicius != 5)
            {

                if (slaptas_skaicius > 1 && slaptas_skaicius < 5)
                {
                    Console.WriteLine("Slaptas skaicius yra didesnis");
                }
                else if (slaptas_skaicius > 5 && slaptas_skaicius <=10)
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis");
                }
                else if (slaptas_skaicius <= 0 || slaptas_skaicius > 10)
                {
                    Console.WriteLine("Slaptas skaicius yra nepatenka i rezius");
                }

                slaptas_skaicius = int.Parse(Console.ReadLine());


                if (slaptas_skaicius == 5)
                {
                    Console.WriteLine("Atspejote");
                }

                


            }
            Console.ReadKey();

        }
    }
}
