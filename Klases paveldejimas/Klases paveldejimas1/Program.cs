using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases_paveldejimas1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Automobilis
    {
        public string Modelis = "Audi";
        public string Marke = "A4";
        public int Rida = 456789;
        public List<string> bandomi_automobiliai;

        //public List<string> bandomi_automobiliai = List<string>() { "BMW", "AUDI", "TRAKTORIUS LAMBORGINI", "FERRARI" };


    public void Automobilio_duomenys(string modelis, string marke, int rida, List<string> bandomi_automobiliai)
        {
            Modelis = "Audi";
            Marke = "A4";
            Rida = 456789;
            //public List<string> bandomi_automobiliai = List<string>() { "BMW", "AUDI", "TRAKTORIUS LAMBORGINI", "FERRARI" };
}
    }
    class Garažas : Automobilis
    {
        Automobilis ar_galivaziuoti = new Automobilis();

        Console.WriteLine("Automobilis" + ar_galivaziuoti ); // kodėl aš negaliu prieit prie per objektą ?
    }

}
