using System;
using System.Collections.Generic;

namespace Assignment_Ten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 and 2
            bool Done = false;
            int iteration = 0;
            string[] stringArray = new string[0];

            //While !Done creates an infinite loop since Done is currently set to false
            while (!Done)
            {
                Console.WriteLine("Input some text. (Type DONE to move on.)");
                
                string userInput = Console.ReadLine();
                if (userInput == "DONE")
                {
                    //This line ends the loop so the user can continue with the rest of the application
                    Done = true;
                }
                else
                {
                    Array.Resize<string>(ref stringArray, stringArray.Length + 1);
                    stringArray[iteration] = userInput;
                    iteration++;
                    foreach (string i in stringArray)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            //Part 3
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            // Part 4
            
            List<string> arraySearch = new List<string>() { "Hello", "There", "General", "Kenobi" };
            bool isValue = false;
            Console.WriteLine("Search for item in the array.");
            while (Done)
            {
                string userQuery = Console.ReadLine();
                foreach(string i in arraySearch)
                {
                    if(userQuery == i)
                    {
                        Console.WriteLine(arraySearch.IndexOf(i));
                        isValue = true;
                        Done = false;
                        break;
                    }
                }
                if (!isValue)
                {
                    Console.WriteLine("Could not find value, try again.");
                };
            }

            //Part 5
            bool isFinished = false;
            bool isFound = false;

            int index = 0;
            List<string> names = new List<string>() {"Jen", "Dawson", "Joey", "Jen" };
            List<int> indices = new List<int>();

            Console.WriteLine("Search for name.");
            while (!isFinished)
            {
                string userQuery = Console.ReadLine();
                foreach(string i in names)
                {
                    if(i == "Jen" && userQuery == "Jen")
                    {
                        indices.Add(index);
                        isFound = true;
                        
                    }
                    else if(i == userQuery)
                    {
                        isFinished = true;
                        indices.Add(names.IndexOf(userQuery));
                        break;
                    }
                    index++;
                }
                foreach(int i in indices)
                {
                    Console.WriteLine(i);
                   
                }
                if (isFound)
                {
                    isFinished = true;
                    break;
                }
                
            }

            //Part 6
            List<string> moreNames = new List<string>() { "John", "Jacob", "Paul", "John", "Jared" };
            List<string> duplicates = new List<string>();
            foreach(string i in moreNames)
            {

                if(i == "John")
                {
                    duplicates.Add(i);
                    Console.WriteLine(i);
                    if (duplicates.Count > 1)
                    {
                        Console.WriteLine(i + " has appeared more than once");
                    };
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
