using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketvirta_papildoma_užduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite oro temperatūrą Farenheitais: ");
            double Farenheitas = Convert.ToDouble(Console.ReadLine());
            double Celcijus = (Farenheitas - 32) * 5 / 9;

            Console.WriteLine("Temperatūra pagal Farenheitą yra {0} °F, o pagal Celcijų yra {1:0.00} °C",
                Farenheitas, Celcijus);
            //Console.WriteLine("Pakeitus temperatūra į celcijų " + Celcijus + " °C");
            Console.ReadLine();
        }
    }
}
