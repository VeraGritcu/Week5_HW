using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender sex): base(name, age, sex) { }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }
}
