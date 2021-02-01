using System;
using System.IO;

namespace Assignment_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\jason\Documents\Assignment_25\Assignment_25.txt", text);
            using (StreamReader file = File.OpenText(@"C:\Users\jason\Documents\Assignment_25\Assignment_25.txt"))
            {
                string number = "";

                while ((number = file.ReadLine()) != null)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}