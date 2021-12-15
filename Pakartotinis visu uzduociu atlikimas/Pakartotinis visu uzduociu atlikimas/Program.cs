using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakartotinis_visu_uzduociu_atlikimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apskaiciuojamas apskritimo ilgis ir plotas
            Console.WriteLine("Irasyktie apskritimo ilgi");
            double apskritimo_ilgis = Convert.ToInt32(Console.ReadLine());

            double suma = 2 * Math.PI * apskritimo_ilgis; //apskritimo ilgio formule
            Console.WriteLine($"APskiritmo ilgis {suma:0.00} cm");

            Console.WriteLine("Irasyktie R norint apskaiciuoti apskritimo plota");
            double apskritimo_plotas = Convert.ToInt32(Console.ReadLine());

            double apskritimo_plotas_apskaiciavimas = apskritimo_plotas / (2 * Math.PI);

            Console.WriteLine($"{apskritimo_plotas_apskaiciavimas:0:00}");

            Console.ReadLine();

        }
    }
}
