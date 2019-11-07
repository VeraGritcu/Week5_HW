using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Discipline
    {
        public Discipline(string name, int nolectures, int noexercises)
        {
            this.Name = name;
            this.NoOfLectures = nolectures;
            this.NoOfExercises = noexercises;
        }
        internal string Comments { get; set; }
        internal string Name { get; set; }
        internal int NoOfLectures { get; set; }
        internal int NoOfExercises { get; set; }

    }
}
