using System;
using System.Collections.Generic;

namespace Assignment_21
{
    class Program
    {
        public class Employee<T>
        {
            public List<T> things { get; set; }


        }

        static void Main(string[] args)
        {
            Employee<string> names = new Employee<string>();
            names.things = new List<string>() { "james", "Jimmy", "Jim", "Alf" };
            Employee<int> id = new Employee<int>();
            id.things = new List<int>() { 1, 2, 3, 4 };

            foreach (string thing in names.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in id.things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}