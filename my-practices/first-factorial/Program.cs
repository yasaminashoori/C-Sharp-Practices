using System;

namespace first_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an int number : ");
            int result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstFactorial(result));
        }

        public static int FirstFactorial(int num)
        {
            if (num == 1)
                return 1;
            return num * FirstFactorial(--num);
        }

    }
}
