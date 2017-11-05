using System;

namespace NumericEx1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            int gallons;
            double mpg;
            string input;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            miles = int.Parse(input);
            Console.WriteLine("How many gallons of gas have you used?");
            input = Console.ReadLine();
            gallons = int.Parse(input);
            mpg = miles / gallons;
            Console.WriteLine("Your miles per gallon is: " + mpg);
            Console.ReadLine();
        }
    }
}
