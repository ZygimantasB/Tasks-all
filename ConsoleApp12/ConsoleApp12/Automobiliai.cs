using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Automobiliai
    {
        public string Modelis;
        public string Marke;
        public int Pagaminimo_metai;
        public int Rida;
        public bool Technikines_apziura;

        public Automobiliai(string modelis, string marke, int pagaminimo_metai, int rida, bool technikines_apziura)
        {
            Modelis = modelis;
            Marke = marke;
            Pagaminimo_metai = pagaminimo_metai;
            Rida = rida;
            Technikines_apziura = technikines_apziura;
        }
    }
}

