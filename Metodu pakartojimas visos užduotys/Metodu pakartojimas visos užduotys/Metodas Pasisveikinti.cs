using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_pakartojimas_visos_užduotys
{
    class Metodas_Pasisveikinti
    {
        public string Irasykite_savo_varda;
        public int Irasyktie_savo_amziu;
        public string Irasykite_hobio_pavadinima;


        public Metodas_Pasisveikinti (string irasykite_savo_varda, int irasykite_savo_amziu, string irasykite_hobio_pavadinima)
        {
            Irasykite_savo_varda = irasykite_savo_varda;
            Irasyktie_savo_amziu = irasykite_savo_amziu;
            Irasykite_hobio_pavadinima = irasykite_hobio_pavadinima;
        }
        public void Uzduoties2_rezultatas ()
        {
            Console.WriteLine($"Jusu vardas \n {Irasykite_savo_varda}");
            Console.WriteLine($"Jusu amzius \n {Irasyktie_savo_amziu}");
            Console.WriteLine($"Hobio pavadinimas \n {Irasykite_hobio_pavadinima}");

            Console.WriteLine($"Labas, {Irasykite_savo_varda} ({Irasyktie_savo_amziu}m.). \n Jusu irasytas hobis: {Irasykite_hobio_pavadinima}");
        }
    }
}
