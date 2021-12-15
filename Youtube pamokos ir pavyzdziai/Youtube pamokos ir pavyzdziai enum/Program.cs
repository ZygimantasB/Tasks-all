using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_pamokos_ir_pavyzdziai_enum
{
    public enum ProductCodes
    {
        Milk = 0, 
        Juice = 1, 
        Tea = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductCodes test = ProductCodes.Milk; // Man meta klaida, nes as duomenu nenaudoju, tiesiog sakau, cia yra duomenys.
            Console.WriteLine(test);

            //norint gauti skaiciu mes naudojame casting t.y. kam lygus Milk

            ProductCodes test3 = ProductCodes.Milk;
            Console.WriteLine((int)test3);

            // Zemiau yra pateiktas pavyzdys, kai mes visame sarase ieskome
            // skaiciaus konkretaus t.y. kam jis priskirtas

            int test2 = 2;
            Console.WriteLine(((ProductCodes)test2));

            // KA REIKTU DARYTI, JEI MES NORIME VISKA GAUTI KAIP STRING

            
            Console.WriteLine(test.ToString());

            // Mes norime paimti string ir konvertuoti ji i ENUM

            string test4 = "Tea";
            ProductCodes getParse;
            bool checkParse = Enum.TryParse(test4, out getParse);
            Console.WriteLine(getParse);
            Console.WriteLine(checkParse);

            Console.ReadKey();
        }
    }
}
