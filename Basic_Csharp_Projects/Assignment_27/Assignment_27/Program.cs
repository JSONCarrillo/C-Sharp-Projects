using System;

namespace Assignment_27
{
    class Program
    {
        static void Main(string[] args)
        {
            const int currentYear = 2021;
            Console.WriteLine("The current year is {0}", currentYear);

            var previousYear = new Time("previous Year", 2020);
            if(previousYear.Year == 2020)
            {
                Console.WriteLine($"The previous year is {previousYear.Year}, so glad that's over!");
            }
            else
            {
                Console.WriteLine($"The previous year is {previousYear.Year}");
            }
                
            Console.ReadLine();
        }
    }
}
