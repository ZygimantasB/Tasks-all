using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_enum
{
    public enum SavaitesDienos
    {
        Pirmadienis = 1,
        Antradienis, 
        Treciadienis,
        ketvirtadienis,
        Penktadienis,
        Sestadienis,
        Sekmadienis
    }
        

    class Program
    {

        static void Main(string[] args)
        {
            SavaitesDienos kuriDiena = SavaitesDienos.ketvirtadienis;


            if (kuriDiena == SavaitesDienos.Pirmadienis)
            {
                Console.WriteLine("Pirmadienis");
            }
            if (kuriDiena == SavaitesDienos.Antradienis)
            {
                Console.WriteLine("Antradienis");
            }
            if (kuriDiena == SavaitesDienos.Treciadienis)
            {
                Console.WriteLine("Treciadienis");
            }
            if (kuriDiena == SavaitesDienos.ketvirtadienis)
            {
                Console.WriteLine("Ketvirtadienis");
            }
            if (kuriDiena == SavaitesDienos.Penktadienis)
            {
                Console.WriteLine("Penktadienis");
            }
            if (kuriDiena == SavaitesDienos.Sestadienis)
            {
                Console.WriteLine("Sestadienis");
            }
            if (kuriDiena == SavaitesDienos.Sekmadienis)
            {
                Console.WriteLine("Sekmadienis");
            }

            Console.ReadKey();

        }
    }
}
