using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_perrasymas_1_uzduotis
{
    public class Gyventojas : Pilietis
    {
        
        public Gyventojas (string vardsa, string pavarde, string asmensKodas, string gyvenamojiVieta) : base(vardsa, pavarde, asmensKodas)
        {
            GyvenamojiVieta = gyvenamojiVieta;
        }

        public string GyvenamojiVieta { get; }
        public override void Info ()
        {
            base.Info();
            Console.WriteLine($"Gyvenamoji vbieta: {GyvenamojiVieta}");
        }


    }
}
