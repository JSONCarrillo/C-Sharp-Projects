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

        //Overload operators
        public static bool operator ==(Employee obj1, Employee obj2)
        {
            return obj1.id == obj2.id;
        }
        public static bool operator !=(Employee obj1, Employee obj2)
        {
            return !(obj1.id == obj2.id);
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
            
        }


    }
}