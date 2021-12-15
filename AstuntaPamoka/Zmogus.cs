using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
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

        public virtual void Info()
        {
            Console.WriteLine($"{Vardas} {Pavarde}");
        }
    }
}
