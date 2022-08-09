using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.WriteLine(PI);
            
            int x;
            x = 150;

            double y = -12.498;
            float small = 12.484f;
            long bigInt = -1303039933;
            Console.WriteLine("variables are " +  x +  y +  small +  bigInt);
            double first=12.3, second=194.43;
            Console.WriteLine($"the results are: {first} {second}");


        }
    }
}
