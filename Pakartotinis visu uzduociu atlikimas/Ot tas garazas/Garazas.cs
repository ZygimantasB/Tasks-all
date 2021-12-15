using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ot_tas_garazas
{
    class Garazas
    {
        public List<string> Automobiliu_sarasas = new List<string> { "Audi", "Bmw", "Skoda", "Nissan", "VW" };

        public Garazas (List<string> automobiliu_sarasas)
        {
            Automobiliu_sarasas = automobiliu_sarasas;
        }

        public void Taisyti()
        {
            Console.WriteLine("Irtasyktie automobilio rida");
            int automobilio_rida = Convert.ToInt32(Console.ReadLine());
            
            bool ar_gali_vaziuoti = false;

            foreach (var auto in Automobiliu_sarasas) ;
            
                Automobilis objekto_sukurimas = new Automobilis(auto, automobilio_rida, ar_gali_vaziuoti);
           
            

                    if (( == false) )
                    {
                    Console.WriteLine("Automobili reikia taisyti");
                    }
        }
        public void BandytiVaziuoti()
        {
            Console.WriteLine($"Galite vaziuoti su turimu automobiliu {Automobiliu_sarasas}");
        }

    }
}
