using System;
using System.Collections.Generic;

namespace Assignment_Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Lamborghini", "Maserati", "Ferrari", "Rolls-Royce" };
            int[] modelYears = { 1988, 1995, 1999, 2005, 2010, 2015, 2018 };
            List<string> shippingMethods = new List<string>();
            shippingMethods.Add("Same-day");
            shippingMethods.Add("Priority");
            shippingMethods.Add("First Class");
            shippingMethods.Add("Pickup");

            Console.WriteLine("Choose the index of your car model.");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(i + " " + cars[i]);
            }
            int carChoice = Convert.ToInt32(Console.ReadLine());
            if (carChoice >= cars.Length)
            {
                Console.WriteLine("This is not an option");
            }
            else
            {
                Console.WriteLine("Choose the index of the year of the car you want.");
                for (int i = 0; i < modelYears.Length; i++)
                {
                    Console.WriteLine(i + " " + modelYears[i]);
                }
                int yearChoice = Convert.ToInt32(Console.ReadLine());
                if (yearChoice >= modelYears.Length)
                {
                    Console.WriteLine("This is not an option");
                }
                else
                {
                    Console.WriteLine("You chose a " + modelYears[yearChoice] + " " + cars[carChoice] + ". Please choose a shipping option");
                    Console.WriteLine("Choose the index of the year of the car you want.");
                    for (int i = 0; i < shippingMethods.Count; i++)
                    {
                        Console.WriteLine(i + " " + shippingMethods[i]);
                    }
                    int shippingChoice = Convert.ToInt32(Console.ReadLine());
                    if(shippingChoice >= shippingMethods.Count)
                    {
                        Console.WriteLine("That is not an option.");
                    }
                    else
                    {
                        Console.WriteLine("Okay, we will be shipping your " + modelYears[yearChoice] + " " + cars[carChoice] + " via " + shippingMethods[shippingChoice] + ". Have a great day!");
                    }
                }
                
            }

        }
    }
}
