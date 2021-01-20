using System;

class MathApp
{
    static void Main()
    {
        Console.WriteLine("Write your first number");
        int Num_One = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("50 multiplied by " + Num_One + "Equals " + Num_One * 50);
    }
}