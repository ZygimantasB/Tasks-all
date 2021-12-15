using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_uzduotis_su_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Snipas> snipu_sarasas = new List<Snipas>();
            Console.WriteLine("Irasykite snipo varda:");
            string snipo_vardas = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Snipas slaptieji_agentai = new Snipas($"{i} {snipo_vardas}", 0);
                snipu_sarasas.Add(slaptieji_agentai);

                for (i = 0; i < 10; i++)
                {
                    slaptieji_agentai.Infiltraciju_skaicius();
                }

            }
        }
    }
}
