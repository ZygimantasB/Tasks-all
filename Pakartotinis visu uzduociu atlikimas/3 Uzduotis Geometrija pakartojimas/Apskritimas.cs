using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Uzduotis_Geometrija_pakartojimas
{
    class Apskritimas : Figura, IGeometrija, IInformacija
    {
        double Apskritimo_spindulys_R;

        Apskritimas(double apskritimo_spindulys_r, string figurospavadinimas) : base(figurospavadinimas)
        {
            Apskritimo_spindulys_R = apskritimo_spindulys_r;
            Figuros_pavadinimas = figurospavadinimas;
        }

        public void Info()
        {
            Console.WriteLine($"Figuros pavadinimas yra: {Figuros_pavadinimas}");
            Console.WriteLine($"Aaskritimo spindulys R yra: {Apskritimo_spindulys_R}");
        }

        public double Perimetras(double apskritimo_spindulys_r)
        {
            double apskritimo_perimetras = Math.PI * Math.Pow(Apskritimo_spindulys_R, 2); 
            return apskritimo_perimetras;
        }

        public double Plotas(double apskritimo_spindulys_r)
        {
            double apskritimo_plotas = 2 * Math.PI * Apskritimo_spindulys_R;
            return apskritimo_plotas;
        }
    }
}
