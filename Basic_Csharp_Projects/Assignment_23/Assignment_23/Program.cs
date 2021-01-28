using System;

namespace Assignment_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            n.Amount = 10.003M;
            Console.WriteLine(n.Amount);
            Console.ReadLine();
        }
    }
}
