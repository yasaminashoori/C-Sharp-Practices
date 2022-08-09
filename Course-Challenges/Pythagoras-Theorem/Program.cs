using System;

namespace fisaghoresLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your side A : ");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your side B : ");
            
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            double pythagoras = Math.Sqrt(firstNumber * firstNumber + secondNumber * secondNumber);

            Console.WriteLine($"your result is : {pythagoras}");



        }
    }
}
