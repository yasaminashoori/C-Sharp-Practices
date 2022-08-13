using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // var myString = "yAsAmIn"
            // var myString = "092-2324-123";
            var myString = "Yasamin Ashoori";

            // var result = myString.ToUpper();
            // var result = myString.Replace("-", "@");
            var result = myString.Insert(0, "@");

            
            Console.WriteLine(result);
            
        }
    }
}
