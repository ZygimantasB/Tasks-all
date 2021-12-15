using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_struct_so_for_ciklu
{
    public class ManoStruct
    {
        public int SkaiciusInt;
        public string Tekstas;
        public List<string> NewList;

        public ManoStruct (string manotekstas, int skaiciusint, List<string> sarasas)
        {
            Tekstas = manotekstas;
            SkaiciusInt = skaiciusint;
            NewList = sarasas;
        }
        public void PrintData()
        {
            Console.WriteLine(Tekstas);
            Console.WriteLine(SkaiciusInt);
            for (int i = 0; i < NewList.Count; i++)
            {
                Console.WriteLine(NewList.ElementAt(i));
            }
        }
    }
}
