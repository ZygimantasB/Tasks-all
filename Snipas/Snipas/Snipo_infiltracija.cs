using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas
{
    class Snipo_infiltracija
    {
        public int Snipo_veiksmai { get; private set; }

        public Snipo_infiltracija()

        {
            Snipo_veiksmai = 0;
        }

        public void Snipas()
            {
            Snipo_veiksmai += 1; 
            }

    }
}
