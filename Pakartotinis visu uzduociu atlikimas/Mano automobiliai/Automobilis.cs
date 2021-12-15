using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mano_automobiliai
{
    public class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Metai;
        public int Rida;
        public string Ar_atlikta_technikine;

        public Automobilis (string marke, string modelis, int metai, int rida, string ar_atlikta_technikine)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
            Ar_atlikta_technikine = ar_atlikta_technikine;
        }

        public void Automobilio_duomenys ()
        {
            Console.WriteLine($"Marke {Marke}. Modelis {Modelis}. Metai {Metai}. Rida {Rida}. {Ar_atlikta_technikine}");


            if (Ar_atlikta_technikine == "taip")
            {
                Console.Write("Technikine atlikta");
            }
            else if (Ar_atlikta_technikine == "ne")
            {
                Console.Write("Technikine neatlikta");

            }

            //bool mano_pasirinkimas = true;

            //while (mano_pasirinkimas)
            //{
            //    if (Ar_atlikta_technikine == "taip")
            //    {
            //        Console.Write("Technikine atlikta");
            //    }
            //    else if (Ar_atlikta_technikine == "ne")
            //    {
            //        Console.Write("Technikine neatlikta");

            //    }


            //    Console.WriteLine("Pakartokite taip arba ne");
            //    Ar_atlikta_technikine = Console.ReadLine();

            //    if(Ar_atlikta_technikine != "taip")
            //    {
            //        mano_pasirinkimas = false;
            //    }
            //    if (Ar_atlikta_technikine != "ne")
            //    {
            //        mano_pasirinkimas = false;
            //    }
            //}

        }
        



        //public void Automobilio_duomenys1 (string marke, string modelis, int metai, int rida, string ar_atlikta_technikine)
        //{
        //    if (ar_atlikta_technikine == "taip")
        //    {
        //        Console.WriteLine("Technikine atlikta");
        //    }
        //    else if (ar_atlikta_technikine == "ne")
        //    {
        //        Console.WriteLine("Technikine neatlikta");

        //    }

        //    Console.WriteLine($"Marke {marke}. Modelis {modelis}. Metai {metai}. Rida {rida}. {ar_atlikta_technikine}");
        //}

        //public string Ar_atlikta_technikine;

        //public Automobilis(string ar_atlikta_technikine)
        //{
        //    Ar_atlikta_technikine = ar_atlikta_technikine;
        //}
        //public void Ar_atlikta_technikine1(string ar_atlikta_technikine)
        //{
        //    Ar_atlikta_technikine = ar_atlikta_technikine;
        //}

        //public void Automobilio_duomenys ()
        //{
        //    //Ar_atlikta_technikine = Console.ReadLine().ToLower();

        //    if (Ar_atlikta_technikine == "taip")
        //    {
        //        Console.WriteLine("Technikine atlikta");
        //    }
        //    else if (Ar_atlikta_technikine == "ne")
        //    {
        //        Console.WriteLine("Technikine neatlikta");

        //    }
    }
    
}
