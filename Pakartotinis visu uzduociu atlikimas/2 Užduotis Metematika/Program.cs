using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Užduotis_Metematika
{
    class Program
    {
        static void Main(string[] args)
        {
            Skaicius atlikime_veiksmus = new Skaicius();

            Console.WriteLine("Irasykite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());

            int veiksmas_pridetis = atlikime_veiksmus.Prideti(skaicius);
            int veiksmas_atimtis = atlikime_veiksmus.Atimti(skaicius);
            int veiksmas_daugyba = atlikime_veiksmus.Padauginti(skaicius);
            double veiksmas_dalyba = atlikime_veiksmus.Padalinti(skaicius);
            double veiksmas_pakeltiKvadratu = atlikime_veiksmus.PakeltiKvadratu(skaicius);
            double veiksmas_pakeltiKubu = atlikime_veiksmus.PakeltiKubu(skaicius);

            Console.WriteLine($"Sudetis: {skaicius} + {skaicius} = {veiksmas_pridetis}");
            Console.WriteLine($"Atimtis: {skaicius} - {skaicius} = {veiksmas_atimtis}");
            Console.WriteLine($"Daugyba: {skaicius} * {skaicius} = {veiksmas_daugyba}");
            Console.WriteLine($"Dalyba: {skaicius} / {skaicius} = {veiksmas_dalyba}");
            Console.WriteLine($"Kelimas kvadratu: {skaicius}^2 = {veiksmas_pakeltiKvadratu}");
            Console.WriteLine($"Kelimas kubu: {skaicius}^3 = {veiksmas_pakeltiKubu}");

            Console.ReadLine();
        }
    }
}
