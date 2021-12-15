using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_apskritimas_Uzduotis_1
{
    public class Apskritimas
    {
        public double Apskritimo_spindulys;

        public Apskritimas (double apskritimo_spindulys)
        {
            Apskritimo_spindulys = apskritimo_spindulys;
        }
       
        public double GautiPlota ()
        {
            double a_plotas = 2 * Math.PI * Apskritimo_spindulys;
            return a_plotas;
        }
        public double Apskritimo_ilgis_R()
        {
            double a_ilgis = Math.PI * Math.Pow(Apskritimo_spindulys, 2);
            return a_ilgis;
        }
    }
}
