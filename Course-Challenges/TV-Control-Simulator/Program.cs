using System;

namespace TV_Control_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {


            var channelNumber = 1;
            string selectedChannel = null;

            do
            {
                Console.WriteLine($"Do you like channel number {channelNumber++}? yes/no");
                selectedChannel = Console.ReadLine();
                // channelNumber++;
            } while (selectedChannel == "no");


            var favourite = selectedChannel == "yes" ? true : false;

            if (favourite)
            {
                Console.WriteLine($"channel {channelNumber - 1} added to your favourite! enjoy ^-^");
            }


            
























        }
    }
}
