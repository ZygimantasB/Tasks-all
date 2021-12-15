using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_2_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kiek turite automobilių");
            //int n = int.Parse(Console.ReadLine());

            //string[] automobiliai = new string[n];

            //for (int i = 0; i <n; i++)
            //{
            //    int eile = i + 1;

            //    Console.WriteLine("Automobilis Nr. " + eile  + "\n");

            //    Console.WriteLine(eile + ". " + "Įveskite automobilį");
            //    string pasirintkti_automobiliai = Console.ReadLine();

            //    Console.WriteLine(eile + ". " + "Įveskite automobilio marke");
            //    string automobilio_marke = Console.ReadLine();

            //    Console.WriteLine(eile + ". " + "Įveskite automobilio ridą");
            //    double automobilio_rida = double.Parse(Console.ReadLine());

            //    Console.WriteLine(eile + ". " + "Įveskite iki kada galioja automobilio techninė apžiūra");
            //    double automobilio_techninkine_galioja = double.Parse(Console.ReadLine());

            //    Console.WriteLine("--------------------------------------\n");

            //    Console.WriteLine("_____Automobilio Nr. " + eile + " duomenys_______\n");

            //    Console.WriteLine($"Automobilis: {pasirintkti_automobiliai}\nMarkė: {automobilio_marke}\nRida: " +
            //        $"{automobilio_rida} km\nTechnikine galioja: {automobilio_techninkine_galioja} m.\n");
            //}


            Console.WriteLine("Kiek turite automobilių");
            int n = int.Parse(Console.ReadLine());

            List<string> automobiliai = new List <string> ();
            {
            for (int i = 0; i < n; i++)
            {
                int eile = i + 1;

                Console.WriteLine(eile + ". " + "Įveskite automobilį");
                string pasirintkti_automobiliai = Console.ReadLine();

                automobiliai.Add(pasirintkti_automobiliai);
            }

            for (int i = 0; i < n; i++)
            {
                int eile = i + 1;

                Console.WriteLine(eile + ". " + "Įveskite automobilio marke");
                string pasirintkti_automobiliai = Console.ReadLine();

                automobiliai.Add(pasirintkti_automobiliai);
            }

            for (int i = 0; i < n; i++)
            {
                int eile = i + 1;

                Console.WriteLine(eile + ". " + "Įveskite automobilio rida");
                string pasirintkti_automobiliai = Console.ReadLine();

                automobiliai.Add(pasirintkti_automobiliai);
            }

            for (int i = 0; i < n; i++)
            {
                int eile = i + 1;

                Console.WriteLine(eile + ". " + "Įveskite automobilio TA");
                string pasirintkti_automobiliai = Console.ReadLine();

                automobiliai.Add(pasirintkti_automobiliai);
            }



            {

            Console.ReadKey();



        }
    }
}
