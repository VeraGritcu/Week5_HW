using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Vera", "Gritcu", 10);
            var s2 = new Student("Ana", "Blaj", 9);
            var s3 = new Student("Ion", "Vasile", 8);
            var s4 = new Student("George", "Mincu", 7);
            var s5 = new Student("Victor", "Blaj", 6);
            var s6 = new Student("Speranta", "Vlad", 5); 
            var s7 = new Student("Victoria", "Marcu", 7);
            var s8 = new Student("Alina", "Nistor", 9);
            var s9 = new Student("Vasile", "Voicu", 8);
            var s10 = new Student("Cristian", "Carausu", 10);

            var sortedStudentList = Student.studentList.OrderBy(p => p.Grade).ToList();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Adam", "Blunt", 450, 8));
            workers.Add(new Worker("Bruno", "Willis", 350, 8));
            workers.Add(new Worker("Charles", "Flint", 420, 5));
            workers.Add(new Worker("Dennis", "Pal", 460, 6));
            workers.Add(new Worker("Karl", "Fox", 380, 7));
            workers.Add(new Worker("Bill", "Ox", 395, 7));
            workers.Add(new Worker("Oliver", "Trende", 250, 5));
            workers.Add(new Worker("Michael", "Wilchelm", 150, 3));
            workers.Add(new Worker("Anny", "Wohl", 180, 5 ));
            workers.Add(new Worker("Robert", "West", 290, 8));

            var sortedWorkersList = workers.OrderByDescending(p => p.MoneyPerHour());

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(sortedWorkersList);
            mergedList.AddRange(sortedStudentList);

            var sortedHumans = mergedList.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);
            foreach (var item in sortedHumans)
            {
                Console.WriteLine($"{item.FirstName} { item.LastName}");
            }


        }
    }

}
