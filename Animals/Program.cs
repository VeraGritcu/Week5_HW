using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> myAnimals = new List<Animal>();

            myAnimals.Add(new Kitten("Susy", 1));
            myAnimals.Add(new Tomcat("Tom", 3));
            myAnimals.Add(new Cat("Fiffy", 7, Gender.Female));
            myAnimals.Add(new Dog("Barky", 5, Gender.Male));
            myAnimals.Add(new Frog("Amadeus", 2, Gender.Male));
            myAnimals.Add(new Frog("BarryWhite", 5, Gender.Male));
            myAnimals.Add(new Cat("Pinky", 1, Gender.Female));
            myAnimals.Add(new Dog("Patrocle", 9, Gender.Male));
            myAnimals.Add(new Kitten("Sparkly", 1));
            myAnimals.Add(new Tomcat("Charly", 7));
            myAnimals.Add(new Frog("Woody", 2, Gender.Male));

            var catsAverageAge = ComputeAverageFor(myAnimals, typeof(Cat));
            var dogsAverageAge = ComputeAverageFor(myAnimals, typeof(Dog));
            var frogsAverageAge = ComputeAverageFor(myAnimals, typeof(Frog));
            var kittensAverageAge = ComputeAverageFor(myAnimals, typeof(Kitten));
            var TomcatsAverageAge = ComputeAverageFor(myAnimals, typeof(Tomcat));

        }

        private static double ComputeAverageFor(List<Animal> myAnimals, Type type)
        {
            var animalGroup = myAnimals.Where(p => p.GetType() == type).ToArray();

            return animalGroup.Average(p => p.Age);

        }

    }
}
