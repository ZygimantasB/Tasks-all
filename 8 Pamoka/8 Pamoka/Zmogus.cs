using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Pamoka
{
    class Zmogus
    {
        public string Vardas;
        public string Pavarde;

        public Zmogus (string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public virtual void ZmogausDuomenys()
        {
            Console.WriteLine("Laba diena mano vardas yra " + Vardas + " mano pavarde yra " + Pavarde);
        }

    }
}
