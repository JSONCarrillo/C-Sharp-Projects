using System;

namespace Assignment_Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Lamborghini", "Maserati", "Tesla", "Rolls-Royce" };
            int[] modelYears = { 1988, 1995, 1999, 2005, 2010, 2015, 2018 };
            Console.WriteLine("Choose the index of your car model.");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(i + " " + cars[i]);
            }
            int carChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the index of the year of the car you want.");
            for (int i = 0; i < modelYears.Length; i++)
            {
                Console.WriteLine(i + " " + modelYears[i]);
            }
            int yearChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose a " + modelYears[yearChoice] + " " + cars[carChoice] + ". Enjoy your new car!" );
        }
    }
}
