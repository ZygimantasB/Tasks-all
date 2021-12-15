using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NaujasList1 = new List<int> { 5, 4, 3, 2, 1};

            for (int i = 0; i < NaujasList1.Count; i++)
            {
                Console.WriteLine(NaujasList1.ElementAt(i));
            }

            Klases_sukurimnas naujas_objektas = new Klases_sukurimnas(45, "labas", NaujasList1, "labas rytas dienoje");

            naujas_objektas.Visko_atspausdinimas();

            Console.ReadKey();


        }
    }
}
