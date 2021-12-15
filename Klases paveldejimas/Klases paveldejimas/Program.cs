using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases_paveldejimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis bandymas_automobilis = new Automobilis();
            Dviratis bandymas_dviratis = new Dviratis();
            Valtis bandymas_valtis = new Valtis();

            bandymas_automobilis.Vaziuoti();

            Console.WriteLine(bandymas_automobilis.Speed);
            Console.WriteLine(bandymas_dviratis.Ratai);
            Console.WriteLine(bandymas_valtis.Ratai);
            Console.WriteLine(bandymas_valtis.Speed);

            bandymas_dviratis.Vaziuoti();

            Console.WriteLine(bandymas_dviratis.Speed);
            Console.WriteLine(bandymas_dviratis.Ratai);

            bandymas_valtis.Vaziuoti();

            Console.WriteLine(bandymas_valtis.Speed);
            Console.WriteLine(bandymas_valtis.Ratai);

            Console.ReadKey();
        }
    }
    class Automobilis
    {
        public int Speed = 0;

        public void Vaziuoti()
        {
            Console.WriteLine("Automobilis glai vaziuoti");
        }
        
    }
    class TransportoPriemones : Automobilis
    {
        public int Ratai = 4;
    }
    class Dviratis : Automobilis
    {
        public int Ratai = 2; 
    }
    class Valtis : Automobilis
    {
        public int Ratai = 0;
    }
}
