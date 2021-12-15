using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Struct
{
    class Naujos_kalses_sukurimas : IPrintData
    {
        void IPrintData.NaujasList()
        {
            Console.WriteLine("Bus sukuriamas vardu sarasas");
        }

        void IPrintData.NaujasSkaicius()
        {
            Console.WriteLine("Bus irasomas skaicius");
        }

        void IPrintData.NaujasZodis()
        {
            Console.WriteLine("Bus irasomas naujas sugalvotas zodis");
        }
    }
}
