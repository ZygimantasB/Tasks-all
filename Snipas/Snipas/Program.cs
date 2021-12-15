using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas
{
    class Program
    {
        static void Main(string[] args)
        {
            Snipo_infiltracija slaptasis_agentas = new Snipo_infiltracija();

            bool kiek_kartu_infiltravosi_snipas = true;

            Console.WriteLine("Kiek norite kartu, akd infiltruotosi musu snipas");
            int kiek_kartu_kartoti_veiksma = Convert.ToInt32(Console.ReadLine());

            List<Snipas> snipu_sarasas = new List<Snipas>();
            {

                for (int i = 0; i < kiek_kartu_kartoti_veiksma; i++)
                {

                    while (kiek_kartu_infiltravosi_snipas != false)

                    {
                        Console.WriteLine("Kiek kartu infiltravosi snipas");
                        string vartotojo_ivedimas = Console.ReadLine();

                        kiek_kartu_infiltravosi_snipas = vartotojo_ivedimas == "Taip";

                        if (kiek_kartu_infiltravosi_snipas)
                        {
                            
                        }

                    }

                }
            }
        }
    }
}
