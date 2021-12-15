using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_garazas_ir_automobilis
{
    class Automobilis
    {
        public string Modelis;
        public int Rida;
        public bool Galima_vaziuoti;

        public Automobilis(string modelis, int rida, bool galima_vaziuoti)
        {
            Modelis = modelis;
            Rida = rida;
            Galima_vaziuoti = galima_vaziuoti; // šiuoje vietoje man reiktų nurodyti Galima_vaziuoti true; ????
        }

        public Automobilis (string modelis, int rida) // metodu daugaiu pasidariau, nes ne visu triju reikšmių manau man reiks
        {
            Modelis = modelis;
            Rida = rida;
        }

        public Automobilis(string modelis)
        {
            Modelis = modelis;
        }


        public void Vaziuoti ()
        {
            Console.WriteLine($"Šiuo metu vaziuoja automobilis {Modelis}. Esama rida yra {Rida}. " +
                $"Ridos padidėjimas {Rida + 1}. Automobilis sugedo {Rida = 10}");
        }

    }
}
