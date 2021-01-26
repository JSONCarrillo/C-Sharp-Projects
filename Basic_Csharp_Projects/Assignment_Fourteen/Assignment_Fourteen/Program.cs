using System;

namespace Assignment_Fourteen
{
    class Program
    {
        static int Math(int x, int y = 1)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Math(2));
            Console.WriteLine("Choose your first integer");
            int intOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your second integer (optional, hit enter to continue)");
            
            try
            {
                int intTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math(intOne, intTwo));
            }
            catch(Exception)
            {
                Console.WriteLine(Math(intOne));
            }
        }
    }
}
