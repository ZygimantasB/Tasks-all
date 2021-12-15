using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
{
    public class Pilietis : Zmogus
    {
        public string AsmensKodas { get; }

        public Pilietis(string vardas, string pavarde, string asmensKodas) : base(vardas, pavarde)
        {
            AsmensKodas = asmensKodas;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Asmens kodas: {AsmensKodas}");
        }
    }
}
