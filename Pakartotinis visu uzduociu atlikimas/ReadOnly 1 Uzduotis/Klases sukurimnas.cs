using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_1_Uzduotis
{
    class Klases_sukurimnas
    {
        //public const int Skaicius { get; }
        public int Skaicius = 9;
        public readonly string Zodelis;
        public List<int> NaujasList = new List<int> { 1,2,3,4,5 };
        public string Sakinys = "Gera diena";
        //public const List<string> StringList;



        public int Skaiciukas = 15;

    public Klases_sukurimnas (int skaicius, string zodelis, List<int> naujasList, string sakinys)
        {
            Zodelis = zodelis;
            NaujasList = naujasList;
            //Sakinys = "Laba ryta";

            Skaiciukas = 22;
        }

        public void Visko_atspausdinimas ()
        {
            Console.WriteLine($"{Skaicius} {Zodelis} {NaujasList} {Sakinys} {Skaiciukas}");
        }
    }
}
