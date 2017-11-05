using System;

namespace InputEx1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double area;
            string input;

            Console.WriteLine("What is the radius?");
            input = Console.ReadLine();
            radius = int.Parse(input);
            area = 3.14 * radius * radius;
            Console.WriteLine("The area of the circle with radius: " + radius + "is: " + area);
            Console.ReadLine();
        }
    }
}
