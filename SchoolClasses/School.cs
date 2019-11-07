using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class School
    {
        internal School(Class cl)
        {
            Classes = new List<Class>();
           
        }
        private List<Class> Classes { get; set; }

        internal void AddClass(Class cl)
        {
            bool isPresent = true;
            for (int i = 0; i < Classes.Count; i++)
            {
                if (Classes[i].Identifier == cl.Identifier)
                {
                    Console.WriteLine("Rejection: You try to add a class which doesn't have a unique identifier");
                    isPresent = false;
                    break;
                }

            }
            if (isPresent == true)
            {
                Classes.Add(cl);
            }
        }
    }
}
