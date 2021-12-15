using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_To_Use_Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Custumer> costomerList = new List<Custumer>
            {
            new Custumer { CustomerCode = "101", CustomerName = "John" },
            new Custumer { CustomerCode = "102", CustomerName = "Peter" },
            new Custumer { CustomerCode = "103", CustomerName = "George" },
            new Custumer { CustomerCode = "104", CustomerName = "David" },
            new Custumer { CustomerCode = "105", CustomerName = "Prince" }
            };

            //var result = costomerList.Select(customer => customer.CustomerCode).ToList();
            //result.ForEach(a => Console.WriteLine(a));

            //var result1 = costomerList.Select(customerN => customerN.CustomerName).ToList();
            //result1.ForEach(a => Console.WriteLine(a));

            var result = costomerList.Find(a => a.CustomerCode.Substring(0, 1) == "1"); // Find naudojamas tyik su vienu objektu

            //var result = costomerList.Where(a => a.CustomerCode.Substring(0,1) == "1").ToList();

                
            Console.ReadLine();

        }
    }
}
