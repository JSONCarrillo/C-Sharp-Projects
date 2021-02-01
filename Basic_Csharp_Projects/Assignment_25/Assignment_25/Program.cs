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
            File.WriteAllText(@"C:\Users\jason\Desktop\\Logs\log.txt", text);
            using (StreamReader file = File.OpenText(@"C:\Users\jason\Desktop\Folder1\Logs\log.txt"))
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