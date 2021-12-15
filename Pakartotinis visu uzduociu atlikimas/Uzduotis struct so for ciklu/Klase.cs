using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_struct_so_for_ciklu
{
    public class Klase
    {
        public string vardas { get; set; } = "Pavadinimas";
        public int sveikasSk { get; set; } = 22;
        public List<int> sarasas { get; set; } = new List<int>();

        public void PrintData()
        {
            string ivestis = String.Join(",", sarasas);
            Console.WriteLine($"{vardas} {sveikasSk} {ivestis}");
        }
    }
}
