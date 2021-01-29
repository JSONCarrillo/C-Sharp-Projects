using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Dawson", LastName = "Leery", Id = 1 });
            employees.Add(new Employee { FirstName = "Jen", LastName = "Taylor", Id = 2 });
            employees.Add(new Employee { FirstName = "Andy", LastName = "Smith", Id = 3 });
            employees.Add(new Employee { FirstName = "John", LastName = "JacobJingleHeimerSchmitt", Id = 4 });
            employees.Add(new Employee { FirstName = "Harley", LastName = "Davidson", Id = 5 });
            employees.Add(new Employee { FirstName = "David", LastName = "DavidFace", Id = 6 });
            employees.Add(new Employee { FirstName = "John", LastName = "Dangerously", Id = 7 });
            employees.Add(new Employee { FirstName = "Jason", LastName = "Voorhees", Id = 8 });
            employees.Add(new Employee { FirstName = "Molly", LastName = "Mack", Id = 9 });
            employees.Add(new Employee { FirstName = "Jane", LastName = "Doe", Id = 10 });

            List<Employee> Templist = new List<Employee>();
            foreach (var employee in employees)
            {

                if (employee.FirstName == "John")
                {
                    Templist.Add(employee);
                }
            }

            foreach (Employee employee in Templist)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> John = employees.Where(x => x.FirstName == "John").ToList();

            foreach (Employee employee in John)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> GreatThanFive = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in GreatThanFive)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
            Console.ReadLine();
        }
    }
}
