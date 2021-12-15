using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_skaidre
{
    class Program
    {
        static void Main(string[] args)
        {
            var limonadas = 1;
            var arbata = 2;
            var kakava = 3;
            var kava = 4;
            //var nieko = 5;

            switch (arbata)
            {
                case 1:
                    Console.WriteLine("Jūs pasirinkote limonadą");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Jūs pasirinkote arbatą");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Jūs pasirinkote kakavą");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Jūs pasirinkote kavą");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Jūs norite atšaukti pasirinkimą");
                    Console.ReadLine();
                    break;


                //    switch (Console.WriteLine("Vartotojo pasirinkimas " +
                //"Jei norite limonado spauskite 1" +
                //"Jei norite arbatos spauskite 2 " +
                //"Jei norite kakavos spauskite 3" +
                //"Jei norite kavos spauskite 4" +
                //"Jei norite atšaukti pasirinkimą spauskite 5:"))
            }
        }
    }
}
