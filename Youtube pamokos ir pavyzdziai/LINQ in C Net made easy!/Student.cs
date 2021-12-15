using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_in_C_Net_made_easy_
{
    class Student
    {
        public int RollNo { get; set;  }
        public string Name { get; set; }
        public int Standart { get; set; }
        public Gendre Gender { get; set; }

        public static List<Student> GetStudent()
        {
            return new List<Student>
            {
                new Student {RollNo = 101, Name = "Thomas", Gender = Gendre.Male, Standart = 10},
                new Student {RollNo = 102, Name = "Chris", Gender = Gendre.Male, Standart = 8},
                new Student {RollNo = 103, Name = "Luise", Gender = Gendre.Female, Standart = 10},
                new Student {RollNo = 104, Name = "Ram", Gender = Gendre.Male, Standart = 8},
                new Student {RollNo = 105, Name = "Kate", Gender = Gendre.Female, Standart = 6},
                new Student {RollNo = 106, Name = "John", Gender = Gendre.Male, Standart = 6},
                new Student {RollNo = 107, Name = "Emma", Gender = Gendre.Female, Standart = 6},
                new Student {RollNo = 108, Name = "Ravi", Gender = Gendre.Male, Standart = 6},
            };
        }
    }
    public enum Gendre
    {
        Male,
        Female
    }
}
