using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            GetUserInfo();

        }

        static void GetUserInfo()
        {
            Console.WriteLine("enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine("enter your aga: ");
            var age = Console.ReadLine();
            Console.WriteLine($"your name is {name} and you have {age} years old.");
        }
    }
}
