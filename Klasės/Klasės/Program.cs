using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės
{
    public class Wizard
    {
        public string name; // yra sukuriamas kintamasis
        public string favoriteSpell; //yra sukuriamas string, kuris laikys burtininko m4gstamiausius burtus
        private int spellSlots; // kiek mums liko liko laisvų burtų langų
        float experience; // tai parodo kokia yra mūsų burtininko patirtis. // jei nėraparašyta public arba private viskas yra į numatytą reikšmę private

        public static int Count;

        public Wizard(string _name, string _favoriteSpell) // sintaksė yra tookia pati, kaip ir sukuriant metodą // siekaint atskirti name yra naodjama _name
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            
            spellSlots = 2;
            experience = 0f;

            Count++; // tokiu atvėju kiekvieną kartą mums sukūrus burtininką prisidės po vieną. 

        }

        public void CastSpells() // yra galimybė, kuri suteikai mūsų burtininkui naudoti burtus
        {
            if(spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell); //reikai nepamiršti, kad mums reiks langu, įdeti mūsų burtui
                spellSlots--; // tai reiškia, kad kiekvieną kartą mus panaudojus burtą, mūsų langelis sumažės
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
            
        }

        public void Meditate()
        {
            Console.WriteLine(name + " mediatates to regain spell slots");
            spellSlots = 2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            //wizard01.name = "Parry Hopper"; //Mes šiame parašyme prieiname prie mūsų burtininko nuosavybių
            //wizard01.favoriteSpell = "Unexpecto Patronum"; public wizzard sukurus naujus favorite spell ir name mums leidžia mūsų kodą padaryti daug švaresnį
            //wizard01.spellSlots = 2; //  Suk8rus konstruktoriu, mums to neberikia daryti čia public Wizard()
            //wizard01.experience = 0f; // viskas yra padaroma automatiškai sukūrus nauja burtininką

            

            wizard01.CastSpells();

            Wizard wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");

            wizard02.CastSpells();

            Console.WriteLine(Wizard.Count);
            

        }
    }
}
