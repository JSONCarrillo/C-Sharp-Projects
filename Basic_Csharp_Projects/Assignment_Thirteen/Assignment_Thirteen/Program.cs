using System;

namespace Assignment_Thirteen
{
    class Program
    {
        static int Math(int x)
        {
            return x * 12;
        }
        static int Math( double x)
        {
            int answer = Convert.ToInt32(x + 12);
            return answer;
        }
        static int Math(string x)
        {
            int y = Convert.ToInt32(x);
            return y / 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Math(12));
            Console.WriteLine(Math(13.5));
            Console.WriteLine(Math("12"));
        }
    }
}
