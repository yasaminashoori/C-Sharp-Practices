using System;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string adadString = "32";
            double mohit = Convert.ToDouble(adadString);
            Console.WriteLine(mohit);
            // we can't (until now) convert 32.3 in string format to double

            string stringAge = "23";
            int age = Convert.ToInt32(stringAge);
            Console.WriteLine(age.GetType());

            double number = 13.3;
            bool status = Convert.ToBoolean(number);
            Console.WriteLine(status);
            // we can't convert string to boolean

            int x = 12;
            double y = 12.564;
            y = x;
            Console.WriteLine(y);

            double h = Convert.ToDouble("200");
            Console.WriteLine(h);
        }
    }
}
