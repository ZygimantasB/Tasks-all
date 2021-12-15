using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Užduotis_Geometrija
{
    internal class Apskritimas : Figura, IGeometrija, IInformacija
    {
        public readonly double Apskritimas_R;

        public Apskritimas (double apskritimas_r, string pavadinimas) : base(pavadinimas)
        {
            Apskritimas_R = apskritimas_r;
        }
        public double Apskritimas_plotas(double apskritimas_r)
        {
            double apskritimas_plotas_formule = Math.PI * Math.Pow(apskritimas_r, 2);
            return apskritimas_plotas_formule;
        }
        public double Apskritimas_perimetras (double apskritimas_r)
        {
            double apskritimas_perimetras_formule = 2 * Math.PI * apskritimas_r;
            return apskritimas_perimetras_formule;
        }

        public double Plotas()
        {
            throw new NotImplementedException();
        }

        public double Perimetras()
        {
            throw new NotImplementedException();
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas: {Pavadinimas}");
            Console.WriteLine($"Figuros spindulys R yra: {Apskritimas_R}");
        }
    }
}
