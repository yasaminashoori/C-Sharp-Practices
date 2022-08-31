using System;

namespace Days_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string dayName;
            Console.WriteLine("Please enter a number from 1 to  7 : ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                dayName = "Saturday";
                Console.WriteLine("Today is Saturday");
            }
            else if (day == 2)
            {
                dayName = "Sunday";
                Console.WriteLine("Today is Sunday");
            }
            else if (day == 3)
            {
                dayName = "Monday";
                Console.WriteLine("Today is Munday");
            }
            else if (day == 4)
            {
                dayName = "Tuesday";
                Console.WriteLine("Today is Tuesday");
            }
            else if (day == 5)
            {
                dayName = "Wednesday";
                Console.WriteLine("Today is Wednesday");
            }
            else if (day == 6)
            {
                dayName = "Thursday";
                Console.WriteLine("Today is Thursday");
            }
            else if (day == 7)
            {
                dayName = "Friday";
                Console.WriteLine("Today is Friday");
            }
            else
            {
                Console.WriteLine("This is invalid name !");
                
            }

        }
    }
}
