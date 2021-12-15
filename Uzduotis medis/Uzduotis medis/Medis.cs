using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_medis
{
    class Medis
    {
        public int Lapu_skaicius;
        public int Saku_skaicius { get; private set; } // get bet kas gali matyti, set bus matoma tik pačioje klasėje

        public Medis()
        {
            Lapu_skaicius = 0;
            Saku_skaicius = 0;
        }
        public void Saku_augimas()
        {
            Saku_skaicius = Saku_skaicius + 1;
        }
    }
}

