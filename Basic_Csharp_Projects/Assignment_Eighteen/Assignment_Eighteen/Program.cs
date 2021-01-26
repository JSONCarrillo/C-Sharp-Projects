using System;

namespace Assignment_Eighteen
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public abstract void SayName();
    }

    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            sample.SayName();
        }
    }
}
