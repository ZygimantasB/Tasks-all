using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithMosh_3_Strings_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Zygimantas Brinkis ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'"); // Nelieka tuščios vietos pradžioje arba gale. 
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'"); // Strings yra imutable

            // Žemiau bus pateikta kaip mes galima varda ir pvarde atskirti į atskirus
            var index = fullName.IndexOf(' '); // Šiame parašyme mes panduojame skirtuką t.y. blank space. Čia galime nurodyti string arba character.
            var firstName = fullName.Substring(0, index); // Mes norime atskirti string.  reikšia, kad tai bus pirma reikšmė
            var lastName = fullName.Substring(index + 1); // substring metoda geriau naudoti, kai mes turime sudetingesni parašymą.
            Console.WriteLine("Firstname: " + firstName );
            Console.WriteLine("Lastname: " + lastName );

            Console.WriteLine("-------------------------------");
            // yra lengvesnis budas atskirti varda ir vardę

            var names = fullName.Split(' ');
            Console.WriteLine("Firastname: " + names[0]);
            Console.WriteLine("Lastname: " + names[1]);

            Console.WriteLine("-------------------------------");
            // Naudojamas REPLACE metodas

            Console.WriteLine(fullName.Replace("Zygimantas", "Marius"));
            fullName.Replace('o', 'O'); // sukeisti vietomis mažają o su didžiąja O.
            /*fullName.Replace(' ', '');*/ // Sukesiti tuščia vietą. Atliekant šiuos veikmus pradinis string yra nepakeičiamas. 
            
            Console.WriteLine("-------------------------------");
            // Naudingi metodai dirbti emty string ir 0 (null)
            // Tikruose gyvenimo aplikacijose tu nori žinoti ar vartotojas įvedė reikšmę ar ne. 
            // Įsivaizduokime tu statai forumą ir vartotojas turėtų įvesti kreditinės kortelės numerį.
            // Tu nori žinoti ar vartotojas įvedė kreditinės kortelės numerį

            if (string.IsNullOrEmpty(" ".Trim())) // ("") (null). Parašius (" ") mes nematome klaidingos žinutės. Mes šią probnlemą galime išspręsti su Trim metodu
                                                  // ir vėliau perduoti ar tai yra null ar emptyu aplikacija. Yra naujas metodas t.y. IsNullOwWhiteSpace
                /*if (string.IsNullOrWhiteSpace(" "))*/ // Jei string bus null, emty arba whitespace mes gausime invalid. 
   
                   Console.WriteLine("Invalid");
            Console.WriteLine("-------------------------------");
            // Kaip konvertuoti skaičius į string. 

            var str = "25"; // Konvertuoti galima dviem būdais. Pirmas būdas yra naudoti Convert
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); // Kiekvienas metodas turi ToString (jis galimas visur). 
            


            Console.ReadLine();
        }
    }
}
