using System;

namespace Assignment_Twenty
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int id;
        public abstract void SayName();
    }

    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
        public static bool operator ==(Employee id1, Employee id2)
        {
            return id2 == id1;
        }
        public static bool operator !=(Employee id1, Employee id2)
        {
            return !(id1 == id2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee
            {
                id = 1,
                FirstName = "Sample",
                LastName = "Student"
            };
            Employee sample2 = new Employee
            {
                id = 2,
                FirstName = "Sample",
                LastName = "Twodent"
            };

            sample.SayName();

            Console.WriteLine(sample.id == sample2.id);
        }


    }
}