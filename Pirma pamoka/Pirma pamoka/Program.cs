using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirma_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            // apskritimo apskaičiavimas

            double Pi = 3.14;

            Console.WriteLine("Įveskite apskirtimo ilgį:");
            int apskirtimo_ilgis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Pi * apskirtimo_ilgis ^ 2);
            Console.ReadLine();
            
            
            
            
            
            
            
            
            //int a = 14;
            //int b = 32;
            //int suma = a + b;

            //Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            
            //int suma1 = a - b;

            //Console.WriteLine("{0} - {1} = {2}", a, b, suma1);

            //int suma2 = a * b;

            //Console.WriteLine("{0} * {1} = {2}", a, b, suma2);

            //double suma3 = (double)a / b;

            //Console.WriteLine("{0} / {0} = {0}", a, b, suma3); //Nes indeksavimas prasideda nuo nulio. Skliaustų nereikia. 
            //Console.ReadLine();

        }
    }
}
