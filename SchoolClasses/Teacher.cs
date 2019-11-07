using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Teacher : People
    {   
        internal Teacher(string name):base (name)
        {
            TeachedDisciplines = new List<Discipline>();
        }
        internal List<Discipline> TeachedDisciplines { get; set; }
       
    }
}
