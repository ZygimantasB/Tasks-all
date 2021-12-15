using System.Collections.Generic;

namespace AstuntaPamoka
{
    public class Zaidejas
    {
        public List<Korta> Ranka { get; }
        public Zaidejas(string vardas)
        {
            Vardas = vardas;
            Ranka = new List<Korta>();
        }

        public string Vardas { get; }

        public void ImtiKorta(Korta korta)
        {
            Ranka.Add(korta);
        }
    }
}
