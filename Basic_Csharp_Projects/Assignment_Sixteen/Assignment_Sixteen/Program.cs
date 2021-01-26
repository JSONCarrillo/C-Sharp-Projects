using System;

namespace Assignment_Sixteen
{
    public static class Program
    {

        static void Main(string[] args)
        {
            Method(2);
            Console.WriteLine("Input an integer");
            int userInt = Convert.ToInt32(Console.ReadLine());
            Method(userInt);
            int z = MethodTwo(userInt, out int y);
            MethodTwo(12);
            Console.WriteLine($"{y}");

        }
        static int MethodTwo(int x, out int y)
        {
            y = 12 + 32;
            int maths = x + 12;
            return maths;
        }

        static void MethodTwo(int x, int y = 12)
        {
            Console.WriteLine(x + 24);

        }
        static void Method(int x)
        {
            Console.WriteLine(x / 2);
        }
    }
}
