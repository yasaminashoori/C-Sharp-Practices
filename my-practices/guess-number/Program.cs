using System;

namespace Guess_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int Guess = 0;

            var againPlay = true;
            do
            {
                Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");
                int returnValue = random.Next(1, 100);

                while (Guess != returnValue || againPlay == true)
                {
                    Guess = Convert.ToInt32(Console.ReadLine());

                    if (Guess < returnValue)
                    {
                        Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
                    }
                    else if (Guess > returnValue)
                    {
                        Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
                    }
                }

                Console.WriteLine("Well done! The answer was " + returnValue);
                Console.WriteLine("DO you want to play more ? yes or no ");
                againPlay = Console.ReadLine().ToUpper() == "YES";

            } while (againPlay);

            Console.WriteLine("Thanks for playing ^ --- ^ ");
        }
    }
}
