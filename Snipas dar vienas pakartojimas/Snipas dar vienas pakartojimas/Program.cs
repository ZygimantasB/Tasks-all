using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_dar_vienas_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> snipu_sarasasa = new List<string>();

            snipu_sarasasa.Add("1. Tomas");
            snipu_sarasasa.Add("2. Simas");
            snipu_sarasasa.Add("3. Agne");
            snipu_sarasasa.Add("4. Modestas");
            snipu_sarasasa.Add("5. Tadas");
            snipu_sarasasa.Add("6. Andrius");
            snipu_sarasasa.Add("7. Sandra");
            snipu_sarasasa.Add("8. Mikas");
            snipu_sarasasa.Add("9. Gulbius");
            snipu_sarasasa.Add("10. Faustas");

            Snipas slaptasis_s1rasas_bondu = new Snipas(snipu_sarasasa, 0);

            

            


            foreach(var sarasas in snipu_sarasasa)
                Console.WriteLine(sarasas);



            Console.ReadKey();
        }
    }
}
