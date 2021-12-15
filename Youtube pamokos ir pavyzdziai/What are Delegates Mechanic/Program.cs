using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_are_Delegates_Mechanic
{
    public class Engine
    {

    }
    public class ScarpYardMananger
    {
        public Engine Search (string brand_model)
        {
            return new Engine();
        }
    }
    public delegate Engine SearchDelegate(string condition);
    public class Mechanic
    {
        public SearchDelegate SearchDel { get; set; }
        public void ReplaceEngine(string brand_model)
        {
            // 1. Get the engine
            var eng = SearchDel(brand_model);

            // 2. Replace the engine

            // 3. Done
            Console.WriteLine("I am dune replaciang the engine");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mechanic mech = new Mechanic();

            mech.ReplaceEngine("brand and model");

            mech.SearchDel = (new ScarpYardMananger()).Search;
            mech.ReplaceEngine("brand and model");

            Console.ReadKey();
        }
    }
}
