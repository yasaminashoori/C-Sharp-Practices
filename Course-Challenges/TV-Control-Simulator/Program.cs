using System;

namespace TV_Control_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {


           
            int numberChannel = 0;
            numberChannel = ++numberChannel;
            bool favChannel = true;
            do
            {
                Console.WriteLine($"do you like {numberChannel} channel ? yes or no");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("stay on this channel! enjoy :)");
                }

                else if (answer == "no")
                {
                    Console.WriteLine("do you like this channel ? yes or no");
                    var answerSecond = Console.ReadLine();

                    while (answerSecond == "no")
                    {

                        numberChannel = ++numberChannel;
                        Console.WriteLine($"we are on channel: {numberChannel}");
                        Console.WriteLine("do you like this channel ? yes or no");
                        Console.ReadLine();
                        if (answerSecond == "yes")
                            break;
                    }

                }

            }

            while (favChannel == "yes");


        }
    }
}
