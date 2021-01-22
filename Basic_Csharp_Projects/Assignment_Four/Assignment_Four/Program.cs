using System;

class IncomeComparison
{
    static void Main()
    {
        Console.WriteLine("Income Comparison Program");
        Console.WriteLine("Person One, what is your name?");
        string PersonOne = Console.ReadLine();
        Console.WriteLine("Person Two, what is your name?");
        string PersonTwo = Console.ReadLine();
        Console.WriteLine(PersonOne + ", how many hours do you work in a week?");
        int PersonOneHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PersonTwo + ", how many hours do you work in a week?");
        int PersonTwoHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PersonOne + ", how much do you make hourly?");
        double PersonOneWage = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(PersonTwo + ", how much do you make hourly?");
        double PersonTwoWage = Convert.ToDouble(Console.ReadLine());

        double PersonOnePay = (PersonOneHours * 52) * PersonOneWage;
        double PersonTwoPay = (PersonTwoHours * 52) * PersonTwoWage;

        Console.WriteLine(PersonOne + ", you make $" + PersonOnePay);
        Console.WriteLine(PersonTwo + ", you make $" + PersonTwoPay);
        Console.WriteLine("Does " + PersonOne + " make more than " + PersonTwo + "?");
        Console.WriteLine(PersonOnePay > PersonTwoPay);
    }
}