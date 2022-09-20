using System;

namespace Guess_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            int inputGuess = 0;

            int numberRound = 0;

            // bool againPlay = true;

            Console.Clear();
            Console.WriteLine("Hi ! in this game you should guess the random generated number. good luck :)");
            Console.WriteLine("Guess a number between 1 - 100 :");

            while (inputGuess != randomNumber)
            {
                inputGuess = Convert.ToInt32(Console.ReadLine());

                if (inputGuess < randomNumber)
                {
                    Console.WriteLine(inputGuess + "is too low! guess another number :");
                }
                else if (inputGuess > randomNumber)
                {
                    Console.WriteLine(inputGuess + "is too high! guess another number :");
                }
                numberRound++;
            }

            Console.WriteLine("Well done! The answer was " + randomNumber);
            Console.WriteLine($"{numberRound} Rounds");

            // play again ssection
            // Console.WriteLine("Do you want to play again ? Yes/ No");

            Random random2 = new Random();

            bool againPlay2 = true;

            do
            {
                int randomNumber2 = random2.Next(1, 101);

                int inputGuess2 = 0;

                int numberRound2 = 0;

                Console.WriteLine("Do you want to play again ? Yes/ No");

                var answer2 = Console.ReadLine().ToUpper();

                againPlay2 = answer2.ToUpper() == "YES";

                Console.WriteLine("Guess a number between 1 - 100 :");

                while (inputGuess2 != randomNumber2)
                {
                    inputGuess2 = Convert.ToInt32(Console.ReadLine());

                    if (inputGuess2 < randomNumber2)
                    {
                        Console.WriteLine(inputGuess2 + "is too low! guess another number :");
                    }
                    else if (inputGuess2 > randomNumber2)
                    {
                        Console.WriteLine(inputGuess2 + "is too high! guess another number :");
                    }
                    numberRound2++;
                    // Console.WriteLine("Do you want to play again ? Yes/ No");
                    // var answer3 = Console.ReadLine().ToUpper();
                    // againPlay2 = answer2.ToUpper() == "YES";
                }
                Console.WriteLine("Well done! The answer was " + randomNumber2);
                Console.WriteLine($"{numberRound2} Rounds");

            } while (againPlay2);

            Console.WriteLine("Thanks for playinig");
        }
    }
}