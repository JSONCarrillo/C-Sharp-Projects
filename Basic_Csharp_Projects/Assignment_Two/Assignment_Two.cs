using System;

class DailyReport
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What is your name?");
        string Name = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string Course = Console.ReadLine();
        Console.WriteLine("What page number are you on?");
        int Page_Num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? (true/false)");
        bool Need_help = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string Experiences = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string Feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        int Study_Hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}