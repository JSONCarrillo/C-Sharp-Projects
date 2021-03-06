﻿using System;

namespace Assignment_Nineteen
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public abstract void SayName();
    }

    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void IQuit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit");
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

            IQuittable quit = new Employee { 
                FirstName = "James",
                LastName = "Cameron"
            };

            quit.IQuit();

            sample.SayName();
        }
    }
}