namespace Foreatch_paaiškinimas
{
    partial class Program
    {
        class Mano_automobiliu_informacija
        {
            string Marke;
            string Modelis;
            int Pagaminimo_metai;
            int Rida;
            bool Techninkines_atlikimas;

            public Mano_automobiliu_informacija(string marke, string modelis, int pagaminimo_metai, int rida, bool techninkines_atlikimas)
            {
                Marke = marke;
                Modelis = modelis;
                Pagaminimo_metai = pagaminimo_metai;
                Rida = rida;
                Techninkines_atlikimas = techninkines_atlikimas;
            }
           
        }

    }
}
