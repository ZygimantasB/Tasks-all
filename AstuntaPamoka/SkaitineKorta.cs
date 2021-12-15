using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
{
    public class SkaitineKorta : Korta
    {
        public SkaitineKorta(string zenklas, int verte) : base(zenklas, verte, verte.ToString())
        {
        }
    }
}
