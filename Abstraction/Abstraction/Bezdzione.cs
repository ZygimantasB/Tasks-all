using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Bezdzione : Gyvunas
    {
        public int Ant_kiek_koju_vaiksto_bezdzione;

        public Bezdzione()
        {
            Ant_kiek_koju_vaiksto_bezdzione = 2;
        }

        public override void Kvepuoti()
        {
            throw new NotImplementedException();
        }
    }
}
