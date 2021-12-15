using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Kate nauja_kate = new Kate();

            Bezdzione nauja_bezdzione = new Bezdzione();

            List<Gyvunas> mano_augintiniai = new List<Gyvunas>();

            mano_augintiniai.Add(nauja_bezdzione);
            mano_augintiniai.Add(nauja_kate);
        }
    }
}
