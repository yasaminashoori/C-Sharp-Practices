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

            Console.WriteLine("Guess a number between 1 - 100 : ");

            for (int i = 0; i < randomNumber; i++)
            {
                var numberRound = i++;
                Console.WriteLine($"{numberRound} rounds");
                while (inputGuess != randomNumber)
                {
                    inputGuess = Convert.ToInt32(Console.ReadLine());

                    if (inputGuess < randomNumber)
                    {
                        Console.WriteLine(inputGuess + " is too low! guess another number :");
                    }
                    else if (inputGuess > randomNumber)
                    {
                        Console.WriteLine(inputGuess + "is too high! guess another number :");
                    }

                }

            }

            var againPlay = Console.ReadLine();
            do
            {
                Console.WriteLine("Do you want to play again ? yes or no ");
                Console.ReadLine();
                for (int i = 0; i < randomNumber; i++)
                {
                    var numberRound = i++;
                    Console.WriteLine($"{numberRound} rounds");
                    while (inputGuess != randomNumber)
                    {
                        inputGuess = Convert.ToInt32(Console.ReadLine());

                        if (inputGuess < randomNumber)
                        {
                            Console.WriteLine(inputGuess + " is too low! guess another number :");
                        }
                        else if (inputGuess > randomNumber)
                        {
                            Console.WriteLine(inputGuess + "is too high! guess another number :");
                        }

                    }

                }

            } while (againPlay == "no");

            Console.WriteLine("Well done! The answer was " + randomNumber);
            // Console.WriteLine($"Done in {numberRound} rounds");
            // Console.WriteLine("Do you want to play again ? yes or no ");


            // if (againGuess == "yes")
            // {
            //     while (inputGuess != randomNumber)
            //     {
            //         inputGuess = Convert.ToInt32(Console.ReadLine());

            //         if (inputGuess < randomNumber)
            //         {
            //             Console.WriteLine(inputGuess + "is too high! guess another number :");
            //         }
            //         else if (inputGuess > randomNumber)
            //         {
            //             Console.WriteLine(inputGuess + "is too low! guess another number :");
            //         }
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Thanks for playing ^-^");
            // }



        }
    }
}
