using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Pamoka
{
    class Pilietis : Zmogus
    {
        public string AsmensKodas { get; }
        public Pilietis(string vardas, string pavarde, string asmensKodas) : base(vardas,pavarde) // base 
        {
            AsmensKodas = asmensKodas;
        }

        public override void ZmogausDuomenys()
        {
            base.ZmogausDuomenys();
            Console.WriteLine("Asmens kodas " + AsmensKodas);
        }
    }
}
