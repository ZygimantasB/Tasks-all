using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_007
{
    class Snipas
    {
        public string Snipo_vardas;
        public int Kiek_kartu_infiltruosis_snipas { get; private set; }

        public Snipas (string snipo_vardas)
        {
            Snipo_vardas = snipo_vardas;
            Kiek_kartu_infiltruosis_snipas = 0; // Nesuprantu, kaip padaryti jam priskiriant 0, kad didetu infiltracija. Šiuoje vietoje nesuprantu. 
        }

        public void Snipo_vardo_parasymas()
        {
            Console.WriteLine("Mano vardas yra " + Snipo_vardas);
        }

        public void Infiltruojasi_didejimas()
        {
            Console.WriteLine($"Snipas infiltravosi + {Kiek_kartu_infiltruosis_snipas = Kiek_kartu_infiltruosis_snipas + 1}" );
        }
    }
}
