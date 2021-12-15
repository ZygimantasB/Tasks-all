using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Užduotis_Metematika_pakartojimas
{
    public interface IMatematika
    {
        int Prideti(int a, int b);

        int Atimti(int a, int b);

        int Padauginbti(int a, int b);

        double Dalyba(double a, double b);

        double PakeltiKvadratu(double a);

        double PakeltiKubu(double a);
        
    }
}
