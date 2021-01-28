using System;

namespace Assignment_22
{

    class Program
    {
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string userInput = Console.ReadLine();

            DaysOfWeek Day;

            try
            {
                Day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput);
                Console.WriteLine("Today is " + Day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

    }
}