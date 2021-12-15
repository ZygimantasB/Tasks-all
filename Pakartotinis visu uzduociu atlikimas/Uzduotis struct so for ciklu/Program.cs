using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_struct_so_for_ciklu
{
    class Program
    {
        static void Main(string[] args)
        {
            Klase myclass = new Klase();
            List<string> manosarasas = new List<string>();
            manosarasas.Add("Tekstas1");
            manosarasas.Add("Tekstas2");
            ManoStruct manostruct = new ManoStruct("Labas rytas", 52, manosarasas);

            List<int> sarasasint = new List<int>();
            sarasasint.Add(1);
            sarasasint.Add(52);
            sarasasint.Add(74);

            myclass.sarasas = sarasasint;

            manostruct.PrintData();
            myclass.PrintData();
            Console.ReadLine();
        }
    }
}
