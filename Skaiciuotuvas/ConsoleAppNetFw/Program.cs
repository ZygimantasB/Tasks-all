using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNetFw
{
    class Program
    {
        static void Main(string[] args)
        {
            // Susikuriam klases skaiciuotuvas kokrecias reiksmes (objektus) kaip ir pvz List<string> kazkoksSarasas = new List<string>();
            Skaiciuotuvas skaiciuotuvasApple = new Skaiciuotuvas("Apple");
            Skaiciuotuvas skaiciuotuvasSamsung = new Skaiciuotuvas("Samsung");

            //Zemiau atliekam veiksmus su sukurtais objektais (konkretus objektas "daro" veiksma
            skaiciuotuvasApple.Sum(1, 2);
            skaiciuotuvasApple.Subtract(9, 5);
            skaiciuotuvasApple.Multiply(10, 10);

            skaiciuotuvasSamsung.Subtract(9, 5); 
            skaiciuotuvasSamsung.Divide(9, 5);

            //Isvedam atliktu veiksmu statistika
            Console.WriteLine($"Skaiciuotuvas {skaiciuotuvasApple.SkaiciuotuvoModelis} atliktas operaciju kiekis: {skaiciuotuvasApple.OperacijuKiekis}");
            Console.WriteLine($"Skaiciuotuvas {skaiciuotuvasSamsung.SkaiciuotuvoModelis} atliktas operaciju kiekis: {skaiciuotuvasSamsung.OperacijuKiekis}");

            //Atkreipkime demesi, kad objektu reiksmes (ne static) yra unikalios kiekvienam objektui. 
            //o static reiksmes - visam objekto tipui (klasei). 
            Console.WriteLine($"Visi skaiciuotuvai atliko tiek veiksmu: {Skaiciuotuvas.BendrasOperacijuKiekis}");

            Console.WriteLine("Programa baige darba!");
            Console.ReadLine();
        }
    }
}
