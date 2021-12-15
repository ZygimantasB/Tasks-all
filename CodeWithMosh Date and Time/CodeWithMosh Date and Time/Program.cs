using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithMosh_Date_and_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var DateTime = new DateTime(2014, 1, 1);
            var now = DateTime.Now;
            var roday = DateTime.Today;

            //Console.WriteLine("Hour :" + now.Hour);
            //Console.WriteLine("Hour :" + now.Minute);

            var tomorrow = now.AddDays(1); // grąžins laiką atgąl t.y. vakar
            var yesterday = now.AddDays(-1); // grąžinti laiką atgal t.y. grįžti į praeitį. 

            Console.WriteLine(now.ToLongDateString()); // 2021 m. spalio 2 d., sestadienis
            Console.WriteLine(now.ToShortDateString()); // 2021-10-02
            Console.WriteLine(now.ToLongTimeString()); // 20:36:00
            Console.WriteLine(now.ToShortTimeString()); // 20:36
            Console.WriteLine(now.ToString()); // 2021-10-02 20:36:00 // atvaizduoti datą ir laiką. 
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // 2021-10-02 20:39

            Console.ReadKey();
        }
    }
}
