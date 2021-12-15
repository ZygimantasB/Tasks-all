using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvo_sukurimas
{
    class Program
    {
        static void Main(string[] args)
        {
            int atsakymas;
            int count = 0;

            Console.WriteLine("Irasykite pirma skaiciu, su kuriuo norite atlikti aritmetini veiksma: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu, su kuriuo norite atlikti aritmetini veiksma: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite koki veiksma norite atlikti (+, -, *,. /)");
            string aritmetinis_veiksmas = Console.ReadLine();

            bool kartojimas = false;

            
            //string vartotojo_ivedimas = Console.ReadLine();
            //kartojimas = vartotojo_ivedimas == "taip";


            while (kartojimas)
            {
                switch (aritmetinis_veiksmas)

                {
                    case "+":
                        atsakymas = skaicius1 + skaicius2;
                        Console.WriteLine(atsakymas);
                        break;
                    case "-":
                        atsakymas = skaicius1 - skaicius2;
                        Console.WriteLine(atsakymas);
                        break;
                    case "*":
                        atsakymas = skaicius1 * skaicius2;
                        Console.WriteLine(atsakymas);
                        break;
                    case "/":
                        Console.WriteLine((double)skaicius1 + (double)skaicius2);
                        break;
                }
            }
            //Console.WriteLine("Ar nborite kartoti ?");
            //string ivestis = Console.ReadLine();
            //if (ivestis != "taip")
            //{
            //    kartojimas = true;
            //}
            Console.ReadKey();
        }
    }
}
