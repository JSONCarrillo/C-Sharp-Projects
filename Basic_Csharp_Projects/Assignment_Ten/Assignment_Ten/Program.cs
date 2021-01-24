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
            List<string> stringArray = new List<string>();
            while (!Done)
            {
                Console.WriteLine("Input some text. (Type DONE to move on.)");
                string userInput = Console.ReadLine();
                if (userInput == "DONE")
                {
                    Done = true;
                }
                else
                {
                    stringArray.Add(userInput);
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

            Console.WriteLine("Search for item in the array.");
            while (Done)
            {
                bool returnValue = false;
                string userQuery = Console.ReadLine();
                foreach(string i in arraySearch)
                {
                    if(userQuery == i)
                    {
                        Console.WriteLine(arraySearch.IndexOf(i));
                        returnValue = true;
                        Done = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if(!returnValue)
                {
                    Console.WriteLine("Could not find search request");
                    Done = false;
                    break;
                }
            }

            //Part 5
            bool isFinished = false;
            List<string> names = new List<string>() {"Jen", "Dawson", "Joey", "Jen" };
            List<int> indices = new List<int>();

            Console.WriteLine("Search for name.");
            while (!isFinished)
            {
                bool returnValue = false;
                string nameQuery = Console.ReadLine();
                foreach (string i in names)
                {
                    if (nameQuery == i)
                    {
                        returnValue = true;
                        if(i == nameQuery)
                        {
                            indices.Add(names.IndexOf(i));
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                if (!returnValue)
                {
                    Console.WriteLine("Could not find search request");
                    isFinished = true;
                    break;
                }
                else
                {
                    Console.WriteLine(indices.Count);
                    isFinished = true;
                    break;
                }
            }

            //Part 6
            List<string> moreNames = new List<string>() { "John", "Jacob", "Paul", "John", "Jared" };
            List<string> duplicates = new List<string>();

            foreach(string i in moreNames)
            {
                Console.WriteLine(i);
                if(i == "John"){
                    duplicates.Add(i);
                    continue;
                };
                if(duplicates.Count > 1)
                {
                    Console.WriteLine("John appears " + duplicates.Count + " times");
                    continue;
                }

            }
        }
    }
}
