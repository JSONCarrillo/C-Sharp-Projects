using System;

namespace Assignment_Twelve
{
    class Program
    {
        static int methodOne(int args)
        {
            return 75 % args;
        }

        static int methodTwo(int args)
        {
            return 66 * args;
        }
        static void Main()
        {
            Console.WriteLine("Input a number to use for the methods");
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(methodOne(userNum));
                Console.WriteLine(methodTwo(userNum));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
