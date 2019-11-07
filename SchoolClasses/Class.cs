using System.Collections.Generic;

namespace SchoolClasses
{
    public class Class
    {
        public Class(string identifier)
        {
            classNumber = ++currentNumber;
            this.Identifier = identifier;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
        private static int currentNumber = 0;
        private int classNumber;

        internal string Identifier { get; set; }

        internal string Comments { get; set; }
        private List<Teacher> Teachers { get; set; }

        private List<Student> Students { get; set; }
        internal int ClassNumber { get { return this.classNumber; } }

        internal void AddStudent(Student s)
        {
            bool isValid = true;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i] == s )
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid == true)
            {
                Students.Add(s);
            }
            else
            {
                System.Console.WriteLine("This student is already in this class");
            }
            
        }

        internal void AddTeacher(Teacher t)
        {
            bool isValid = true;
            for (int i = 0; i < Teachers.Count; i++)
            {
                if (Teachers[i] == t)
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid == true)
            {
                Teachers.Add(t);
            }
            else
            {
                System.Console.WriteLine("This teacher is already in the list");
            }
            
        }
    }
}