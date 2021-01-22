using System;


class LicenseApproval
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int UserAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("have you had any DUIs? true/false");
        bool UserDui = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets due you have?");
        int UserTickets = Convert.ToInt32(Console.ReadLine());

        bool isValid = (UserAge > 15 && UserDui == false && UserTickets < 3);
        Console.WriteLine("Qualified?");
        Console.WriteLine(isValid);
    }
}
