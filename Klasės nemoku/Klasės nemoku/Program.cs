using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_nemoku
{
   
     
    class Program
    {
        static void Main(string[] args)
        {
            Duomenys();

            Console.ReadKey();
        }
        
        public static void Duomenys()
        {
            Console.WriteLine("Veiksmu skaicius");
            int veiksmai = int.Parse(Console.ReadLine());

            List<Automobilis> masinu_sarasas = new List<Automobilis>();

            for (int i = 0; i < veiksmai; i++)
            {
                Console.WriteLine("Irasykite automobilio metus");
                int metai = int.Parse(Console.ReadLine());
                Console.WriteLine("Irasykite automobilio rida");
                int rida = int.Parse(Console.ReadLine());
                Console.WriteLine("Irasykite automobilio mettechnine apziuraus");
                int technine_apziura = int.Parse(Console.ReadLine());

                Console.WriteLine("Irasykite automobilio modeli");
                string modelis = (Console.ReadLine());
                Console.WriteLine("Irasykite automobilio marke");
                string marke = (Console.ReadLine());

                Automobilis auto1 = new Automobilis(marke, modelis, rida, technine_apziura, metai);

                masinu_sarasas.Add(auto1);

            }

            

            foreach(var masina in masinu_sarasas)
            {
                Console.WriteLine($"{masina.Marke} {masina.Modelis} {masina.Rida} {masina.Technine_apziura} {masina.Metai}");
            }
            
        }
    }

}
