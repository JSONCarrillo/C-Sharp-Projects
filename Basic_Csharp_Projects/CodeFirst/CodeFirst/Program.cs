using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentsContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Student: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from s in db.Students
                            orderby s.Name
                            select s;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        //public virtual List<Post> Posts { get; set; }
    }


    public class StudentsContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
