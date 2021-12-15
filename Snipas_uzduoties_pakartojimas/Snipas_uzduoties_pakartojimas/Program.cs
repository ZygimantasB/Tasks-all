using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snipas_uzduoties_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int pridedama_po_viena_operacija = 1;

            Console.WriteLine("Irasykite kiek norite tureti snipu");
            int snipu_skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite snipo varda: ");
            string snipo_vardas = Console.ReadLine();

            Snipas sugalvok_snipo_varda = new Snipas(snipo_vardas, snipu_skaicius);

            sugalvok_snipo_varda.Snipo_vardas();

            bool kelitna_infiltracija = true;

            while (kelitna_infiltracija != false)
            {
                for (int i = 0; i < snipu_skaicius; i++)
                {
                    Console.WriteLine("Ar" + snipo_vardas + " nori infiltruotis ?");
                    string ar_norite_infiltruotis = Console.ReadLine();

                    kelitna_infiltracija = ar_norite_infiltruotis.ToLower() == "taip";

                    //if (kelitna_infiltracija)
                    //{
                    //    sugalvok_snipo_varda.Infiltraciju_skaicius();
                    //}

                    Console.WriteLine(sugalvok_snipo_varda.Kelinta_karta_infiltruojasi_snipas);
                }

                //Console.WriteLine(sugalvok_snipo_varda.Kelinta_karta_infiltruojasi_snipas);
            }
            

            //foreach (var isvardink_snipu_vardus in snipo_vardas)
            //{
            //    Console.Write("Snipu vardai yra: " + isvardink_snipu_vardus);
            //}


            Console.ReadKey();
        }
    }
}
