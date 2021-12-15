using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
{
    public class Zaidimas
    {
        private List<Korta> _kortuKalade = new List<Korta>();
        private int _kortuSk = 52;
        private string[] _kortuZenklai = new string[] { "Kryzius", "Vynas", "Bugnas", "Sirdis" };

        public Zaidimas(int zaidejuSkaicius)
        {
            ZaidejuSkaicius = zaidejuSkaicius;
            UzpildytiZenklais(_kortuSk, _kortuZenklai, _kortuKalade);
        }

        public int ZaidejuSkaicius { get; }

        public void Zaisti()
        {
            foreach (Korta korta in _kortuKalade)
            {

            }
        }
        private void UzpildytiZenklais(int kortuSkaicius, string[] kortuZenklai, List<Korta> kortuKalade)
        {
            foreach (string zenklas in kortuZenklai)
            {
                int vienoZenkloKiekis = kortuSkaicius / kortuZenklai.Length;

                for (int i = 2; i < vienoZenkloKiekis - 2; i++)
                {
                    kortuKalade.Add(new SkaitineKorta(zenklas, i));
                }

                kortuKalade.Add(new Galva(zenklas, "B"));
                kortuKalade.Add(new Galva(zenklas, "Q"));
                kortuKalade.Add(new Galva(zenklas, "K"));
                kortuKalade.Add(new Galva(zenklas, "A"));
            }
        }
    }
}
