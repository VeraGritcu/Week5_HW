using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Student : Human
    {
        internal static List<Student> studentList = new List<Student>();
        public Student(string fn, string ln, int g) : base (fn,ln)
        {
            this.Grade = g;
            studentList.Add(this);
        }
        public string AllDetails
        {
            get
            {
                return $"{FirstName} {LastName}, {Grade}";
            }
        }

        internal int Grade { get; set; }
        internal void Print()
        {
            Console.WriteLine(AllDetails);
        }

    }
}
