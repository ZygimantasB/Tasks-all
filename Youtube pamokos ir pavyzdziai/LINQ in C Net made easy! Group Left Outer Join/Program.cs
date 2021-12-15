using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_in_C_Net_made_easy__Group_Left_Outer_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudent();
            var classes = Standart.GetClases();

            var data = from s in students //QUERRY base sintax
                       join c in classes
                       on s.Standart equals c.Id into groupedClasses
                       from gc in groupedClasses.DefaultIfEmpty()
                       select new
                       {
                           StudentName = s.Name,
                           Teacher = gc == null ? "No Teacher" : gc.ClassTeacher
                       };

            foreach (var item in data)
            {
                Console.WriteLine($"{item.StudentName} - {item.Teacher}");
            }
            Console.ReadLine();
        }
    }
}
