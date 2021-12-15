using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_lyginimas_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite pirmą skaičių:");
            Int32 pirmas_skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            Int32 antras_skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečią  skaičių:");
            Int32 trecias_skaicius = Convert.ToInt32(Console.ReadLine());

            if (pirmas_skaicius > antras_skaicius &&
                pirmas_skaicius < 100)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antr1 skaici7, " +
                    "taciau mazesnis u= 100");
            }
            else if (antras_skaicius > 0 &&
                antras_skaicius > pirmas_skaicius) 
            {
                Console.WriteLine("Antras skaicius yra didesnis uz 0 ir didesnis uz pirm1j5 skaiciu");
            }
            else if (pirmas_skaicius > antras_skaicius &&
                pirmas_skaicius > trecias_skaicius || pirmas_skaicius > 0)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz 0 ir " +
                    "didesnis uz pirm1j5 skaiciu arba didesnis uz nuli");
            }
            else if (trecias_skaicius >= 5 &&
                trecias_skaicius <= 10)
                {
                Console.WriteLine("trecias skaicius yra tarp 5 ir 10");
                }







            //Console.WriteLine("Įveskite pirmą skaičių:");
            //Int32 pirmas_skaicius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Įveskite antrą skaičių:");
            //Int32 antras_skaicius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Įveskite trečią  skaičių:");
            //Int32 trecias_skaicius = Convert.ToInt32(Console.ReadLine());


            //if ( pirmas_skaicius > antras_skaicius && pirmas_skaicius > trecias_skaicius)
            //{
            //    Console.WriteLine("Primas skai2ius yra didesnis u= antr1 ir trečią skaičių");
            //    Console.ReadLine();
            //}
            //else if ((pirmas_skaicius < antras_skaicius && pirmas_skaicius < trecias_skaicius))
            //{
            //    Console.WriteLine("Pirmas skaičiųs yra mažesnis už antrą ir trečią skaičių");
            //    Console.ReadLine();
            //}

            //else if ((pirmas_skaicius > antras_skaicius && pirmas_skaicius < trecias_skaicius))
            //{
            //    Console.WriteLine("Pirmas skaičiųs yra didesnis už antrą skaičių, tačiau mažewsnis už trečią skaičių trečią skaičių");
            //    Console.ReadLine();
            //}

            //else if ((pirmas_skaicius < antras_skaicius && pirmas_skaicius > trecias_skaicius))
            //{
            //    Console.WriteLine("Pirmas skaičiųs yra mažesnis už antrą skaičių, tačiau didesnis už trečią skaičių");
            //    Console.ReadLine();
            //}

            //else
            //{
            //    Console.WriteLine("Sąlyga yra netisinga");
            //    Console.ReadLine();
            //}
        }
    }
}
