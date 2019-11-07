using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal abstract class Human
    {
        public Human(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
    }
}
