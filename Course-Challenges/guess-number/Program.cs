using System;

namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random ();
            int myRandom = random.Next(1, 101);
            Console.WriteLine("Guess a number between 1 - 100 : ");
            var guessNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 100; i++)
            {
                if (guessNumber > myRandom)
                {
                    Console.WriteLine("Too high!");
                }

                if (guessNumber < myRandom)
                {
                    Console.WriteLine("Too loW!");
                }

                if (guessNumber == myRandom)
                {
                    Console.WriteLine("You win!");
                }
            }



            

            
        }
    }
}
