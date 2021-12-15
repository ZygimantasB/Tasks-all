using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimas_užduoties_pakartojimas
{
    class Apskritimas
    {
        public double R;
        public double Apskritimo_ilgis;

        public Apskritimas(double r, double apskritimo_ilgis)
        {
            R = r;
            Apskritimo_ilgis = apskritimo_ilgis;
        }
        public double Apskritimo_plotas()
        {
            double apskritimo_plotas_plotas = Math.PI * Math.Pow(R, 2);
            return apskritimo_plotas_plotas;
        }

        public double Apskritimo_ilgio_apskaiciavimas()
        {
            double apskritimo_ilgio_formule = 2 * Math.PI * R;
            return apskritimo_ilgio_formule;
        }
    }
}
