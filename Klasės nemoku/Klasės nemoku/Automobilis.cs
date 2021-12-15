using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_nemoku
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Rida;
        public int Metai;
        public int Technine_apziura;

        public Automobilis(string marke, string modelis, int rida, int technine_apziura, int metai)
        {
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Technine_apziura = technine_apziura;
            Metai = metai;
        }
    }
}
