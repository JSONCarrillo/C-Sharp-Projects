using System;

namespace Assignment_Seven
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lets play a game!");
            bool UserEnd = true;
            while (UserEnd = true)
            {
            Console.WriteLine("Pick a number between 1-100.");
            int Answer = Convert.ToInt32(Console.ReadLine());
            bool isCorrect = false;
            do
            {
                switch(Answer){
                    case 66:
                        Console.WriteLine("You got it!");
                        isCorrect = true;
                        break;
                    case 69:
                        Console.WriteLine("Nice, but no.");
                        Answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Wrong");
                        Answer = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isCorrect);
                Console.WriteLine("Play Again? (y/n)");
                string GameEnd = Console.ReadLine();

                if(GameEnd == "n"){
                    Console.WriteLine("Alright, cya!");
                    break;
                }

            }


        }
    }
}
