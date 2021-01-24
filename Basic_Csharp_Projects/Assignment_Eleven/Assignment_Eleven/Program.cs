using System;
using System.Collections.Generic;

namespace Assignment_Eleven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 99, 67, 57, 88, 97, 12, 32 };

            Console.WriteLine("What number would you like to use to divide the array?");
            
            try
            {
                int userDiv = Convert.ToInt32(Console.ReadLine());
                foreach (int i in numbers)
                {
                    Console.WriteLine(i / userDiv);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("Code will now continue as normal");


        }
    }
}
