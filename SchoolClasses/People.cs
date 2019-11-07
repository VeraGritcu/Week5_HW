using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class People
    {
        internal string Name { get; set; }

        internal string Comments { get; set; }

        public People(string name)
        {
            this.Name = name;
        }
    }
}
