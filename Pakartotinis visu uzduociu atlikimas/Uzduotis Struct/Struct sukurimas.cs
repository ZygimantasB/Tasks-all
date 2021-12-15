using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Struct
{
    public struct Struct_sukurimas : IPrintData
    {
        public string NaujasZodis;
        public int NaujasSkaicius;
        public List<string> NaujasList;

        public Struct_sukurimas (string naujas_zodis, int naujas_skaicius, List<string> naujas_list)
        {
            NaujasZodis = naujas_zodis;
            NaujasSkaicius = naujas_skaicius;
            NaujasList = naujas_list;
        }

        public string Zodziu_isvedimas ()
        {
            return NaujasZodis = "Laba diena";
        }

        public int Naujo_skaiciaus_isvedimas()
        {
            return NaujasSkaicius = 19;
        }
        public List<string>Naujo_list_isvedimas () 
        {
            List<string> NaujasList = new List<string> { "Tomas", "Otilija", "Gerda" };
            return NaujasList;

        }
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
