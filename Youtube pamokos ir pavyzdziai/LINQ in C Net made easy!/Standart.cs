using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_in_C_Net_made_easy_
{
    class Standart
    {
        public int Id { get; set; }
        public string ClassTeacher { get; set; }
        public double Fees { get; set; }

        public static List<Standart> GetClases()
        {
            return new List<Standart>
            {
                new Standart{Id = 10, ClassTeacher = "Max", Fees = 1000.00},
                new Standart{Id = 8, ClassTeacher = "Ajay", Fees = 800.00},
                new Standart{Id = 6, ClassTeacher = "Geeta", Fees = 600.00},
                new Standart{Id = 4, ClassTeacher = "Rohan", Fees = 400.00},
            };
        }
    }
}
