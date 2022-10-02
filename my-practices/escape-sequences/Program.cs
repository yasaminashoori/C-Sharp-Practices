using System;

namespace escape_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World! this is a test\bfor escape\rsequences");

            // Console.WriteLine("\tthis is anothertest !");

            // Console.WriteLine("\vthis is\vanothertest !");

            // Console.Write("this is another\ntest !\n");

            // *****************************************************************star 
            // for (int i = 1; i <= 6; i++)
            // {
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            // Console.WriteLine();
            // }

            /*************************************************************Tv channel challenge
            *make a var to check this is liked or not and at first it is false or null 
            * first : start from 1 channel
            * increase it every time that channel is false
            */

            // bool favChannel = false;
            // int numberChannel = 0;
            // do
            // {
            //     Console.WriteLine($"You are in channel {++numberChannel}.\nDo you like it ? (Yes or No) ");
            //     var userInputaAnswer = Console.ReadLine().ToUpper();
            //     if (userInputaAnswer == "YES" || userInputaAnswer == "Y")
            //     {
            //         favChannel = true;
            //         Console.WriteLine($"channel {numberChannel} is added to your favourite channel! \nEnjoy it  ^ --- ^ ");
            //         Environment.Exit(0);
            //     }
            //     else
            //     {
            //         favChannel = false;
            //     }
            // } while (favChannel == false);

            //*********************************guess number game 
            Random random = new Random();
            int myRandom = random.Next(1, 101);
            // int reounds = 0;
            bool userFinalGuess = false;
            int rounds = 0;
            var playAgain = "";
            do
            {
                Console.WriteLine("Guess a number between 1 - 100 :");
                var userInput = Convert.ToInt32(Console.ReadLine());
                while (userInput != myRandom || userInput == myRandom)
                {
                    if (userInput > myRandom)
                    {
                        Console.WriteLine($"{userInput} is too high !");
                    }
                    else if (userInput < myRandom)
                    {
                        Console.WriteLine($"{userInput} is too low !");
                    }
                    else
                    {
                        Console.WriteLine($"You win ! in {rounds} rounds !");
                    }
                    rounds++;
                }
                Console.WriteLine("DO you want to play again ? yes or no ");
                playAgain = Console.ReadLine().ToUpper();
                userFinalGuess = playAgain == "YES";
                if (playAgain == "YES")
                {

                }
            } while (userFinalGuess);
        }
    }
}