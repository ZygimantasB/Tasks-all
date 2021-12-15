using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_medzio_sukurimas
{
    public class Medis
    {
        public int Medis_turi_saku { get; private set; }
        public int Medis_auga;

        public Medis()
        {
            Medis_turi_saku = 0;
            Medis_auga = 0;
        }
        public void Kiek_paaugo_medis()
        {
            Medis_turi_saku = Medis_turi_saku + 1;
        }
        
    }
}
