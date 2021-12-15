using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithMosh_3_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timespan = new TimeSpan(1, 2, 3); // 1 val. 2 min 3 s
            var timespan1 = new TimeSpan(1, 0, 0); // 1 val. 0 min 0 s 

            // siekiant sukurti daug geriau skaitomą TimeSpan objektą mes naudojame static metodus 

            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration:" + duration);

            // Properties
            // TimeSpan turi ypatybių, kurios ateina poromis.
            // 
            Console.WriteLine("Minutes:" + timespan.Minutes); // gražiną minučių komponentą of TimeSpan pvz. aukščiau mes turime 1,2,3 tai grąžins 2.
            Console.WriteLine("Minutes:" + timespan.TotalMinutes); // šiuo atvėju grąžins 1val. 2min. 3s. į visą laiką minutėmis. 

            //Add (TimeSpan yra Imutrable, tačiau yra keli metodai, kurie gali vsiką pakeisti)
            Console.WriteLine("Add example " + timespan.Add(TimeSpan.FromMinutes(8))); // mes prie pvz 14 eilutėje pridėjome 8 minutes. 
            Console.WriteLine("Subtract example " + timespan.Subtract(TimeSpan.FromMinutes(2))); // mes prie pvz 14 eilutėje atėmeme 2 minutes. 

            // ToString (Conversion to and from string). 

            Console.WriteLine("ToString " + timespan.ToString());// ToString yra Greidout ? Pagal numatytą metodą Console.WriteLine pakviečia
                                                                  // šį metodą ant bet kokio objekto, kurį nori perduoti, todėl aš neturi explicilty 
                                                                  // (explicitly time conversion), bet jei aš nenaudoju CW, todėl man reikia konvertuoti
                                                                  //TimeSpan ToString reikšmę, todėl aš iškviečiu ToString.

            // Parse (Mes naudojame parse metodą)
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // Šis metodas automatiškai convertuoja į TimeSpan objektą. 






            Console.ReadKey();
        }

    }
}
