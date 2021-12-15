using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_su_automobiliais_klases
{
    class Garazas
    {
        public string Automobiliu_sarasas;
        public int Taisyti;

        public Garazas (string automobiliu_sarasas, int taisyti)
        {
            Automobiliu_sarasas = automobiliu_sarasas;
        }
        public void PilnasAutoimobiliuSarasas()
        {
            Console.WriteLine("Automobiliu sarasas yra " + Automobiliu_sarasas);
        }
        public void Metodas_taisyti ()
        {
            
        }
        public void Metodas_bandyti_vaziuoti ()
        {
            Automobilis tikrinti_ar_gali_vaziuoti = new Automobilis(Automobiliu_sarasas, 10, true);

            if (Automobiliu_sarasas = )
            {
                Console.WriteLine("Galima vaziuoti su automobiliu");
            }
        }
    }
}
