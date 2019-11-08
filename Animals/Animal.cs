using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animals
{
    public abstract class Animal : ISound
    {
       public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
       public string Name { get; set; }
       public int Age { get; set; }
       public Gender Sex { get; set; }

       public abstract void MakeNoise();
        
    }
    public enum Gender
    {
        Female,
        Male
    }
}
