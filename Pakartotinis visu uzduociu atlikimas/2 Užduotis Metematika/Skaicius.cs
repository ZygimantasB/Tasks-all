using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Užduotis_Metematika
{
    class Skaicius : IMatematika
    {
        public readonly int Skaicius_veiksmui;

        public int Atimti(int skaicius)
        {
            int atimtis = skaicius - skaicius;
            return atimtis;
        }

        public double Padalinti(double skaicius)
        {
            double dalyba = (double)skaicius / (double)skaicius;
            return dalyba;
        }

        public int Padauginti(int skaicius)
        {
            int dauginti = skaicius * skaicius;
            return dauginti;
        }

        public double PakeltiKubu(double skaicius)
        {
            double kelt_kubu = Math.Pow(skaicius, 3);
            return kelt_kubu;
        }

        public double PakeltiKvadratu(double skaicius)
        {
            double kelk_kvadratu = Math.Pow(skaicius, 2);
            return kelk_kvadratu;
        }

        public int Prideti(int skaicius)
        {
            int sudetis = skaicius + skaicius;
            return sudetis;
        }
    }
}
