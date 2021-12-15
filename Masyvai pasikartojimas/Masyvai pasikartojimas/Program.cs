using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai_pasikartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vardai = new List<string>();

            List<string> pavardes = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Irasykite varda");
                string asmens_vardas = Console.ReadLine();

                Console.WriteLine("Irasykite pavarde");
                string asmens_pavarde = Console.ReadLine();
            

                vardai.Add(asmens_vardas);

                pavardes.Add(asmens_pavarde);
                {
                    foreach (var sarasas in vardai)
                        foreach (var sarasas1 in pavardes)
                            Console.WriteLine($"Sarasas pildosi ({sarasas}) ({sarasas1})");
                }
            }
        }
    }
}
