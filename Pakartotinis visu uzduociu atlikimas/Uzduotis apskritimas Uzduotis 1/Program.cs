using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_apskritimas_Uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Uzduotis 1:

            //*Sukurti klase Apskritimas, kuriai per konstruktoriu paduodamas apskritimo spindylys.Realizuoti metodus GautiPlota ir GautiIlgi.
            //* Sukurti klase Keturkampis, kuriai per konstruktoriu paduodami keturkampio krastiniu ilgiai. Realizuoti metodus GautiPlota ir GautiPerimetra.
            //* Sukurti klase Trikampis, kuriai per konstruktoriu paduodama trikampio trys krastines.  Realizuoti metodus GautiPerimetra, GautiPusperimetri ir GautiPlota()

            Console.WriteLine("Irasykite R");
            double apskritimas_r = Convert.ToDouble(Console.ReadLine());

            Apskritimas skaiciuokle = new Apskritimas(apskritimas_r);

            double apskritimas1 = skaiciuokle.Apskritimo_ilgis_R();
            double apskritimas2 = skaiciuokle.GautiPlota();

            Console.WriteLine(apskritimas1);
            Console.WriteLine(apskritimas2);

            Console.WriteLine("Keturkampoio apskaiciavimas krastine");
            double krastine = double.Parse(Console.ReadLine());

            Keturkampis keturkampis_apskaiciavimas = new Keturkampis(krastine);

            double keturkampis1 = keturkampis_apskaiciavimas.Gauti_ilgi();
            double keturkampis2 = keturkampis_apskaiciavimas.Gauti_plota();

            Console.WriteLine(keturkampis1);
            Console.WriteLine(keturkampis2);

            Console.WriteLine("Irasykite trikampio krastine A");
            double krastine_a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasykite trikampio krastine B");
            double krastine_b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Irasykite trikampio krastine C");
            double krastine_c = Convert.ToDouble(Console.ReadLine());

            Trikampis trikampio_krastines = new Trikampis(krastine_a, krastine_b, krastine_c);

            double trikampis1 = trikampio_krastines.Trikampio_perimetras();
            double trikampis2 = trikampio_krastines.Trikampio_pusperimetris();

            Console.WriteLine(trikampis1);
            Console.WriteLine(trikampis2);

            Console.ReadKey();
        }
    }
}
