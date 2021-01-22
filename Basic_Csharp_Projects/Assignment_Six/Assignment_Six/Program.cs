using System;

class PackageApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter package weight.");
        int PackageWeight = Convert.ToInt32(Console.ReadLine());
        if(PackageWeight > 50)
        {
            Console.WriteLine("Error: Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            Console.WriteLine("Please enter package width.");
            int PackageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height.");
            int PackageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length.");
            int PackageLength = Convert.ToInt32(Console.ReadLine());

            if((PackageHeight + PackageWidth + PackageLength > 50)){
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                int PackageQuote = (PackageHeight * PackageLength * PackageWidth) / 100;
                Console.WriteLine("Your estimated total for shipping this package is $" + PackageQuote + ".00");
                Console.WriteLine("Thank You!");
            }
        }

    }
}