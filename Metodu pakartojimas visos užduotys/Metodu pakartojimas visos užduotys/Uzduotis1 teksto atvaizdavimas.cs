using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_pakartojimas_visos_užduotys
{
    class Uzduotis1_teksto_atvaizdavimas
    {
        public string Teksto_iskelimas_i_konsole;

        public Uzduotis1_teksto_atvaizdavimas (string teksto_pateikimas_konsolei)
        {
            Teksto_iskelimas_i_konsole = teksto_pateikimas_konsolei;
        }

        public void Uzduotis1_atlikimas()
        {
            Console.WriteLine("Mes atspausdiname norima teksta is konsoles P A V Y Z D Y S " + Teksto_iskelimas_i_konsole);
        }

    }
}
