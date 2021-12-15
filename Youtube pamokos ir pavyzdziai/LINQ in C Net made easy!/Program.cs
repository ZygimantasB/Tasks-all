using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_in_C_Net_made_easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=vAGnEdabFpM&t=431s

            var students = Student.GetStudent();
            var classes = Standart.GetClases();

            var data = from s in students
                       join c in classes
                       on s.Standart equals c.Id
                       select new
                       {
                           StudentName = s.Name,
                           Teacher = c.ClassTeacher

                       };

            //var data = students.Join(classes, s => s.Standart, c => c.Id, (st,cl) => new
            //{
            //    StudentName = st.Name,
            //    Teacher = cl.ClassTeacher

            //});

            //foreach (var item in data)
            //{
            //    Console.WriteLine($"{item.StudentName} - {item.Teacher}");
            //}
            Console.ReadLine();
        }
    }
}
