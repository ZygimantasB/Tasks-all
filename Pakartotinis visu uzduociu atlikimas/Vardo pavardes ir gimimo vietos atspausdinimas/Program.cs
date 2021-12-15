using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vardo_pavardes_ir_gimimo_vietos_atspausdinimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasyktie savo varda");
            string mano_vardas = Console.ReadLine();

            Console.WriteLine("Irasyktie savo pavarde");
            string mano_pavarde = Console.ReadLine();

            Console.WriteLine("Irasyktie savo gyvenamaja vieta");
            string mano_gyv_vieta = Console.ReadLine();

            Console.WriteLine($"{mano_vardas} {mano_pavarde} {mano_gyv_vieta}");

            Console.ReadKey();
        }
    }
}
