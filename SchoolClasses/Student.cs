namespace SchoolClasses
{
    internal class Student : People
    {
        public Student(Class cl, string name): base(name)
        {
            this.ClassNumber = cl.ClassNumber;
        }
        internal int ClassNumber { get; }
    }
}