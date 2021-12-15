using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNetFw
{
    public class Skaiciuotuvas
    {
        /// Static kintamasis - klases (tipo Skaiciuotuvas) kintamasis,
        /// kuris nera suristas su konkreciu objektu
        public static int BendrasOperacijuKiekis = 0;

        /// <summary>
        /// Objekto kintamieji, kuriu reiksmes unikalios kiekvienam sukurtam objektui
        /// pvz (skaiciuotuvas1, skaiciuotuvas2 ir t.t.
        /// </summary>
        public int OperacijuKiekis;
        public string SkaiciuotuvoModelis;

        /// <summary>
        /// Objekto konstuktorius, kuris vykdomas sukuriant objekta
        /// pvz Skaiciuotuvas skaiciuotuvasApple = new Skaiciuotuvas("Apple");
        /// </summary>
        /// <param name="modelis"></param>
        public Skaiciuotuvas(string modelis)
        {
            OperacijuKiekis = 0;
            SkaiciuotuvoModelis = modelis;
        }

        // Zemiau eina public veiksmai, kuriuos gali pasiekti kitos klases. pvz, skaiciuotuvasApple.Sum(1, 2);
        public int Sum(int a, int b)
        {
            BendrasOperacijuKiekis++;
            OperacijuKiekis++;
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            BendrasOperacijuKiekis++;
            OperacijuKiekis++;
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            BendrasOperacijuKiekis++;
            OperacijuKiekis++;
            return a * b;
        }

        public double Divide(int a, int b)
        {
            BendrasOperacijuKiekis++;
            OperacijuKiekis++;
            return (double) a / b;
        }
    }
}
