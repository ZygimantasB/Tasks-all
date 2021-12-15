using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzuotis_klases_pasikartio;

namespace Uzuotis_klases_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Apskirtimias apskritimas1 = new Apskirtimias(20); // naujas objektas new
            Apskirtimias apskritimas2 = new Apskirtimias(25);
            Apskirtimias apskritimas3 = new Apskirtimias(30);

            Console.WriteLine($"Pirmo apskirtimo plotas {apskritimas1.Apskritimo_plotas()} Antro apskritimo plotas {apskritimas2.Apskritimo_plotas()} trecio apskiritmo plotas {apskritimas3.Apskritimo_plotas()}");

            Keturkampis keturkampis1 = new Keturkampis(14);
            Keturkampis keturkampis2 = new Keturkampis(28);
            Keturkampis keturkampis3 = new Keturkampis(31);

            Console.WriteLine($"{keturkampis1.Keturkampio_plotas} {keturkampis2.Keturkampio_plotas} {keturkampis3.Keturkampio_plotas}");

            Console.ReadKey();
        }

        //public static void Keturkampio_rezultatas()
        //{
            
        //}
    }
}
   

