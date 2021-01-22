using System;

class MathApp
{
    static void Main()
    {
        //First Equation
        Console.WriteLine("Write your first number");
        int Num_One = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("50 multiplied by " + Num_One + " Equals " + (Num_One * 50));
        //Second
        Console.WriteLine("Write your second number");
        int Num_Two = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("25 + " + Num_Two + " Equals " + (Num_Two + 25));
        //Third
        Console.WriteLine("Write your third number");
        int Num_Three = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Num_Three + " divided by 12.5 equals " + (Num_Three / 12.5));
        //Fourth
        Console.WriteLine("Write your fourth number");
        int Num_Four = Convert.ToInt32(Console.ReadLine());
        if (Num_Four > 50){
            Console.WriteLine(Num_Four + " is greater than 50");
        }
        else
        {
            Console.WriteLine(Num_Four + " is not greater than 50");
        }
        //Fifth
        Console.WriteLine("Write your fifth number");
        int Num_Five = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Num_Five + " divided by 7 has a remainder of " + (Num_Five % 7));
    }
}