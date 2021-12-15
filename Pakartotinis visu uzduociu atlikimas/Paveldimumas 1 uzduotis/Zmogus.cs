using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas_1_uzduotis
{
    public class Zmogus
    {
        public string Vardas { get; }
        public string Pavarde { get; }

        public Zmogus (string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }
        public virtual void Info () // galime pasidaryti savo metoda virtualiu // tas kas paveldes gales pasirasyti metoda savaip
        {
            Console.WriteLine($"Zmogaus vardas yra: {Vardas} ir pavarde yra {Pavarde}");
        }
    }
}
