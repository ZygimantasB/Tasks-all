using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suprogramuoti_kortu_galede
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List<string> SkaiciuTipai = new List<string>() { "Bugnai", "Sirdys", "Pikai", "Kryziai" };

            List<string> GalvuTipai = new List<string>() { "Brtukas", "Dama", "Karalius", "Tuzas" };

            foreach (var kortukalade in SkaiciuTipai)

            foreach (var GalvuKalade in GalvuTipai)

            for(int i = 2; i <= 10; i++)
            {
                Console.Write(i + " " + GalvuKalade + " " + kortukalade + " ");
                Console.Write(i + " " + GalvuKalade + " " + kortukalade + " ");
                Console.Write(i + " " + GalvuKalade + " " + kortukalade + " ");
                Console.WriteLine(i + " " + GalvuKalade + " " + kortukalade + " ");
            }

            Console.ReadLine();
        }
    }
}
