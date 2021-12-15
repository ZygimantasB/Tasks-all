using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_in_C_Net_made_easy__Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudent();
            var classes = Standart.GetClases();

            var data = from c in classes
                       join s in students on c.Id equals s.Standart
                       into groupStudents
                       select new
                       {
                           Class = c.Id,
                           Teacher = c.ClassTeacher,
                           Students = groupStudents
                       };

            foreach (var item in data)
            {
                Console.WriteLine($"--- {item.Teacher}");
                foreach (var std in item.Students)
                {
                    Console.WriteLine($"    {std.Name}");
                }
            }

            //var data = classes.GroupJoin(students, c => c.Id, s => s.Standart, (cl, groupedStudents) => new
            //{
            //    Class = cl.Id,
            //    Teacher = cl.ClassTeacher,
            //    Students = groupedStudents
            //});

            //foreach (var item in data)
            //{
            //    Console.WriteLine($"--- {item.Teacher}");
            //    foreach (var std in item.Students)
            //    {
            //        Console.WriteLine($"    {std.Name}");
            //    }
            //}

            Console.ReadLine();
        }
    }
}
