using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_perrasymas_1_uzduotis
{
    public class Zmogus
    {
       public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }
        public string Vardas { get; }
        public string Pavarde { get; }

        public virtual void Info () // Kas paveldes is informcaijos gales savaip pasira6yti metoda. Virtual 
                                    // rei6kia ,jeigu kas nors nores paveldeti mano 
                                    // metoda as jam leisiu ji ir kitaip realizuoti. 
        {
            Console.WriteLine($"{Vardas} {Pavarde}");
        }
    }
}
