using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
{
    public class Korta
    {
        public Korta(string zenklas, int verte, string indeksas)
        {
            Zenklas = zenklas;
            Verte = verte;
            Indeksas = indeksas;
        }

        public string Zenklas { get; }
        public int Verte { get; }
        public string Indeksas { get; }
    }
}
