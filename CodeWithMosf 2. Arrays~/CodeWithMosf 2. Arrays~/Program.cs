using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithMosf_2.Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 5, 7, 9, 2, 14, 6 };

            //lenght 
            Console.WriteLine("Lenght: " + numbers.Length); //mes šiame pvz. prieinamie prie lenght ypatybių objekto
            // indexof() rasti poziciją mūsų elementų
            int index = Array.IndexOf(numbers, 9); //rezultatas bus laikomas reikšmėje index. 
            Console.WriteLine("Index of 9: " + index); //Jei metodas yra prieinamas iš pačios klasės, tai reiškia, kad t.y statinis metodas.
            //Clear
            Array.Clear(numbers, 0, 2); // išvaloma nuo 0 iki 2 indekso
            Console.WriteLine("Effect of the Clear()");
            foreach(int n in numbers)
            Console.WriteLine(n); //Naudojant Clear() array jų reikšmės yra prisikiamos prie 0. 

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3); //Nukopijuojama iš numbers į another iki 3 indekso
            Console.WriteLine("Effect of the copy");
            foreach(int n in another)
            Console.WriteLine(n); // galime pastebėti, kad pirmi tyris elementai, buvo nukopijuoti į kirą Array

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort");
            foreach(int n in numbers)
            Console.WriteLine(n);
            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach(int n in numbers)
                Console.WriteLine(n);


            Console.ReadKey();
        }
    }
}
