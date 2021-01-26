using System;

namespace Assignment_Fifteen
{
    class Program
    {
        static void Method(int x, int y)
        {
            int math = x + 12;
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            Method(1, 13);
            Method( x: 1, y: 3);
        }
    }
}
