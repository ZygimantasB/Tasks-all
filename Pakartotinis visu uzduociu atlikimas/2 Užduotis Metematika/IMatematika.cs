using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Užduotis_Metematika
{
    interface IMatematika
    {
        int Prideti(int skaicius);
        int Atimti(int skaicius);
        int Padauginti(int skaicius);
        double Padalinti(double skaicius);
        double PakeltiKvadratu(double skaicius);
        double PakeltiKubu(double skaicius);

    }
}
