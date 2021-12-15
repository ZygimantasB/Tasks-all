using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Užduotis_Metematika_pakartojimas
{
    public class Skaicius : IMatematika
    {
        public readonly int Sveikasis_skaicvius1;
        public readonly int Sveikasis_skaicvius2;

        public Skaicius (int sveikasis_skaicius1, int sveikasis_skaicius2)
        {
            Sveikasis_skaicvius1 = sveikasis_skaicius1;
            Sveikasis_skaicvius2 = sveikasis_skaicius2;
        }

        public int Atimti(int a, int b)
        {
           int sudetis = Sveikasis_skaicvius1 - Sveikasis_skaicvius2;
            return sudetis;
        }

        public double Dalyba(double a, double b)
        {
            double dalyba = Sveikasis_skaicvius1 / Sveikasis_skaicvius2;
            return dalyba;
        }

        public int Padauginbti(int a, int b)
        {
            int padauginti = Sveikasis_skaicvius1 * Sveikasis_skaicvius2;
            return padauginti;
        }

        public double PakeltiKubu(double a)
        {
            double pakelti_kubu = Math.Pow(Sveikasis_skaicvius1, 3);
            return pakelti_kubu;
        }

        public double PakeltiKvadratu(double a)
        {
            double pakelti_kvadratu = Math.Pow(Sveikasis_skaicvius1, 2);
            return pakelti_kvadratu;

        }

        public int Prideti(int a, int b)
        {
            int sudetis = Sveikasis_skaicvius1 + Sveikasis_skaicvius2;
            return sudetis;
        }
    }

}
