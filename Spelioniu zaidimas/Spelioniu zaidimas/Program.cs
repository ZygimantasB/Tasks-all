using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelioniu_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kortu_rusys = new List<string>();

            kortu_rusys.Add("Širdys");
            kortu_rusys.Add("Bugnai");
            kortu_rusys.Add("Vynai");
            kortu_rusys.Add("Kryziai");

            Console.WriteLine(kortu_rusys);
        }
    }
}
