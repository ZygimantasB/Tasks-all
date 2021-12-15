using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_su_automobiliais_klases
{
    class Automobilis
    {
        public string Modelis;
        public int Rida;
        public bool GalimaVaziuoti;

        public Automobilis(string modelis, int rida, bool galimavziuoti)
        {
            Modelis = modelis;
            Rida = rida;
            GalimaVaziuoti = galimavziuoti;
        }
        public void Automobilio_metodas_vaziuoti()
        {
            Console.WriteLine("Ridos padidejimas " + Rida++ + " Jus vairuojate automobili " + Modelis + ". " + " Siuo metu automobilio rida yra " + Rida);
        }

    }
}
