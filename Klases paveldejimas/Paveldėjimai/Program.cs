using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldėjimai
{
    class Program
    {
        static void Main(string[] args)
        {
            Hobiai mano_hobiai = new Hobiai();

            mano_hobiai.Masinos_ir_Kompiuteriai("BMW", "PC");

            Maistas mano_maistas = new Maistas();

            mano_maistas.Vaisiai_ir_Darzoves();

            Console.ReadLine();

        }
    }
    class Hobiai
    {
        public string Masinos;
        public string Kompiuteriai;

        public string Sugalvok;
        
        public void Masinos_ir_Kompiuteriai(string masinos, string kompiuteriai/*, /*out string sugalvok*/)
        {
            Console.WriteLine("Man patinka šios " + masinos + " .Aš megstu " + kompiuteriai /*sugalvok*/);

            //string sugalvok = "Hobiai ir hobiai";
        }
    }
    class Maistas
    {
        public string Vaisiai = "Bananas";
        public string Darzoves = "Morka";

        public void Vaisiai_ir_Darzoves ()
        {
            Console.WriteLine("Man patinka " + Vaisiai + " .Sias darzoves as megst " + Darzoves);
        }
    }

    interface IPastebejimai
    {
        void Hobiai();

    }
}
