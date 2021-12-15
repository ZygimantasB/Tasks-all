using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas_1_uzduotis
{
    public class Pilietis : Zmogus
    {
       
        public string AsmensKodas { get; } // Gali tiketis asmens kodo is savo konstruktoriaus
        //public string Pilietybe;

        public Pilietis (string vardas, string pavarde, string asmensKodas) : base(vardas, pavarde)
        {
            AsmensKodas = asmensKodas;
        }

        public override void Info()
        {
            base.Info(); // base kreipiasi i paveldeta klase // base reiskia, akd yra kreipiamasi i bazine klase. 
            //Console.WriteLine($"Asmeens kodas: {AsmensKodas}"); // AUksiauc yra parasyta lygiai tas pats. 
        }
    }
}
