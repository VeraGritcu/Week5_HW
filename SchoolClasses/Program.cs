using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var classA = new Class("A");
            School mySchool = new School(classA);
            classA.AddStudent(new Student(classA, "Ioan Vasile"));
            var class2 = new Class("A");
            mySchool.AddClass(classA);
            mySchool.AddClass(class2);
            var teacher1 = new Teacher("Andrei S");
            classA.AddTeacher(teacher1);
            var dis1 = new Discipline("Math", 25, 40);
            teacher1.TeachedDisciplines.Add(dis1);
            
            classA.Comments = "test";
            
        }
    }
}
