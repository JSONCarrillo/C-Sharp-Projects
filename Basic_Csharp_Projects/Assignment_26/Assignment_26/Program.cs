using System;

namespace Assignment_26
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            Console.WriteLine("Please enter a number.");
            var hours = Convert.ToInt32(Console.ReadLine());

            DateTime timeInHours = currentTime.AddHours(hours);
            Console.WriteLine(timeInHours);
            Console.ReadLine();

        }
    }
}