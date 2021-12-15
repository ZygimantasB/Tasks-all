using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_perrasymas_1_uzduotis
{
    public class Pilietis : Zmogus 
    {
        public string AsmensKodas { get; }
        public Pilietis (string vardas, string pavarde, string asmensKodas) : base (vardas, pavarde)
        {
            AsmensKodas = asmensKodas;
        }

        public override void Info()
        {
            base.Info(); // Atsiradus base keyword, jis kreipiasi i zmogaus klae metoda Info. // Console.WriteLine ($"{Vardas} {Pavarde}")
            this.Info(); // panaudojus zodeli this, jis kreipiasi i esama METODA T.Y. kur mes dabar esame. 
            Console.WriteLine($"Asmens kodas {AsmensKodas}");
        }
    }
}
