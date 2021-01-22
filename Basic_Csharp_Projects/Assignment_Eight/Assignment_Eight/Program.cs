using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringOne = "John is a man of focus, ";
            string StringTwo = "commitment, ";
            string StringThree = "sheer will.";
            Console.WriteLine(StringOne + StringTwo + StringThree);

            string StringFour = "aaaaaaaa";
            Console.WriteLine(StringFour.ToUpper());

            StringBuilder sb = new StringBuilder();

            bool EndSb = false;
            while (!EndSb)
            {
                Console.WriteLine("Write the next line. (Type 'DONE' to end)");
                string line = Console.ReadLine();
                sb.Append(line + "\n");
                if (line == "DONE")
                {
                    Console.WriteLine("Goodbye!");
                    EndSb = true;
                }
                else
                {
                    Console.WriteLine(sb);
                }
            }
        }
    }
}
