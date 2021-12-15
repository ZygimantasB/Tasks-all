using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_007
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Irasykite snipo varda");
                string snipo_vardas = Console.ReadLine();
                Console.Write($"{i + 1}. ");
                Snipas snipo_vardo_is_metodo = new Snipas(snipo_vardas);
                
                snipo_vardo_is_metodo.Snipo_vardo_parasymas();
                Console.WriteLine("---------------------------");
                snipo_vardo_is_metodo.Infiltruojasi_didejimas();
                //Console.WriteLine($"Snipas infiltravosi {i + 1} karta");  Nemoku padaryti su metodu, gaunasi tik kaip šiuoje vietoje padaryta
            }
        }
    }
}
