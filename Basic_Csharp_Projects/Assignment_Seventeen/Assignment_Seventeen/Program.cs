using System;

namespace Assignment_Seventeen
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    public class Employee : Person
    {
        public int id;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee newPerson = new Employee();

            newPerson.FirstName = "Sample";
            newPerson.LastName = "Student";

            newPerson.SayName();

        }
    }
}
