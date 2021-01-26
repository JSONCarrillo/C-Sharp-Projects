using System;

namespace Assignment_Sixteen
{

    public static class methodClass
    {
        public static int MethodTwo(int x, out int y)
        {
            y = 12 + 32;
            int maths = x + 12;
            return maths;
        }

        public static void MethodTwo(int x, int y = 12)
        {
            Console.WriteLine(x + 24);

        }
        public static void Method(int x)
        {
            Console.WriteLine(x / 2);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            methodClass.Method(2);
            Console.WriteLine("Input an integer");
            int userInt = Convert.ToInt32(Console.ReadLine());
            methodClass.Method(userInt);
            int z = methodClass.MethodTwo(userInt, out int y);
            methodClass.MethodTwo(12);
            Console.WriteLine($"{y}");

        }

    }
}
