using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_pakartojimas_visos_užduotys
{
    class Uzuotis_isvardinti_automobilius
    {
        public string Automobilio_marke;
        public string Automobilio_modelis;
        public int Automobilio_pagaminimo_metai;
        public int Automobilio_rida;

        public Uzuotis_isvardinti_automobilius(string automobilio_marke, string automobilio_modelis, int automobilio_pagaminimo_metai, int automobilio_rida)
        {
            Automobilio_marke = automobilio_marke;
            Automobilio_modelis = automobilio_modelis;
            Automobilio_pagaminimo_metai = automobilio_pagaminimo_metai;
            Automobilio_rida = automobilio_rida;
        }
        public void Atvaizduojama_informacija()
        {
            Console.WriteLine($"Turimas automobilis: {Automobilio_marke}");
            Console.WriteLine($"Automobilio modelis: {Automobilio_modelis}");
            Console.WriteLine($"Automobilio pagaminimo metai: {Automobilio_pagaminimo_metai}");
            Console.WriteLine($"Automobilio rida: {Automobilio_rida}");
        }

    }
}
