using System;

namespace Guess_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 100);

            int inputGuess = 0;

            int numberRound = 0;

            Boolean againPlay = true;

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

            Console.WriteLine("Do you want to play again ? Yes/ No");
            var answer = Console.ReadLine().ToUpper();
            againPlay = answer.ToUpper() == "YES";



            if (againPlay == true)
            {
                do
                {
                    Console.WriteLine("Guess a number between 1 - 100 :");
                    Console.ReadLine();
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

                } while (!againPlay);

                Console.WriteLine("Well done! The answer was " + randomNumber);
                Console.WriteLine($"{numberRound} Rounds");
            }

            else
            {
                Console.WriteLine("Thank you for playing ^-^");
            }

        }
    }
}
