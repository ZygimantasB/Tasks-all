using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Uzduotis_Geometrija_pakartojimas
{
    interface IGeometrija
    {
        double Plotas(double a);
        double Plotas(double a, double b);
        double Perimetras(double a);
        double Perimetras(double a, double b);
    }
}
